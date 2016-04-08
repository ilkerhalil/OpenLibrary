using System;
using System.Collections.Generic;

namespace OpenLibrary.Model.Types
{
    public class Category :BaseEntity
    {

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}