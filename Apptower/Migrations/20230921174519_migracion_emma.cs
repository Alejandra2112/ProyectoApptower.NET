using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apptower.Migrations
{
    /// <inheritdoc />
    public partial class migracion_emma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FKEspacios",
                table: "Parqueaderos");

            migrationBuilder.DropIndex(
                name: "IX_Parqueaderos_IdEspacio",
                table: "Parqueaderos");

            migrationBuilder.DropColumn(
                name: "IdEspacio",
                table: "Parqueaderos");

            migrationBuilder.RenameIndex(
                name: "UQ__Espacios__585163C0618565D3",
                table: "Espacios",
                newName: "UQ__Espacios__585163C086FD1B28");

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

            migrationBuilder.CreateTable(
                name: "ParqueaderosDeEspacios",
                columns: table => new
                {
                    IdParqueaderosDeEspacios = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEspacio = table.Column<int>(type: "int", nullable: true),
                    IdParqueadero = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKParqueaderosDeEspacios", x => x.IdParqueaderosDeEspacios);
                    table.ForeignKey(
                        name: "FKIdEspacio",
                        column: x => x.IdEspacio,
                        principalTable: "Espacios",
                        principalColumn: "IdEspacio");
                    table.ForeignKey(
                        name: "FKIdParqueaderos",
                        column: x => x.IdParqueadero,
                        principalTable: "Parqueaderos",
                        principalColumn: "IdParqueadero");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParqueaderosDeEspacios_IdEspacio",
                table: "ParqueaderosDeEspacios",
                column: "IdEspacio");

            migrationBuilder.CreateIndex(
                name: "IX_ParqueaderosDeEspacios_IdParqueadero",
                table: "ParqueaderosDeEspacios",
                column: "IdParqueadero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParqueaderosDeEspacios");

            migrationBuilder.RenameIndex(
                name: "UQ__Espacios__585163C086FD1B28",
                table: "Espacios",
                newName: "UQ__Espacios__585163C0618565D3");

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

            migrationBuilder.AddColumn<int>(
                name: "IdEspacio",
                table: "Parqueaderos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parqueaderos_IdEspacio",
                table: "Parqueaderos",
                column: "IdEspacio");

            migrationBuilder.AddForeignKey(
                name: "FKEspacios",
                table: "Parqueaderos",
                column: "IdEspacio",
                principalTable: "Espacios",
                principalColumn: "IdEspacio");
        }
    }
}
