using Microsoft.EntityFrameworkCore;
using PlantShop.Models;

namespace PlantShop.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Alocasia", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Caladium", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Calathea", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Epipremnum", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Ficus", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Hoya", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Monstera", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Philodendron", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Succulents", DisplayOrder = 9 }

                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 010,
                    Title = "Alocasia Polly",
                    Size = "M",
                    Price = 24.99,
                    Description = "The Alocasia Polly, also known as the African Mask Plant is a very unique looking plant. She has gorgeous white veins on her glossy green leaves. Her leaves are heart-shaped and have frilled edges. She originates from the rainforest in Southeast Asia, where she can become enormous!",
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 020,
                    Title = "Caladium 'Red Flash'",
                    Size = "Tuber",
                    Price = 14.99,
                    Description = "The Caladium is a tropical plant originating from Central and Southern America, particularly Brazil and the Amazon, that grows in the jungle. Caladiums are beautiful plants that grow from bulbs. Their heart-shaped, often brightly colored and beautifully veined leaves make the Caladium a real eyecatcher! The leaves of the Red Flash have a green edge with pink speckles that shifts to a beautiful bright red towards the center!\r\n\r\nYou can grow the Caladium yourself with this tuber. It takes a little effort, but you will be rewarded with the magnificant leaves of the Red Flash. In the care text you can read the whole description on how to grow the tuber into a mature plant.",
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 030,
                    Title = "Calathea Medallion",
                    Size = "XL",
                    Price = 24.99,
                    Description = "The Calathea medallion has a memorable appearance with her bold patterned leaves and beautiful deep purple underside. During the day she lets her leaves stand open, but when night falls she closes them up and reveals the deep purple colour on their underside. If you are very quiet you can even hear the gentle rustling as she transforms! The Calathea medallion likes to take up plenty of space, but she doesn’t need a lot of light. As a domestic plant it does well in the darker areas of your living room, the hall or even the bathroom.",
                    CategoryId = 3,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 040,
                    Title = "Epipremnum Cebu Blue",
                    Size = "M",
                    Price = 16.95,
                    Description = "This Epipremnum is one the rarer side and she has an amazing silvery to blue hue over her. This is the Epipremnum Cebu Blue and she is loved for her stunning leaves. They are long and narrow, the young version has tiny fenestrations, but the mature version has huge fenestrations. This beauty comes without many strings attached, since she is rather easy to care for and also grows rapidly. You will have endless trailing vines in no time! Is this the one for you? Buy Epipremnum Cebu Blue online.",
                    CategoryId = 4,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 050,
                    Title = "Ficus Lyrata",
                    Size = "XXL",
                    Price = 114.95,
                    Description = "The Ficus Lyrata, also known as the fig-leaf plant or violet leaf plant, is a huge feast for the eyes and is really one of our favourites. The beautiful large, strong heart-shaped leaves grow proudly upwards and give her a dignified appearance. This giant beauty is extra special as she has multiple branches. This way she easily fills up the room, not only in height but also in width!",
                    CategoryId = 5,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 060,
                    Title = "Hoya Kerrii",
                    Size = "XS",
                    Price = 5.95,
                    Description = "Isn't this Hoya Kerrii (double leaf) super special? Two hearts in one! That is why this Hoya is also called the heart plant. This romantic cutie is a real cupid, so besides being lovely to own, this plant is also nice to give away to someone special. It is one of the few plants that always stays this small, but that does not make it any less fun! \r\n\r\n* Please note that this leaf-only cutting will not grow, as these cuttings lack a node from which new roots or leaves can emerge.",
                    CategoryId = 6,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 070,
                    Title = "Monstera Thai Constellation",
                    Size = "XS",
                    Price = 39.95,
                    Description = "Here is the most beloved and rare Thai Constellation. To make her even more desirable, this is the cute baby form! She earns her name on her variegation that looks like a constellation. In contrast to most variegated plants, the Thai’s variegation is stable, yay! This is because she was especially produced for this, which also means that you will not be able to find this cutie anywhere in nature. All with all, a very special plant that would love a spot inside your urban jungle!",
                    CategoryId = 7,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 080,
                    Title = "Philodendron Birkin",
                    Size = "M",
                    Price = 12.95,
                    Description = "The Philodendron family is very broad, but the Philodendron birkin is perhaps the most remarkable of the bunch. This incredibly beautiful plant can be instantly recognised by the fine light-coloured stripes on her dark green leaves, which look as if they were added by the delicate hand of an artist. The new leaves, which appear from the top of the plant, are a lot lighter than the lower leaves and provide a beautiful contrasting range of tones that will compliment every home.",
                    CategoryId = 8,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 090,
                    Title = "Garnet Lotus",
                    Size = "XS",
                    Price = 4.45,
                    Description = "The lotus under the succulents, the Crassula Garnet Lotus. Her leaves are shaped up like a flower and are coloured soft green with a soft lilac hue to her. A really pretty plant to own! And the cool thing with succulents is that one leaves can actually grow into a whole new baby succulent, which will keep you busy for days! Are you sold on this cute plant? Buy Crassula Garnet Lotus online.",
                    CategoryId = 9,
                    ImageUrl = ""
                }
    );
        }

    }
}
