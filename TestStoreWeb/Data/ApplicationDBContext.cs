using Microsoft.EntityFrameworkCore;
using TestStoreWeb.Models;

namespace TestStoreWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Sữa", DisplayOrder = 1 },
                new Category { CategoryId = 2, CategoryName = "Tả", DisplayOrder = 2 },
                new Category { CategoryId = 3, CategoryName = "Đồ chơi", DisplayOrder = 3 },
                new Category { CategoryId = 4, CategoryName = "Quần áo", DisplayOrder = 4 }
                );
        }
    }
}
