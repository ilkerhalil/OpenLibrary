using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class PeopleConfiguration : EntityTypeConfiguration<People>
    {
        public PeopleConfiguration()
        {
            Property(people => people.PeopleId).HasColumnName("PeopleId").IsRequired().HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("AK_People_PeopleId") { IsUnique = true }));
            Property(people => people.FirstName).IsRequired().HasMaxLength(20);
            Property(people => people.LastName).IsRequired().HasMaxLength(20);
            Property(people => people.Gender).IsOptional();



            Property(people => people.AddedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(people => people.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(people => people.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(people => people.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}
