namespace OpenLibrary.Model.Types
{
    public class BooksAtLibraries
    {
        public virtual Book Book { get; set; }

        public virtual Library Library { get; set; }

    }
}