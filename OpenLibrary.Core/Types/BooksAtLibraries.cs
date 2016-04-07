using System;
using System.Collections.Generic;

namespace OpenLibrary.Core.Types
{
    public class BooksAtLibraries
    {
        public Guid LibraryId { get; set; }

        public IList<Book> Books { get; set; }

    }
}