using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Core.Types;

namespace OpenLibrary.EntityFramework
{
    public class BookConfiguration: EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {

        }
    }
}
