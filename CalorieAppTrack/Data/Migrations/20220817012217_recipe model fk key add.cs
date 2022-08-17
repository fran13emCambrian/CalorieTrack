using Microsoft.EntityFrameworkCore.Migrations;

namespace CalorieAppTrack.Data.Migrations
{
    public partial class recipemodelfkkeyadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "RecipesModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecipesModel_UserId",
                table: "RecipesModel",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipesModel_UserModel_UserId",
                table: "RecipesModel",
                column: "UserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipesModel_UserModel_UserId",
                table: "RecipesModel");

            migrationBuilder.DropIndex(
                name: "IX_RecipesModel_UserId",
                table: "RecipesModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RecipesModel");
        }
    }
}
