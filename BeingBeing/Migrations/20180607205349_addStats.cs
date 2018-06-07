using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BeingBeing.Migrations
{
    public partial class addStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quality",
                table: "Sleep",
                newName: "Notes");

            migrationBuilder.AddColumn<DateTime>(
                name: "WentDown",
                table: "Sleep",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "WokeUp",
                table: "Sleep",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WentDown",
                table: "Sleep");

            migrationBuilder.DropColumn(
                name: "WokeUp",
                table: "Sleep");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "Sleep",
                newName: "Quality");
        }
    }
}
