
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace lab3.models.images
{
    public class imagrsConfigration : IEntityTypeConfiguration<Images>
    {


        

        public void Configure(EntityTypeBuilder<Images> builder)
        {

            builder.ToTable("images");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.ID).ValueGeneratedOnAdd();
        }
    }
}
