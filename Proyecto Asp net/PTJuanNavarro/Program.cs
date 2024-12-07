using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using PTJuanNavarro.Services;
using PTJuanNavarro.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SegurosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Cadena_con")));

// Registrar el EncryptionService
string key = "0123456789ABCDEF";
string iv = "ABCDEF0123456789";
builder.Services.AddSingleton(new EncryptionService(key, iv));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cuenta}/{action=TipoCuenta}/{id?}");

app.Run();

