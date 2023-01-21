using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //category seeding
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Motorbike", Url = "Motorbike", Icon = "aperture" },
                new Category { Id = 2, Name = "Car", Url = "Car", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Mobile Phones", Url = "MobilePhones", Icon = "calculator" }
            );

            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   CategoryId = 1,
                   Title = "Galaxy Motor",
                   Description = "Product description for Galaxy motor",
                   Image = "https://as2.ftcdn.net/v2/jpg/00/35/84/47/1000_F_35844770_jWEZJtyQRnXAQukBUajtHHi7Mbqka8gA.jpg",
                   Price = 199.99m,
                   OriginalPrice = 299.00m,
               },
               new Product
               {
                   Id = 2,
                   CategoryId = 1,
                   Title = "Hughes Motor",
                   Description = "Product description for Hughes motor",
                   Image = "https://as2.ftcdn.net/v2/jpg/00/51/35/11/1000_F_51351171_Lnj9ybNf54gOKPufkoriDllKRUnXPPZa.jpg",
                   Price = 1189.99m,
                   OriginalPrice = 1299.00m,
               },
               new Product
               {
                   Id = 3,
                   CategoryId = 1,
                   Title = "Monster Bike",
                   Description = "Product description for Monster Bike",
                   Image = "https://as1.ftcdn.net/v2/jpg/00/35/73/06/1000_F_35730661_DjhXUsDszI246K2KPGtJFkavyKJle1rh.jpg",
                   Price = 897.4m,
                   OriginalPrice = 1745.90m,
               },
               new Product
               {
                   Id = 4,
                   CategoryId = 2,
                   Title = "Ferrari Car",
                   Description = "Product description for Ferrari Car",
                   Image = "https://as1.ftcdn.net/v2/jpg/02/98/35/82/1000_F_298358259_bwYxOvtrqJn7m8dfeYkkoNkusBSYNhep.jpg",
                   Price = 8897.4m,
                   OriginalPrice = 10745.90m,
               },
               new Product
               {
                   Id = 5,
                   CategoryId = 2,
                   Title = "Blue Car",
                   Description = "Product description for Blue Car",
                   Image = "https://as1.ftcdn.net/v2/jpg/05/51/77/26/1000_F_551772658_rTDbBXopMnBewDliIr0VVG1dF5MSg1rL.jpg",
                   Price = 1025.40m,
                   OriginalPrice = 2045.90m,
               },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Germany Hardtop Convertible Car",
                    Description = "Product description for Germany Hardtop Convertible Car",
                    Image = "https://as2.ftcdn.net/v2/jpg/05/53/14/83/1000_F_553148363_BHiXjOmXVeJOjYCVoHXI8OnhhU6RbNuX.jpg",
                    Price = 91025.40m,
                    OriginalPrice = 102045.90m,
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "C-1 Smart Phone",
                    Description = "Product description for C-1 Smart Phone",
                    Image = "https://as1.ftcdn.net/v2/jpg/04/73/83/38/1000_F_473833898_dVUZcCQgVZbIUnimWruGsV15Hykpcx4q.jpg",
                    Price = 810.10m,
                    OriginalPrice = 1010.90m,
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Dw-Lock Series Smart Phone",
                    Description = "Product description for Dw-Lock Series Smart Phone",
                    Image = "https://as2.ftcdn.net/v2/jpg/03/57/86/87/1000_F_357868762_EOwrpU5hJId34HHuX7vDekqKwTfAIdqN.jpg",
                    Price = 1510.18m,
                    OriginalPrice = 1810.55m,
                }
            );
        }
    }
}
