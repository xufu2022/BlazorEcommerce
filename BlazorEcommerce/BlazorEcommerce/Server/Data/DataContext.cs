using Microsoft.EntityFrameworkCore;
using Product = BlazorEcommerce.Shared.Product;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CartItem>()
            //    .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            //modelBuilder.Entity<ProductVariant>()
            //    .HasKey(p => new { p.ProductId, p.ProductTypeId });

            //modelBuilder.Entity<OrderItem>()
            //    .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            //modelBuilder.Entity<ProductType>().HasData(
            //        new ProductType { Id = 1, Name = "Default" },
            //        new ProductType { Id = 2, Name = "Paperback" },
            //        new ProductType { Id = 3, Name = "E-Book" },
            //        new ProductType { Id = 4, Name = "Audiobook" },
            //        new ProductType { Id = 5, Name = "Stream" },
            //        new ProductType { Id = 6, Name = "Blu-ray" },
            //        new ProductType { Id = 7, Name = "VHS" },
            //        new ProductType { Id = 8, Name = "PC" },
            //        new ProductType { Id = 9, Name = "PlayStation" },
            //        new ProductType { Id = 10, Name = "Xbox" }
            //    );

            //modelBuilder.Entity<Category>().HasData(
            //    new Category
            //    {
            //        Id = 1,
            //        Name = "Books",
            //        Url = "books"
            //    },
            //    new Category
            //    {
            //        Id = 2,
            //        Name = "Movies",
            //        Url = "movies"
            //    },
            //    new Category
            //    {
            //        Id = 3,
            //        Name = "Video Games",
            //        Url = "video-games"
            //    }
            //    );

            modelBuilder.Entity<Product>().HasData(
        new Product
        {
            Id = 1,
            Title = "The Hitchhiker's Guide to the Galaxy",
            Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
            Price = 9.99m
        },
        new Product
        {
            Id = 2,
            Title = "Ready Player One",
            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
            Price = 7.99m
        },
        new Product
        {
            Id = 3,
            Title = "Nineteen Eighty-Four",
            Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
            Price = 6.99m
        }
                    );

            //modelBuilder.Entity<ProductVariant>().HasData(
            //    new ProductVariant
            //    {
            //        ProductId = 1,
            //        ProductTypeId = 2,
            //        Price = 9.99m,
            //        OriginalPrice = 19.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 1,
            //        ProductTypeId = 3,
            //        Price = 7.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 1,
            //        ProductTypeId = 4,
            //        Price = 19.99m,
            //        OriginalPrice = 29.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 2,
            //        ProductTypeId = 2,
            //        Price = 7.99m,
            //        OriginalPrice = 14.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 3,
            //        ProductTypeId = 2,
            //        Price = 6.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 4,
            //        ProductTypeId = 5,
            //        Price = 3.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 4,
            //        ProductTypeId = 6,
            //        Price = 9.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 4,
            //        ProductTypeId = 7,
            //        Price = 19.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 5,
            //        ProductTypeId = 5,
            //        Price = 3.99m,
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 6,
            //        ProductTypeId = 5,
            //        Price = 2.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 7,
            //        ProductTypeId = 8,
            //        Price = 19.99m,
            //        OriginalPrice = 29.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 7,
            //        ProductTypeId = 9,
            //        Price = 69.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 7,
            //        ProductTypeId = 10,
            //        Price = 49.99m,
            //        OriginalPrice = 59.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 8,
            //        ProductTypeId = 8,
            //        Price = 9.99m,
            //        OriginalPrice = 24.99m,
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 9,
            //        ProductTypeId = 8,
            //        Price = 14.99m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 10,
            //        ProductTypeId = 1,
            //        Price = 159.99m,
            //        OriginalPrice = 299m
            //    },
            //    new ProductVariant
            //    {
            //        ProductId = 11,
            //        ProductTypeId = 1,
            //        Price = 79.99m,
            //        OriginalPrice = 399m
            //    }
            //);
        }

        public DbSet<Product> Products { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<ProductType> ProductTypes { get; set; }
        //public DbSet<ProductVariant> ProductVariants { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<CartItem> CartItems { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<Address> Addresses { get; set; }
        //public DbSet<Image> Images { get; set; }
    }
}
