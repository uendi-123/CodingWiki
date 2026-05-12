using CodingWiki_Model.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingWiki_Model.ViewModels
{
    public class BookAuthorVM
    {
        public BookAuthorMap BookAuthor { get; set; }
        public Book Book { get; set; }
        public IEnumerable<BookAuthorMap> BookAuthorList { get; set; }
        public IEnumerable<SelectListItem> AuthorList { get; set; }
    }
}
