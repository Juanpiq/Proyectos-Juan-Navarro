using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PTJuanNavarro.Migrations
{
    /// <inheritdoc />
    public partial class AddCostoToCarro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_usuario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    tipo_usuario = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuarios__3213E83F431B08BC", x => x.id);
                    table.UniqueConstraint("AK_Usuarios_nombre_usuario", x => x.nombre_usuario);
                });

            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    apellido = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Administ__3213E83F344ED028", x => x.id);
                    table.ForeignKey(
                        name: "FK__Administrado__id__3F466844",
                        column: x => x.id,
                        principalTable: "Usuarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    apellido = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    telefono = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Clientes__3213E83F00241ED7", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Usuarios",
                        column: x => x.id,
                        principalTable: "Usuarios",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "ContraseñasAdministradores",
                columns: table => new
                {
                    nombre_usuario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    salting = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    hash = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Contrase__D4D22D758B563E6E", x => x.nombre_usuario);
                    table.ForeignKey(
                        name: "FK__Contraseñ__nombr__4E88ABD4",
                        column: x => x.nombre_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "nombre_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContraseñasClientes",
                columns: table => new
                {
                    nombre_usuario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    salting = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    hash = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Contrase__D4D22D75B59B915C", x => x.nombre_usuario);
                    table.ForeignKey(
                        name: "FK__Contraseñ__nombr__4AB81AF0",
                        column: x => x.nombre_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "nombre_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente_id = table.Column<int>(type: "int", nullable: true),
                    marca = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    modelo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    año = table.Column<int>(type: "int", nullable: false),
                    tipo_seguro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cobertura = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    costo = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Carros__3213E83FFFE81C6B", x => x.id);
                    table.ForeignKey(
                        name: "FK_Carros_Clientes",
                        column: x => x.cliente_id,
                        principalTable: "Clientes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Cotizaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente_id = table.Column<int>(type: "int", nullable: true),
                    carro_id = table.Column<int>(type: "int", nullable: true),
                    fecha_cotizacion = table.Column<DateOnly>(type: "date", nullable: false),
                    precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cotizaci__3213E83F1F296336", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Carros",
                        column: x => x.carro_id,
                        principalTable: "Carros",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Cotizaciones_Clientes",
                        column: x => x.cliente_id,
                        principalTable: "Clientes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Administ__AB6E61647F741D80",
                table: "Administradores",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carros_cliente_id",
                table: "Carros",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Clientes__AB6E6164707A65A8",
                table: "Clientes",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Contrase__D4D22D7490E7D8D6",
                table: "ContraseñasAdministradores",
                column: "nombre_usuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Contrase__D4D22D748BC0F712",
                table: "ContraseñasClientes",
                column: "nombre_usuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_carro_id",
                table: "Cotizaciones",
                column: "carro_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizaciones_cliente_id",
                table: "Cotizaciones",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Usuarios__D4D22D74C9DFDBDF",
                table: "Usuarios",
                column: "nombre_usuario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "ContraseñasAdministradores");

            migrationBuilder.DropTable(
                name: "ContraseñasClientes");

            migrationBuilder.DropTable(
                name: "Cotizaciones");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
