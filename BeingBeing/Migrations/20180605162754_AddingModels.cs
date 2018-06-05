using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BeingBeing.Migrations
{
    public partial class AddingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "States");

            migrationBuilder.DropColumn(
                name: "Weather",
                table: "States");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Doings");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Doings");

            migrationBuilder.RenameColumn(
                name: "Weather",
                table: "Doings",
                newName: "Intensity");

            migrationBuilder.RenameColumn(
                name: "Temperature",
                table: "Doings",
                newName: "Duration");

            migrationBuilder.CreateTable(
                name: "Consumings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Beans = table.Column<int>(nullable: false),
                    Beer = table.Column<int>(nullable: false),
                    Break = table.Column<int>(nullable: false),
                    Butter = table.Column<int>(nullable: false),
                    Cheese = table.Column<int>(nullable: false),
                    Coffee = table.Column<int>(nullable: false),
                    DateState = table.Column<DateTime>(nullable: false),
                    DietSoda = table.Column<int>(nullable: false),
                    Eggs = table.Column<int>(nullable: false),
                    Fish = table.Column<int>(nullable: false),
                    Fruit = table.Column<int>(nullable: false),
                    Juice = table.Column<int>(nullable: false),
                    Liquor = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Meat = table.Column<int>(nullable: false),
                    MyProperty = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    Nuts = table.Column<int>(nullable: false),
                    Oils = table.Column<int>(nullable: false),
                    Pasta = table.Column<int>(nullable: false),
                    Potatoes = table.Column<int>(nullable: false),
                    Rice = table.Column<int>(nullable: false),
                    Soda = table.Column<int>(nullable: false),
                    Sweats = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Vegetable = table.Column<int>(nullable: false),
                    Water = table.Column<int>(nullable: false),
                    Wine = table.Column<int>(nullable: false),
                    Yogurt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EmotionalStates",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateState = table.Column<DateTime>(nullable: false),
                    EmotionalState = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmotionalStates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Poop",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<string>(nullable: true),
                    Density = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poop", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sleep",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Duration = table.Column<int>(nullable: false),
                    Quality = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sleep", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consumings");

            migrationBuilder.DropTable(
                name: "EmotionalStates");

            migrationBuilder.DropTable(
                name: "Poop");

            migrationBuilder.DropTable(
                name: "Sleep");

            migrationBuilder.RenameColumn(
                name: "Intensity",
                table: "Doings",
                newName: "Weather");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Doings",
                newName: "Temperature");

            migrationBuilder.AddColumn<string>(
                name: "Temperature",
                table: "States",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weather",
                table: "States",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Doings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Doings",
                nullable: true);
        }
    }
}
