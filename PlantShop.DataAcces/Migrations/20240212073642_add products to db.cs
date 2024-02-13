using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlantShop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addproductstodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "Size", "Title" },
                values: new object[,]
                {
                    { 10, "The Alocasia Polly, also known as the African Mask Plant is a very unique looking plant. She has gorgeous white veins on her glossy green leaves. Her leaves are heart-shaped and have frilled edges. She originates from the rainforest in Southeast Asia, where she can become enormous!", 24.989999999999998, "M", "Alocasia Polly" },
                    { 20, "The Caladium is a tropical plant originating from Central and Southern America, particularly Brazil and the Amazon, that grows in the jungle. Caladiums are beautiful plants that grow from bulbs. Their heart-shaped, often brightly colored and beautifully veined leaves make the Caladium a real eyecatcher! The leaves of the Red Flash have a green edge with pink speckles that shifts to a beautiful bright red towards the center!\r\n\r\nYou can grow the Caladium yourself with this tuber. It takes a little effort, but you will be rewarded with the magnificant leaves of the Red Flash. In the care text you can read the whole description on how to grow the tuber into a mature plant.", 14.99, "Tuber", "Caladium 'Red Flash'" },
                    { 30, "The Calathea medallion has a memorable appearance with her bold patterned leaves and beautiful deep purple underside. During the day she lets her leaves stand open, but when night falls she closes them up and reveals the deep purple colour on their underside. If you are very quiet you can even hear the gentle rustling as she transforms! The Calathea medallion likes to take up plenty of space, but she doesn’t need a lot of light. As a domestic plant it does well in the darker areas of your living room, the hall or even the bathroom.", 24.989999999999998, "XL", "Calathea Medallion" },
                    { 40, "This Epipremnum is one the rarer side and she has an amazing silvery to blue hue over her. This is the Epipremnum Cebu Blue and she is loved for her stunning leaves. They are long and narrow, the young version has tiny fenestrations, but the mature version has huge fenestrations. This beauty comes without many strings attached, since she is rather easy to care for and also grows rapidly. You will have endless trailing vines in no time! Is this the one for you? Buy Epipremnum Cebu Blue online.", 16.949999999999999, "M", "Epipremnum Cebu Blue" },
                    { 50, "The Ficus Lyrata, also known as the fig-leaf plant or violet leaf plant, is a huge feast for the eyes and is really one of our favourites. The beautiful large, strong heart-shaped leaves grow proudly upwards and give her a dignified appearance. This giant beauty is extra special as she has multiple branches. This way she easily fills up the room, not only in height but also in width!", 114.95, "XXL", "Ficus Lyrata" },
                    { 60, "Isn't this Hoya Kerrii (double leaf) super special? Two hearts in one! That is why this Hoya is also called the heart plant. This romantic cutie is a real cupid, so besides being lovely to own, this plant is also nice to give away to someone special. It is one of the few plants that always stays this small, but that does not make it any less fun! \r\n\r\n* Please note that this leaf-only cutting will not grow, as these cuttings lack a node from which new roots or leaves can emerge.", 5.9500000000000002, "XS", "Hoya Kerrii" },
                    { 70, "Here is the most beloved and rare Thai Constellation. To make her even more desirable, this is the cute baby form! She earns her name on her variegation that looks like a constellation. In contrast to most variegated plants, the Thai’s variegation is stable, yay! This is because she was especially produced for this, which also means that you will not be able to find this cutie anywhere in nature. All with all, a very special plant that would love a spot inside your urban jungle!", 39.950000000000003, "XS", "Monstera Thai Constellation" },
                    { 80, "The Philodendron family is very broad, but the Philodendron birkin is perhaps the most remarkable of the bunch. This incredibly beautiful plant can be instantly recognised by the fine light-coloured stripes on her dark green leaves, which look as if they were added by the delicate hand of an artist. The new leaves, which appear from the top of the plant, are a lot lighter than the lower leaves and provide a beautiful contrasting range of tones that will compliment every home.\r\n\r\n", 12.949999999999999, "M", "Philodendron Birkin" },
                    { 90, "The lotus under the succulents, the Crassula Garnet Lotus. Her leaves are shaped up like a flower and are coloured soft green with a soft lilac hue to her. A really pretty plant to own! And the cool thing with succulents is that one leaves can actually grow into a whole new baby succulent, which will keep you busy for days! Are you sold on this cute plant? Buy Crassula Garnet Lotus online.", 4.4500000000000002, "XS", "Garnet Lotus" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
