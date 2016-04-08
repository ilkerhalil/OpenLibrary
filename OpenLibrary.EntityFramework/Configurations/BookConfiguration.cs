using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {

            HasKey(book => book.Isbn);
            Property(book => book.Isbn).IsRequired().HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("AK_Book_Isbn") { IsUnique = true }));
            Property(book => book.Title).IsRequired().HasMaxLength(1024);
            Property(book => book.PublicationDate).IsOptional();

            Property(book => book.AddedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(book => book.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(book => book.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(book => book.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}