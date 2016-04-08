using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class NoteConfiguration : EntityTypeConfiguration<Note>
    {
        public NoteConfiguration()
        {
            Property(note => note.NoteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("NoteId").IsRequired().HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("AK_Note_NoteId") { IsUnique = true }));
            Property(note => note.Description).IsRequired().HasMaxLength(1024);


            Property(note => note.AddedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(note => note.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(note => note.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(note => note.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}