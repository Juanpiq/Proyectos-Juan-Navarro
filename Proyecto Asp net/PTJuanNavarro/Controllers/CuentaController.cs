using Microsoft.AspNetCore.Mvc;
using PTJuanNavarro.Models;
using PTJuanNavarro.Services;

namespace PTJuanNavarro.Controllers
{
    public class CuentaController : Controller
    {
        private readonly SegurosContext _context;
        private readonly EncryptionService _encryptionService;

        // Constructor para inyectar el contexto y el servicio de cifrado
        public CuentaController(SegurosContext context, EncryptionService encryptionService)
        {
            _context = context;
            _encryptionService = encryptionService;
        }

        //mostrar la página principal "Tipo de usuario"
        [HttpGet]
        public IActionResult TipoCuenta()
        {
            return View();
        }

        //mostrar la página de inicio de sesión de administrador
        [HttpGet]
        public IActionResult LoginAdmin()
        {
            return View();
        }

        //inicio de sesión de administrador
        [HttpPost]
        public IActionResult LoginAdmin(LoginAdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Usuarios
                    .SingleOrDefault(u => u.NombreUsuario == model.nombre_usuario);

                if (user != null)
                {
                    var passwordData = _context.ContraseñasAdministradores
                        .SingleOrDefault(p => p.NombreUsuario == model.nombre_usuario);

                    if (passwordData != null)
                    {
                        var hashedPassword = _encryptionService.Encrypt(model.Password + passwordData.Salting);
                        if (hashedPassword == passwordData.Hash)
                        {
                            return RedirectToAction("CuentaAdmin", "Cuenta", new { id = user.Id });
                        }
                    }
                }

                ModelState.AddModelError("", "Nombre de usuario o contraseña incorrectos.");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult CuentaAdmin(int id)
        {
            var admin = _context.Administradores.SingleOrDefault(a => a.Id == id);
            if (admin == null)
            {
                return NotFound();
            }

            var clientesCotizaciones = _context.Clientes
                .Select(cliente => new ClienteCotizacionViewModel
                {
                    ClienteId = cliente.Id,
                    NombreUsuario = _context.Usuarios.SingleOrDefault(u => u.Id == cliente.Id).NombreUsuario,
                    Cotizaciones = _context.Cotizaciones
                        .Where(c => c.ClienteId == cliente.Id)
                        .Select(cotizacion => new CotizacionCarroViewModel
                        {
                            CotizacionId = cotizacion.Id,
                            FechaCotizacion = cotizacion.FechaCotizacion,
                            Modelo = _context.Carros.SingleOrDefault(car => car.Id == cotizacion.CarroId).Modelo,
                            Precio = cotizacion.Precio
                        }).ToList()
                }).ToList();

            var viewModel = new CuentaAdminViewModel
            {
                Nombre = admin.Nombre,
                Apellido = admin.Apellido,
                ClientesCotizaciones = clientesCotizaciones
            };

            return View(viewModel);
        }



        //mostrar la página de registro de administrador
        [HttpGet]
        public IActionResult RegisAdmin()
        {
            return View();
        }

        //registro de un nuevo administrador
        [HttpPost]
        public IActionResult RegisAdmin(RegisAdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _context.Usuarios
                    .Any(u => u.NombreUsuario == model.nombre_usuario);

                if (existingUser)
                {
                    ModelState.AddModelError("", "El nombre de usuario ya está en uso.");
                    return View(model);
                }

                var newUser = new Usuario
                {
                    NombreUsuario = model.nombre_usuario,
                    TipoUsuario = "Administrador"
                };
                _context.Usuarios.Add(newUser);
                _context.SaveChanges();

                var salt = GenerateSalt();
                var hashedPassword = _encryptionService.Encrypt(model.password + salt);
                var newPassword = new ContraseñasAdministradore
                {
                    NombreUsuario = model.nombre_usuario,
                    Hash = hashedPassword,
                    Salting = salt
                };
                _context.ContraseñasAdministradores.Add(newPassword);
                _context.SaveChanges();

                var newAdminid = _context.Usuarios
                        .SingleOrDefault(u => u.NombreUsuario == model.nombre_usuario);

                var newAdmin = new Administradore
                {
                    Id = newAdminid.Id,
                    Nombre = model.nombre,
                    Apellido = model.apellido,
                    Email = model.email,
                };
                _context.Administradores.Add(newAdmin);
                _context.SaveChanges();

                return RedirectToAction("LoginAdmin");
            }

            return View(model);
        }

        //mostrar la página de inicio de sesión de cliente
        [HttpGet]
        public IActionResult LoginCliente()
        {
            return View();
        }

        //inicio de sesión de cliente
        [HttpPost]
        public IActionResult LoginCliente(LoginClienteViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Usuarios
                    .SingleOrDefault(u => u.NombreUsuario == model.nombre_usuario);

                if (user != null)
                {
                    var passwordData = _context.ContraseñasClientes
                        .SingleOrDefault(p => p.NombreUsuario == model.nombre_usuario);

                    if (passwordData != null)
                    {
                        var hashedPassword = _encryptionService.Encrypt(model.password + passwordData.Salting);
                        if (hashedPassword == passwordData.Hash)
                        {
                            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == user.Id);
                            return RedirectToAction("CuentaCliente", new { id = cliente.Id });
                        }
                    }
                }

