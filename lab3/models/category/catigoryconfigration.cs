
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace lab3.models.category
{
    public class catigoryConfigration : IEntityTypeConfiguration<Category>
    {


       

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Catigory");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(i => i.Name).IsRequired();
        }
    }
}
