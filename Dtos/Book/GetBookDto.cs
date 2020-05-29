using System;
using NoLaTengo.Models;

namespace NoLaTengo.Dtos
{
    public class GetBookDto
    {
        public int Id { get; set; }
        public string ElementName { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool Finished { get; set; }
        public string Description { get; set; }

        public int PagesNumber { get; set; }
        public string Publisher { get; set; }

        public string Author { get; set; }

        public int CategoryId { get; set; }
        public GetCategoryDto ElementCategory { get; set; }
    }
}