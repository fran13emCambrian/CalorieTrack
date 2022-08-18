using Microsoft.EntityFrameworkCore.Migrations;

namespace CalorieAppTrack.Data.Migrations
{
    public partial class updateccrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalorieCalculatorModel_UserModel_UserId",
                table: "CalorieCalculatorModel");


            migrationBuilder.DropIndex(
                name: "IX_CalorieCalculatorModel_UserId",
                table: "CalorieCalculatorModel");


            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CalorieCalculatorModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CalorieCalculatorModel_UserId",
                table: "CalorieCalculatorModel",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CalorieCalculatorModel_UserModel_UserId",
                table: "CalorieCalculatorModel",
                column: "UserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalorieCalculatorModel_UserModel_UserId",
                table: "CalorieCalculatorModel");


            migrationBuilder.DropIndex(
                name: "IX_CalorieCalculatorModel_UserId",
                table: "CalorieCalculatorModel");


            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CalorieCalculatorModel",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