                ModelState.AddModelError("", "Nombre de usuario o contraseña incorrectos.");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult CuentaCliente(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            var cotizaciones = _context.Cotizaciones
                .Where(c => c.ClienteId == id)
                .Select(cotizacion => new CotizacionViewModel
                {
                    Id = cotizacion.Id,
                    FechaCotizacion = _encryptionService.Encrypt(cotizacion.FechaCotizacion.ToString()),
                    ModeloCarro = _encryptionService.Encrypt(_context.Carros.SingleOrDefault(car => car.Id == cotizacion.CarroId).Modelo),
                    Precio = _encryptionService.Encrypt(cotizacion.Precio.ToString())
                }).ToList();

            var viewModel = new CuentaClienteViewModel
            {
                ClienteId = cliente.Id,
                Nombre = _encryptionService.Decrypt(cliente.Nombre),
                Apellido = _encryptionService.Decrypt(cliente.Apellido),
                Cotizaciones = cotizaciones
            };

            return View(viewModel);
        }

        //mostrar la página de creación de cotización
        [HttpGet]
        public IActionResult CrearCotizacion(int clienteId)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == clienteId);
            var ultimaCotizacion = _context.Cotizaciones.OrderByDescending(c => c.Id).FirstOrDefault();

            var viewModel = new CrearCotizacionViewModel
            {
                ClienteId = clienteId,
                Nombre = _encryptionService.Decrypt(cliente.Nombre),
                Apellido = _encryptionService.Decrypt(cliente.Apellido),
                UltimaCotizacionId = ultimaCotizacion != null ? ultimaCotizacion.Id : 0
            };

            return View(viewModel);
        }

        // Acción para guardar la nueva cotización
        [HttpPost]
        public IActionResult CrearCotizacion(CrearCotizacionViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Calcular el precio de la cotización
                DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now);
                var anioActual = DateTime.Now.Year;

                decimal costoAuto = model.CostoAuto;
                int anioFabricacion = model.AnioFabricacion;

                decimal diferenciaAnios = anioActual - anioFabricacion;
                decimal precio = (costoAuto / diferenciaAnios) * 0.0035m;
                decimal precioRedondeado = Math.Round(precio, 2);

                // Crear y guardar el carro

                try
                {
                    var nuevoCarro = new Carro
                    {
                        Marca = model.Marca,
                        ClienteId = model.ClienteId,
                        Modelo = model.Modelo,
                        Año = model.AnioFabricacion,
                        Costo = model.CostoAuto,
                        TipoSeguro = model.TipoSeguro,
                        Cobertura = model.Cobertura,
                    };

                    _context.Carros.Add(nuevoCarro);
                    _context.SaveChanges();

                    // Crear y guardar la nueva cotización
                    var nuevaCotizacion = new Cotizacione
                    {
                        ClienteId = model.ClienteId,
                        CarroId = nuevoCarro.Id,
                        Precio = precioRedondeado,
                        FechaCotizacion = fechaActual
                    };

                    _context.Cotizaciones.Add(nuevaCotizacion);
                    _context.SaveChanges();
                }catch(Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }

                

                return RedirectToAction("CuentaCliente", new { id = model.ClienteId });
            }

            return View(model);
        }



        // Acción para mostrar la página de registro de cliente
        [HttpGet]
        public IActionResult RegisCliente()
        {
            return View();
        }

        // Acción para manejar el registro de un nuevo cliente
        [HttpPost]
        public IActionResult RegisCliente(RegisClienteViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _context.Usuarios
                    .Any(u => u.NombreUsuario == model.nombre_usuario);

                if (existingUser)
                {
                    ModelState.AddModelError("", "El nombre de usuario ya está en uso.");
                    return View(model);
                }

                var newUser = new Usuario
                {
                    NombreUsuario = model.nombre_usuario,
                    TipoUsuario = "Cliente"
                };
                _context.Usuarios.Add(newUser);
                _context.SaveChanges();

                var salt = GenerateSalt();
                var hashedPassword = _encryptionService.Encrypt(model.password + salt);
                var newPassword = new ContraseñasCliente
                {
                    NombreUsuario = model.nombre_usuario,
                    Hash = hashedPassword,
                    Salting = salt
                };
                _context.ContraseñasClientes.Add(newPassword);
                _context.SaveChanges();

                var newCLienteid = _context.Usuarios
                        .SingleOrDefault(u => u.NombreUsuario == model.nombre_usuario);

                var newCliente = new Cliente
                {
                    Id = newCLienteid.Id,
                    Nombre = _encryptionService.Encrypt(model.nombre),
                    Apellido = _encryptionService.Encrypt(model.apellido),
                    Email = _encryptionService.Encrypt(model.email),
                    Telefono = _encryptionService.Encrypt(model.telefono)
                };
                _context.Clientes.Add(newCliente);
                _context.SaveChanges();

                return RedirectToAction("LoginCliente");
            }

            return View(model);
        }

        // Método para generar un salt aleatorio
        private string GenerateSalt()
        {
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[16];
                rng.GetBytes(saltBytes);
                return Convert.ToBase64String(saltBytes);
            }
        }
    }
}