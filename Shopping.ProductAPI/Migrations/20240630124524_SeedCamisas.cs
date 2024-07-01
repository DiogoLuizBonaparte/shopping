using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedCamisas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 3L, "Camisa algodão", "Camisa Marte Preta", "https://github.com/DiogoLuizBonaparte/shopping/blob/master/ShoppingImages/11_mars.jpg", "Camisa Marte", 79.9m },
                    { 4L, "Camisa", "Camisa Dragonball Z, Goku", "https://github.com/DiogoLuizBonaparte/shopping/blob/master/ShoppingImages/13_dragon_ball.jpg", "Camisa Dragon Ball Z", 99.9m },
                    { 5L, "Camisa", "Camisa No Internet preta", "https://github.com/DiogoLuizBonaparte/shopping/blob/master/ShoppingImages/2_no_internet.jpg", "Camisa No Internet", 19m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);
        }
    }
}
