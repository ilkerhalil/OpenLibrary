using System;
using System.Collections.Generic;

namespace OpenLibrary.Core.Types
{
    public class BooksByAuthor
    {
        public Guid AuthorId { get; set; }

        public IList<Book> Books { get; set; }

    }
}