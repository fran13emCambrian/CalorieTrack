using Microsoft.EntityFrameworkCore.Migrations;

namespace CalorieAppTrack.Data.Migrations
{
    public partial class adduseridpmkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInfoModel");

            migrationBuilder.CreateTable(
                name: "IdealWeightCalculatorModel",
                columns: table => new
                {
                    WeightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActualWeight = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    IdealWeight = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdealWeightCalculatorModel", x => x.WeightId);
                });

            migrationBuilder.CreateTable(
                name: "RecipesModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreparationTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipesModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodEntryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserModel_FoodEntryModel_FoodEntryId",
                        column: x => x.FoodEntryId,
                        principalTable: "FoodEntryModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserModel_FoodEntryId",
                table: "UserModel",
                column: "FoodEntryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdealWeightCalculatorModel");

            migrationBuilder.DropTable(
                name: "RecipesModel");

            migrationBuilder.DropTable(
                name: "UserModel");

            migrationBuilder.CreateTable(
                name: "UserInfoModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfoModel", x => x.Id);
                });
        }
    }
}
