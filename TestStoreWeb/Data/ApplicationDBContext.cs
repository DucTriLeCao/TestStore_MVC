using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestStoreWeb.Models;

namespace TestStoreWeb.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Sữa", DisplayOrder = 1 },
                new Category { CategoryId = 2, CategoryName = "Tả", DisplayOrder = 2 },
                new Category { CategoryId = 3, CategoryName = "Đồ chơi", DisplayOrder = 3 },
                new Category { CategoryId = 4, CategoryName = "Quần áo", DisplayOrder = 4 },
                new Category { CategoryId = 5, CategoryName = "Thực Phẩm chức năng", DisplayOrder = 5 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Sữa bột 850g Varma",
                    ProductDescription = "Sữa bột cho bé trên 2 tuổi",
                    Brand = "Nutifood",
                    ListPrice = 520,
                    Price = 500,
                    Price10 = 495,
                    Price20 = 485,
                    Quantity = 550,
                    CategoryId = 1,
                    ImageUrl = "",
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Tã quần Huggies size M 74 miếng",
                    ProductDescription = "Tã quần cao cấp, thoáng mát",
                    Brand = "Huggies",
                    ListPrice = 450,
                    Price = 430,
                    Price10 = 420,
                    Price20 = 410,
                    Quantity = 200,
                    CategoryId = 2,
                    ImageUrl = "",
                },
               new Product
               {
                   ProductId = 3,
                   ProductName = "Đồ chơi lắp ráp Lego Classic 900 mảnh",
                   ProductDescription = "Bộ đồ chơi lắp ráp phát triển trí tuệ cho bé",
                   Brand = "Lego",
                   ListPrice = 1200,
                   Price = 1150,
                   Price10 = 1130,
                   Price20 = 1100,
                   Quantity = 150,
                   CategoryId = 3,
                   ImageUrl = "",
               },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Áo thun cotton GAP bé trai size M",
                    ProductDescription = "Áo thun cotton mềm mại, thoáng mát",
                    Brand = "Gap",
                    ListPrice = 250,
                    Price = 240,
                    Price10 = 235,
                    Price20 = 230,
                    Quantity = 350,
                    CategoryId = 4,
                    ImageUrl = "",

                },
               new Product
               {
                   ProductId = 5,
                   ProductName = "Vitamin tổng hợp Pediakid cho trẻ em",
                   ProductDescription = "Vitamin tổng hợp giúp tăng cường sức khỏe cho trẻ",
                   Brand = "Pediakid",
                   ListPrice = 300,
                   Price = 280,
                   Price10 = 270,
                   Price20 = 260,
                   Quantity = 500,
                   CategoryId = 5,
                   ImageUrl = "",
               }

               );
        }
    }
}
