using System;

namespace NoLaTengo.Models {
    public interface IElement
    {
        public int Id { get; set; }
        public string ElementName { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool Finished { get; set; }
        public string Description { get; set; }
        public int CategoryId {get; set;}
        public Category ElementCategory {get; set;}
        
    }
}