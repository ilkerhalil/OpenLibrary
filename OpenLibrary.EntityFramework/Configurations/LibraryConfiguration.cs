using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class LibraryConfiguration : EntityTypeConfiguration<Library>
    {
        public LibraryConfiguration()
        {
            Property(library => library.LibraryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("LibraryId").IsRequired().HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("AK_Library_LibraryId") { IsUnique = true }));
            Property(library => library.Description).IsRequired().HasMaxLength(1024);

            Property(library => library.AddedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(library => library.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(library => library.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(library => library.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

        }
    }
}