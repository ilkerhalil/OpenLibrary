using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class PhoneConfiguration : EntityTypeConfiguration<Phone>
    {
        public PhoneConfiguration()
        {
            Property(phone => phone.PhoneId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired().HasColumnName("PhoneId").HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("AK_Phone_PhoneId") { IsUnique = true }));
            Property(phone => phone.Number).IsRequired().HasMaxLength(10);
            Property(phone => phone.AreaCode).IsRequired().HasMaxLength(5);
            Property(phone => phone.PhoneType).IsOptional();
            Property(phone => phone.IsDefaultContactNumber).IsOptional();
            Property(phone => phone.Description).IsOptional().HasMaxLength(1024);

            Property(phone => phone.AddedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(phone => phone.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(phone => phone.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(phone => phone.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

        }
    }
}