using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class EmailAddressConfiguration : EntityTypeConfiguration<EMailAddress>
    {
        public EmailAddressConfiguration()
        {
            Property(email => email.EMailAddressId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).HasColumnName("EmailAddressId").IsRequired().HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("AK_EmailAddress_EmailAddressId") { IsUnique = true }));
            Property(email => email.EMail).IsRequired().HasMaxLength(50);

            Property(email => email.AddedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(email => email.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(email => email.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(email => email.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}