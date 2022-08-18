using Microsoft.EntityFrameworkCore.Migrations;

namespace CalorieAppTrack.Data.Migrations
{
    public partial class adddropdowntofoodentry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "UserModelUserId",
                table: "FoodEntryModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodEntryModel_UserModelUserId",
                table: "FoodEntryModel",
                column: "UserModelUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserModelUserId",
                table: "FoodEntryModel",
                column: "UserModelUserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserModelUserId",
                table: "FoodEntryModel");

            migrationBuilder.DropIndex(
                name: "IX_FoodEntryModel_UserModelUserId",
                table: "FoodEntryModel");

            migrationBuilder.DropColumn(
                name: "UserModelUserId",
                table: "FoodEntryModel");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "FoodEntryModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
