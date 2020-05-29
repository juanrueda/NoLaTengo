using System;
using NoLaTengo.Models;

namespace NoLaTengo.Dtos {
    public class AddBookDto {
        public string ElementName { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool Finished { get; set; }
        public string Description { get; set; }

        public int PagesNumber { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int CategoryId { get; set; }
    }
}