using Microsoft.EntityFrameworkCore.Migrations;

namespace CalorieAppTrack.Data.Migrations
{
    public partial class addpmtofoodentrymodel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserId",
                table: "FoodEntryModel");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "FoodEntryModel",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserId",
                table: "FoodEntryModel",
                column: "UserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserId",
                table: "FoodEntryModel");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "FoodEntryModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodEntryModel_UserModel_UserId",
                table: "FoodEntryModel",
                column: "UserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
