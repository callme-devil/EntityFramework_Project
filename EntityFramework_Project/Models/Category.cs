using System.Collections.Generic;

namespace EntityFramework_Project.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<BookCategory> BookCategories { get; set; }
    }
}