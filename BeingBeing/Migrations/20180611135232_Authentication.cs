using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BeingBeing.Migrations
{
    public partial class Authentication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Working",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Weather",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Social",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Sleep",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Sickness",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Poop",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Pills",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Exercise",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "EmotionalStates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Consumings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Appetite",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Arms = table.Column<int>(nullable: false),
                    BodyFat = table.Column<int>(nullable: false),
                    Cat = table.Column<string>(nullable: true),
                    Chest = table.Column<int>(nullable: false),
                    DateState = table.Column<DateTime>(nullable: false),
                    Diastolic = table.Column<int>(nullable: false),
                    HDL = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    LDL = table.Column<int>(nullable: false),
                    Legs = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    Systolic = table.Column<int>(nullable: false),
                    VLDL = table.Column<int>(nullable: false),
                    Waist = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Working");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Social");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Sleep");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Sickness");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Poop");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Pills");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Exercise");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "EmotionalStates");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Consumings");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Appetite");
        }
    }
}
