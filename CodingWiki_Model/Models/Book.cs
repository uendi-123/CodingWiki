using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodingWiki_Model.Models
{
    public class Book
    {
        //[Key]
        public int BookID { get; set; }
        public string Title { get; set; }
        [MaxLength(50)]
        [Required]
        public string ISBN { get; set; }
        
        public decimal Price { get; set; }
        [NotMapped]
        public string PriceRange { get; set; }
        
    }
}
