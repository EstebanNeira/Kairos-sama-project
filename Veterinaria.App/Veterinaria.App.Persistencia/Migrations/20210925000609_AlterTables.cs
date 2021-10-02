using Microsoft.EntityFrameworkCore.Migrations;

namespace Veterinaria.App.Persistencia.Migrations
{
    public partial class AlterTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEspecie",
                table: "Raza");

            migrationBuilder.DropColumn(
                name: "IdCuidador",
                table: "Mascota");

            migrationBuilder.DropColumn(
                name: "IdGenero",
                table: "Mascota");

            migrationBuilder.DropColumn(
                name: "IdRaza",
                table: "Mascota");

            migrationBuilder.DropColumn(
                name: "IdAtencion",
                table: "Cita");

            migrationBuilder.DropColumn(
                name: "IdMascota",
                table: "Cita");

            migrationBuilder.DropColumn(
                name: "IdTipoCita",
                table: "Cita");

            migrationBuilder.DropColumn(
                name: "idVeterinario",
                table: "Cita");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEspecie",
                table: "Raza",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCuidador",
                table: "Mascota",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdGenero",
                table: "Mascota",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdRaza",
                table: "Mascota",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAtencion",
                table: "Cita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMascota",
                table: "Cita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoCita",
                table: "Cita",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idVeterinario",
                table: "Cita",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
