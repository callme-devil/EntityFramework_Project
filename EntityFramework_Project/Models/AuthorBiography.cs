using System;

namespace EntityFramework_Project.Models
{
    public class AuthorBiography
    {
        public int Id { get; set; }

        public string Biography { get; set; }

        public DateTime BirthDate  { get; set; }

        public string PlaceOfBirth { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}