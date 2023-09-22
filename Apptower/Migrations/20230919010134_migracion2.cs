using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apptower.Migrations
{
    /// <inheritdoc />
    public partial class migracion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "fecha_creacion",
                table: "Usuarios",
                type: "date",
                nullable: true,
                defaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoResidente",
                table: "Residentes",
                type: "varchar(15)",
                unicode: false,
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldUnicode: false,
                oldMaxLength: 15,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fecha_creacion",
                table: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "TelefonoResidente",
                table: "Residentes",
                type: "varchar(15)",
                unicode: false,
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldUnicode: false,
                oldMaxLength: 15);
        }
    }
}
