using System.Collections.Generic;

namespace NoLaTengo.Models
{
    public class Category {
        public int Id { get; set; }
        public string CategoryName  { get; set; }

        public List<Book> Books {get; set;}
        public List<Movie> Movies {get; set;}
    }
}