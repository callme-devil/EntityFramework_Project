using System;
using System.Collections.Generic;

namespace EntityFramework_Project.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleasedDate { get; set; }

        public List<BookCategory> BookCategories { get; set; }
    }
}
