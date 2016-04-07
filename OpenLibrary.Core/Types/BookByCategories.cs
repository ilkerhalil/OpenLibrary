using System;
using System.Collections.Generic;

namespace OpenLibrary.Core.Types
{
    public class BookByCategories
    {
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public IList<Book> Books { get; set; }

    }
}