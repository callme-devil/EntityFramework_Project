using System.Collections.Generic;

namespace EntityFramework_Project.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public ProductCategory(string name)
        {
            //? For exception ?
            //Products = new List<Product>();
            
            Name = name;
            
        }
    }
}
