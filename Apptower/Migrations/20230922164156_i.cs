using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apptower.Migrations
{
    /// <inheritdoc />
    public partial class i : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UQ__Espacios__585163C086FD1B28",
                table: "Espacios");

            migrationBuilder.AlterColumn<string>(
                name: "TipoUsuarioVehiculo",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NombrePropietarioVehiculo",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaReserva",
                table: "Reservas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NombreEspacio",
                table: "Espacios",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Espacios__585163C086FD1B28",
                table: "Espacios",
                column: "NombreEspacio",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UQ__Espacios__585163C086FD1B28",
                table: "Espacios");

            migrationBuilder.AlterColumn<int>(
                name: "TipoUsuarioVehiculo",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "NombrePropietarioVehiculo",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FechaReserva",
                table: "Reservas",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "NombreEspacio",
                table: "Espacios",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldUnicode: false,
                oldMaxLength: 255);

            migrationBuilder.CreateIndex(
                name: "UQ__Espacios__585163C086FD1B28",
                table: "Espacios",
                column: "NombreEspacio",
                unique: true,
                filter: "[NombreEspacio] IS NOT NULL");
        }
    }
}
