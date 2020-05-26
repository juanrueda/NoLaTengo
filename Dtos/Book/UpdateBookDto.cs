using System;
using NoLaTengo.Models;

namespace NoLaTengo.Dtos {
    public class UpdateBookDto {
        public int Id { get; set; }
        public string ElementName { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool Finished { get; set; }
        public string Description { get; set; }

        public int PagesNumber { get; set; }
        public string Publisher { get; set; }
        public Category ElementCategory { get; set; }
    }
}