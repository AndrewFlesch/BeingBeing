using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BeingBeing.Migrations
{
    public partial class ChangedStatesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "States");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "States",
                newName: "Location");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "States",
                newName: "Longitude");

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "States",
                nullable: true);
        }
    }
}
