using Microsoft.EntityFrameworkCore.Migrations;

namespace CalorieAppTrack.Data.Migrations
{
    public partial class Updatpk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserModel_FoodEntryModel_FoodEntryId",
                table: "UserModel");

            migrationBuilder.DropIndex(
                name: "IX_UserModel_FoodEntryId",
                table: "UserModel");

            migrationBuilder.DropColumn(
                name: "FoodEntryId",
                table: "UserModel");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FoodEntryModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodEntryModel_UserId",
                table: "FoodEntryModel",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserId",
                table: "FoodEntryModel",
                column: "UserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserId",
                table: "FoodEntryModel");

            migrationBuilder.DropIndex(
                name: "IX_FoodEntryModel_UserId",
                table: "FoodEntryModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FoodEntryModel");

            migrationBuilder.AddColumn<int>(
                name: "FoodEntryId",
                table: "UserModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserModel_FoodEntryId",
                table: "UserModel",
                column: "FoodEntryId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserModel_FoodEntryModel_FoodEntryId",
                table: "UserModel",
                column: "FoodEntryId",
                principalTable: "FoodEntryModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
