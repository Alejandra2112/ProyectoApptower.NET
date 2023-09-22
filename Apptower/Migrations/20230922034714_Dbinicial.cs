using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apptower.Migrations
{
    /// <inheritdoc />
    public partial class Dbinicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Espacios",
            //    columns: table => new
            //    {
            //        IdEspacio = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        NombreEspacio = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
            //        TipoEspacio = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
            //        Area = table.Column<double>(type: "float", nullable: true),
            //        Capacidad = table.Column<int>(type: "int", nullable: true),
            //        EstadoEspacio = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('ACTIVO')")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKIdEspacios", x => x.IdEspacio);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Parqueaderos",
            //    columns: table => new
            //    {
            //        IdParqueadero = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        NombreParqueadero = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
            //        TipoParqueadero = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        EstadoParqueadero = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValueSql: "('ACTIVO')")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKParqueaderos", x => x.IdParqueadero);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Propietarios",
            //    columns: table => new
            //    {
            //        IdPropietario = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TipoDocumentoPropietario = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
            //        NumeroDocumentoPropietario = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        NombrePropietario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
            //        ApellidoPropietario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
            //        FechaNacimientoPropietario = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CorreoPropietario = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
            //        TelefonoPropietario = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        EstadoPropietario = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('ACTIVO')")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKIdPropietario", x => x.IdPropietario);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Usuarios",
            //    columns: table => new
            //    {
            //        IdUsuario = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Apellido = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        IdRol = table.Column<int>(type: "int", nullable: true),
            //        TipoDocumento = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
            //        Documento = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        Correo = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
            //        fecha_creacion = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
            //        estado = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValueSql: "('ACTIVO')"),
            //        Telefono = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        Contrasena = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PkIdUsuario", x => x.IdUsuario);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vehiculos",
            //    columns: table => new
            //    {
            //        IdVehiculo = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Placa = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
            //        TipoUsuarioVehiculo = table.Column<int>(type: "int", nullable: false),
            //        NombrePropietarioVehiculo = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKVehiculos", x => x.IdVehiculo);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Visitantes",
            //    columns: table => new
            //    {
            //        IdVisitante = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TipoDocumentoVisitante = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
            //        NumeroDocumentoVisitante = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
            //        NombreVisitante = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
            //        ApellidoVisitante = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
            //        GeneroVisitante = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValueSql: "('OTRO')"),
            //        PermisoVisitante = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('ACTIVO')")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKIdVisitante", x => x.IdVisitante);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "Residentes",
            //    columns: table => new
            //    {
            //        IdResidente = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TipoDocumentoResidente = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
            //        NumeroDocumentoResidente = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
            //        NombreResidente = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
            //        ApellidoResidente = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
            //        FechaNacimientoResidente = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CorreoResidente = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
            //        TelefonoResidente = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
            //        TipoResidente = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "('PROPIETARIO')"),
            //        ResidenciaActual = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
            //        IdEspacio = table.Column<int>(type: "int", nullable: false),
            //        FechaInicioResidencia = table.Column<DateTime>(type: "datetime", nullable: false),
            //        FechaFinResidencia = table.Column<DateTime>(type: "datetime", nullable: true),
            //        EstadoResidente = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('ACTIVO')")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKIdResidente", x => x.IdResidente);
            //        table.ForeignKey(
            //            name: "FKEspacio",
            //            column: x => x.IdEspacio,
            //            principalTable: "Espacios",
            //            principalColumn: "IdEspacio");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ParqueaderosDeEspacios",
            //    columns: table => new
            //    {
            //        IdParqueaderosDeEspacios = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdEspacio = table.Column<int>(type: "int", nullable: true),
            //        IdParqueadero = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKParqueaderosDeEspacios", x => x.IdParqueaderosDeEspacios);
            //        table.ForeignKey(
            //            name: "FKIdEspacio",
            //            column: x => x.IdEspacio,
            //            principalTable: "Espacios",
            //            principalColumn: "IdEspacio");
            //        table.ForeignKey(
            //            name: "FKIdParqueaderos",
            //            column: x => x.IdParqueadero,
            //            principalTable: "Parqueaderos",
            //            principalColumn: "IdParqueadero");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PropietariosPorEspacio",
            //    columns: table => new
            //    {
            //        IdPropietariosPorEspacio = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdEspacio = table.Column<int>(type: "int", nullable: true),
            //        IdPropietario = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKPropietariosPorEspacio", x => x.IdPropietariosPorEspacio);
            //        table.ForeignKey(
            //            name: "FKEspacios3",
            //            column: x => x.IdEspacio,
            //            principalTable: "Espacios",
            //            principalColumn: "IdEspacio");
            //        table.ForeignKey(
            //            name: "FKPropietarios3",
            //            column: x => x.IdPropietario,
            //            principalTable: "Propietarios",
            //            principalColumn: "IdPropietario");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Reservas",
            //    columns: table => new
            //    {
            //        IdReserva = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdUsuario = table.Column<int>(type: "int", nullable: true),
            //        TipoReserva = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
            //        FechaReserva = table.Column<int>(type: "int", nullable: false),
            //        EspacioReserva = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
            //        CantidadPersonas = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKReserva", x => x.IdReserva);
            //        table.ForeignKey(
            //            name: "FKUsuario",
            //            column: x => x.IdUsuario,
            //            principalTable: "Usuarios",
            //            principalColumn: "IdUsuario");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VehiculosPorEspacio",
            //    columns: table => new
            //    {
            //        IdVehiculosPorEspacio = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdEspacio = table.Column<int>(type: "int", nullable: true),
            //        IdVehiculo = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKIdVehiculosPorEspacio", x => x.IdVehiculosPorEspacio);
            //        table.ForeignKey(
            //            name: "FKEspacios2",
            //            column: x => x.IdEspacio,
            //            principalTable: "Espacios",
            //            principalColumn: "IdEspacio");
            //        table.ForeignKey(
            //            name: "FKVehiculo2",
            //            column: x => x.IdVehiculo,
            //            principalTable: "Vehiculos",
            //            principalColumn: "IdVehiculo");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VisitantesPorEspacio",
            //    columns: table => new
            //    {
            //        IdVisitantePorEspacio = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdEspacio = table.Column<int>(type: "int", nullable: true),
            //        IdVisitante = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKIdVisitantePorEspacio", x => x.IdVisitantePorEspacio);
            //        table.ForeignKey(
            //            name: "FKEspacios1",
            //            column: x => x.IdEspacio,
            //            principalTable: "Espacios",
            //            principalColumn: "IdEspacio");
            //        table.ForeignKey(
            //            name: "FKVisitante1",
            //            column: x => x.IdVisitante,
            //            principalTable: "Visitantes",
            //            principalColumn: "IdVisitante");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ReservasEspacios",
            //    columns: table => new
            //    {
            //        IdReservaEspacios = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdReserva = table.Column<int>(type: "int", nullable: true),
            //        IdEspacio = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKReservaEspacios", x => x.IdReservaEspacios);
            //        table.ForeignKey(
            //            name: "FKEspacio1",
            //            column: x => x.IdEspacio,
            //            principalTable: "Espacios",
            //            principalColumn: "IdEspacio");
            //        table.ForeignKey(
            //            name: "FKReserva1",
            //            column: x => x.IdReserva,
            //            principalTable: "Reservas",
            //            principalColumn: "IdReserva");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ReservasParqueadero",
            //    columns: table => new
            //    {
            //        IdReservaEspacios = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IdReserva = table.Column<int>(type: "int", nullable: true),
            //        IdParqueadero = table.Column<int>(type: "int", nullable: true),
            //        IdVehiculo = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PKReservaParqueadero", x => x.IdReservaEspacios);
            //        table.ForeignKey(
            //            name: "FKParqueadero2",
            //            column: x => x.IdParqueadero,
            //            principalTable: "Parqueaderos",
            //            principalColumn: "IdParqueadero");
            //        table.ForeignKey(
            //            name: "FKReserva2",
            //            column: x => x.IdReserva,
            //            principalTable: "Reservas",
            //            principalColumn: "IdReserva");
            //        table.ForeignKey(
            //            name: "FKVehiculo",
            //            column: x => x.IdVehiculo,
            //            principalTable: "Vehiculos",
            //            principalColumn: "IdVehiculo");
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Espacios__585163C086FD1B28",
            //    table: "Espacios",
            //    column: "NombreEspacio",
            //    unique: true,
            //    filter: "[NombreEspacio] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "UNNombreParqueadro",
            //    table: "Parqueaderos",
            //    column: "NombreParqueadero",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_ParqueaderosDeEspacios_IdEspacio",
            //    table: "ParqueaderosDeEspacios",
            //    column: "IdEspacio");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ParqueaderosDeEspacios_IdParqueadero",
            //    table: "ParqueaderosDeEspacios",
            //    column: "IdParqueadero");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PropietariosPorEspacio_IdEspacio",
            //    table: "PropietariosPorEspacio",
            //    column: "IdEspacio");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PropietariosPorEspacio_IdPropietario",
            //    table: "PropietariosPorEspacio",
            //    column: "IdPropietario");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Reservas_IdUsuario",
            //    table: "Reservas",
            //    column: "IdUsuario");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ReservasEspacios_IdEspacio",
            //    table: "ReservasEspacios",
            //    column: "IdEspacio");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ReservasEspacios_IdReserva",
            //    table: "ReservasEspacios",
            //    column: "IdReserva");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ReservasParqueadero_IdParqueadero",
            //    table: "ReservasParqueadero",
            //    column: "IdParqueadero");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ReservasParqueadero_IdReserva",
            //    table: "ReservasParqueadero",
            //    column: "IdReserva");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ReservasParqueadero_IdVehiculo",
            //    table: "ReservasParqueadero",
            //    column: "IdVehiculo");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Residentes_IdEspacio",
            //    table: "Residentes",
            //    column: "IdEspacio");

            //migrationBuilder.CreateIndex(
            //    name: "UCPlaca",
            //    table: "Vehiculos",
            //    column: "Placa",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_VehiculosPorEspacio_IdEspacio",
            //    table: "VehiculosPorEspacio",
            //    column: "IdEspacio");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VehiculosPorEspacio_IdVehiculo",
            //    table: "VehiculosPorEspacio",
            //    column: "IdVehiculo");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VisitantesPorEspacio_IdEspacio",
            //    table: "VisitantesPorEspacio",
            //    column: "IdEspacio");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VisitantesPorEspacio_IdVisitante",
            //    table: "VisitantesPorEspacio",
            //    column: "IdVisitante");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            //migrationBuilder.DropTable(
            //    name: "ParqueaderosDeEspacios");

            //migrationBuilder.DropTable(
            //    name: "PropietariosPorEspacio");

            //migrationBuilder.DropTable(
            //    name: "ReservasEspacios");

            //migrationBuilder.DropTable(
            //    name: "ReservasParqueadero");

            //migrationBuilder.DropTable(
            //    name: "Residentes");

            //migrationBuilder.DropTable(
            //    name: "VehiculosPorEspacio");

            //migrationBuilder.DropTable(
            //    name: "VisitantesPorEspacio");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            //migrationBuilder.DropTable(
            //    name: "Propietarios");

            //migrationBuilder.DropTable(
            //    name: "Parqueaderos");

            //migrationBuilder.DropTable(
            //    name: "Reservas");

            //migrationBuilder.DropTable(
            //    name: "Vehiculos");

            //migrationBuilder.DropTable(
            //    name: "Espacios");

            //migrationBuilder.DropTable(
            //    name: "Visitantes");

            //migrationBuilder.DropTable(
            //    name: "Usuarios");
        }
    }
}
