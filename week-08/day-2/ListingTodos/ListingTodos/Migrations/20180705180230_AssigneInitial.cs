using Microsoft.EntityFrameworkCore.Migrations;

namespace ListingTodos.Migrations
{
    public partial class AssigneInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Assignes_assigneId",
                table: "ToDos");

            migrationBuilder.RenameColumn(
                name: "assigneId",
                table: "ToDos",
                newName: "AssigneId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDos_assigneId",
                table: "ToDos",
                newName: "IX_ToDos_AssigneId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Assignes_AssigneId",
                table: "ToDos",
                column: "AssigneId",
                principalTable: "Assignes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Assignes_AssigneId",
                table: "ToDos");

            migrationBuilder.RenameColumn(
                name: "AssigneId",
                table: "ToDos",
                newName: "assigneId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDos_AssigneId",
                table: "ToDos",
                newName: "IX_ToDos_assigneId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Assignes_assigneId",
                table: "ToDos",
                column: "assigneId",
                principalTable: "Assignes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
