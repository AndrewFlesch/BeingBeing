using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BeingBeing.Migrations
{
    public partial class typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "What",
                table: "Working",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "What",
                table: "Social",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Illness",
                table: "Sickness",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Doing",
                table: "Exercise",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "EmotionalState",
                table: "EmotionalStates",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Break",
                table: "Consumings",
                newName: "Bread");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Appetite",
                newName: "Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Working",
                newName: "What");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Social",
                newName: "What");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Sickness",
                newName: "Illness");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Exercise",
                newName: "Doing");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "EmotionalStates",
                newName: "EmotionalState");

            migrationBuilder.RenameColumn(
                name: "Bread",
                table: "Consumings",
                newName: "Break");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Appetite",
                newName: "State");
        }
    }
}
