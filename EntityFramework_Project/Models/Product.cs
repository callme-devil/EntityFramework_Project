using System;

namespace EntityFramework_Project.Models
{
    public class Product
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public double UnitPrice { get; set; }

        public DateTime CreationDate { get; set; }


        public Product(string name, double unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
            CreationDate = DateTime.Now;
        }
    }


}
