using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityFramework_Project.Models
{
    //[Table("MyProducts" ,Schema ="PRD(Custom)")]//PRD.MyProducts
    public class Product
    {
        //[Key]
        public long Id { get; set; }
        //[Required]
        //[MaxLength(250)]
        //[MinLength(2)]
        public string Name { get; set; }

        public double UnitPrice { get; set; }

        //[Column("CreatedDate")]
        public DateTime CreationDate { get; set; }

        public bool IsDeleted { get; set; }

        public int CategoryId { get; set; }

        public ProductCategory Category { get; set; }


        public Product(string name, double unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
            CreationDate = DateTime.Now;
        }
    }


}
