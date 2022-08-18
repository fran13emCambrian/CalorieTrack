using Microsoft.EntityFrameworkCore.Migrations;

namespace CalorieAppTrack.Data.Migrations
{
    public partial class adddropdowntofoodentry1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserModelUserId",
                table: "FoodEntryModel");

            migrationBuilder.RenameColumn(
                name: "UserModelUserId",
                table: "FoodEntryModel",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodEntryModel_UserModelUserId",
                table: "FoodEntryModel",
                newName: "IX_FoodEntryModel_UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserId1",
                table: "FoodEntryModel",
                column: "UserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserId1",
                table: "FoodEntryModel");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "FoodEntryModel",
                newName: "UserModelUserId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodEntryModel_UserId1",
                table: "FoodEntryModel",
                newName: "IX_FoodEntryModel_UserModelUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserModelUserId",
                table: "FoodEntryModel",
                column: "UserModelUserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
