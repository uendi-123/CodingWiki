using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodingWiki_Model.Models
{
    public class FluentBookDetail
    {
        public int BookDetail_Id { get; set; }
        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; }
        public string Weight { get; set; }

        public int Book_ID { get; set; }

        public FluentBook Book { get; set; }
    }
}
