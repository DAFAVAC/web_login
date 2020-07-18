using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedioAmbienteWeb.Data.Migrations
{
    public partial class FotografiaPerfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fotografia",
                table: "Personas");

            migrationBuilder.AddColumn<byte[]>(
                name: "FotografiaPerfil",
                table: "Personas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotografiaPerfil",
                table: "Personas");

            migrationBuilder.AddColumn<byte[]>(
                name: "Fotografia",
                table: "Personas",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
