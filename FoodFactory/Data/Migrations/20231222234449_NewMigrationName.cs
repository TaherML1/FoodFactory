using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodFactory.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Foods",
                table: "Foods");

            migrationBuilder.RenameTable(
                name: "Foods",
                newName: "MyFoods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyFoods",
                table: "MyFoods",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyFoods",
                table: "MyFoods");

            migrationBuilder.RenameTable(
                name: "MyFoods",
                newName: "Foods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Foods",
                table: "Foods",
                column: "Id");
        }
    }
}
