using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyApp.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Students",
                nullable: false,
                defaultValue: "");
        }
    }
}
