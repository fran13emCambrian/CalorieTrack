using Microsoft.EntityFrameworkCore.Migrations;

namespace CalorieAppTrack.Data.Migrations
{
    public partial class Updatepkcaloriecalc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CalorieCalculatorModel",
                type: "int",
                nullable: false,
                defaultValue: 0
                );

            migrationBuilder.CreateIndex(
                name: "IX_CalorieCalculatorModel_UserId",
                table: "CalorieCalculatorModel",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CalorieCalculatorModel_UserModel_UserId",
                table: "CalorieCalculatorModel",
                column: "UserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalorieCalculatorModel_UserModel_UserId",
                table: "CalorieCalculatorModel");

            migrationBuilder.DropIndex(
                name: "IX_CalorieCalculatorModel_UserId",
                table: "CalorieCalculatorModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CalorieCalculatorModel");
        }
    }
}
