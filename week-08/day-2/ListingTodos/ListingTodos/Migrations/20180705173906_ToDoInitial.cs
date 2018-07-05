using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ListingTodos.Migrations
{
    public partial class ToDoInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Assignes");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "ToDos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "ToDos");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Assignes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
