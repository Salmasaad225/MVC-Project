using lab3.models.category;
using lab3.models.product;
using System.ComponentModel.DataAnnotations;

namespace lab3.models.images
{
    public class Images
    {
        public long ID { get; set; }
        
        public string Name { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public long Product_ID { get; set; }

        public Product Product { get; set; }
       

        public Images(string name, float length, float width, float height, Product product)
        {
            Name = name;
            Length = length;
            Width = width;
            Height = height;
            Product = product;
            

        }

        private Images()
        { }
    }
}
