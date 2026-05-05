using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodingWiki_Model.Models
{
    public class FluentBook
    {
        //[Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public string PriceRange { get; set; }
        public FluentBookDetail BookDetail { get; set; }
        public int Publisher_ID { get; set; }
        public FluentPublisher Publisher { get; set; }
        //public List<FluentAuthor> Authors { get; set; }

        public List<FluentBookAuthorMap> BookAuthorMap { get; set; }
    }
}
