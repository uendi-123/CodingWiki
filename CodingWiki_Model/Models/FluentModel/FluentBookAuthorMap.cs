using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodingWiki_Model.Models
{
    public class FluentBookAuthorMap
    {
        //[ForeignKey("Book")]
        public int Book_Id { get; set; }
        //[ForeignKey("Author")]
        public int Author_Id { get; set; }
        public FluentBook Book { get; set; }
        public FluentAuthor Author { get; set; }

    }
}
