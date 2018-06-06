using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BeingBeing.Migrations
{
    public partial class ModelsPlusDefaults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cat",
                table: "Working",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat",
                table: "Weather",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat",
                table: "Social",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat",
                table: "Sleep",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat",
                table: "Sickness",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat",
                table: "Poop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat",
                table: "Exercise",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat",
                table: "EmotionalStates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat",
                table: "Consumings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cat",
                table: "Appetite",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cat = table.Column<string>(nullable: true),
                    DateState = table.Column<DateTime>(nullable: false),
                    Dose = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pills", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pills");

            migrationBuilder.DropColumn(
                name: "Cat",
                table: "Working");

            migrationBuilder.DropColumn(
                name: "Cat",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "Cat",
                table: "Social");

            migrationBuilder.DropColumn(
                name: "Cat",
                table: "Sleep");

            migrationBuilder.DropColumn(
                name: "Cat",
                table: "Sickness");

            migrationBuilder.DropColumn(
                name: "Cat",
                table: "Poop");

            migrationBuilder.DropColumn(
                name: "Cat",
                table: "Exercise");

            migrationBuilder.DropColumn(
                name: "Cat",
                table: "EmotionalStates");

            migrationBuilder.DropColumn(
                name: "Cat",
                table: "Consumings");

            migrationBuilder.DropColumn(
                name: "Cat",
                table: "Appetite");
        }
    }
}
