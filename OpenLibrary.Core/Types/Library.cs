using System.Collections.Generic;

namespace OpenLibrary.Model.Types
{
    public class Library :BaseEntity
    {
        public int LibraryId { get; set; }

        public ICollection<People> Officers { get; set; }

        public ICollection<Book> Books { get; set; }

        public string Description { get; set; }

    }
}