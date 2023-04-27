using lab3.models.category;
using lab3.models.images;
namespace lab3.models.product
{
    public class Product
    {
        public long ID { get; set; }

      
        public string? Name { get; set; }

       
        public string? Discription { get; set; }

        public float Price { get; set; }

        
        public byte? Discound_persentage { get; set; }

        public int? Available { get; set; }

        public int Catigory_ID { get; set; }

        public Category? category { get; set; }


        //private IList<Category> categories;
        //public IEnumerable<Category> Categories
        //{
        //    get
        //    {
        //        return categories;
        //    }
        //}



        private IList<Images> images;
        public string? Description;
        

        public IEnumerable<Images> Images
        {
            get
            {
                return images;

            }
        }





        public Product()
        { }


        public Product(string name, float price, int available, Category catigory, byte? discound_persentage = null, string? discription = null)
        {
            Name = name;
            Price = price;
            Available = available;
            Discound_persentage = discound_persentage;
            Discription = discription;
            category = catigory;


            images = new List<Images>();


        }

        public Product(string name, float price, int available , int catigory_ID)
        {


            Catigory_ID = catigory_ID;
            Available = available;
            Name = name;
            Price = price;
        }

        //public bool addcategory(Category itemcategory)
        //{
        //    var c_category = categories.FirstOrDefault(a => a.Name == itemcategory.Name);
        //    if (c_category == null)
        //    {

        //        categories.Add(itemcategory);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool addimage(Images image)
        {
            var i_image = images.FirstOrDefault(a => a.Name == image.Name);
            if (i_image == null)
            {

                images.Add(image);
                return true;
            }
            else
            {
                return false;
            }
        }





        
    }
}
