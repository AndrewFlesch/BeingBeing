using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BeingBeing.Migrations
{
    public partial class ChangedSocial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Social");

            migrationBuilder.AddColumn<string>(
                name: "With",
                table: "Social",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Poop",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "With",
                table: "Social");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Poop");

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Social",
                nullable: false,
                defaultValue: 0);
        }
    }
}
