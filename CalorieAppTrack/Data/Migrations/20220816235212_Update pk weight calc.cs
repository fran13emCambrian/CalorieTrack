using Microsoft.EntityFrameworkCore.Migrations;

namespace CalorieAppTrack.Data.Migrations
{
    public partial class Updatepkweightcalc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_IdealWeightCalculatorModel_UserId",
                table: "IdealWeightCalculatorModel",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IdealWeightCalculatorModel_UserModel_UserId",
                table: "IdealWeightCalculatorModel",
                column: "UserId",
                principalTable: "UserModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdealWeightCalculatorModel_UserModel_UserId",
                table: "IdealWeightCalculatorModel");

            migrationBuilder.DropIndex(
                name: "IX_IdealWeightCalculatorModel_UserId",
                table: "IdealWeightCalculatorModel");
        }
    }
}
