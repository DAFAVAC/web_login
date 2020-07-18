using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedioAmbienteWeb.Data.Migrations
{
    public partial class SubirImagenPersona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Fotografia",
                table: "Personas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fotografia",
                table: "Personas");
        }
    }
}
