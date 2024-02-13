using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addforeignkeyforcategoryproductrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CategoryId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CategoryId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "Description" },
                values: new object[] { 8, "The Philodendron family is very broad, but the Philodendron birkin is perhaps the most remarkable of the bunch. This incredibly beautiful plant can be instantly recognised by the fine light-coloured stripes on her dark green leaves, which look as if they were added by the delicate hand of an artist. The new leaves, which appear from the top of the plant, are a lot lighter than the lower leaves and provide a beautiful contrasting range of tones that will compliment every home." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CategoryId",
                value: 9);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "Description",
                value: "The Philodendron family is very broad, but the Philodendron birkin is perhaps the most remarkable of the bunch. This incredibly beautiful plant can be instantly recognised by the fine light-coloured stripes on her dark green leaves, which look as if they were added by the delicate hand of an artist. The new leaves, which appear from the top of the plant, are a lot lighter than the lower leaves and provide a beautiful contrasting range of tones that will compliment every home.\r\n\r\n");
        }
    }
}
