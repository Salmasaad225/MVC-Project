using lab3.models.images;
using lab3.models.product;
using Microsoft.EntityFrameworkCore;

namespace lab3.models
{
    public static class RELATIONS
    {


        public static void MapRelationship(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasOne(a => a.category).
                WithMany(a => a.Products).
                HasForeignKey(i => i.Catigory_ID).
                IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Images>().HasOne(a => a.Product).
                WithMany(a => a.Images).HasForeignKey(a => a.Product_ID).
                IsRequired().OnDelete(DeleteBehavior.NoAction);
        }

    }
}
