using System;

namespace NoLaTengo.Models
{
    public class Movie : IElement
    {
        public int Id { get; set; }
        public string ElementName { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool Finished { get; set; }
        public string Description { get; set; }

        public string Director { get; set; }
        public int Runtime { get; set; }
        public Category ElementCategory { get; set; }
    }
}