using System;

namespace EntityFramework_Project.Models
{
    public class Product
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public DateTime CreationDate { get; set; }

        public bool IsDeleted { get; set; }


        public Product(string name, double unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
            CreationDate = DateTime.Now;
        }
    }


}
