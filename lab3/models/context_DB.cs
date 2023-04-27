
using lab3.models.category;
using lab3.models.images;
using lab3.models.product;
using Microsoft.EntityFrameworkCore;

namespace lab3.models
{
    public class Context_DB : DbContext
    {

        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Images> images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new imagrsConfigration().Configure(modelBuilder.Entity<Images>());
            new ProductConfigration().Configure(modelBuilder.Entity<Product>());
            new catigoryConfigration().Configure(modelBuilder.Entity<Category>());

            modelBuilder.MapRelationship();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Data Source=DESKTOP-P73CSRJ\\SQLEXPRESS;Initial Catalog=lab3_MVC;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;");
        }
    }
}
