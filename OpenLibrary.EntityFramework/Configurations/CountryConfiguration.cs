using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            HasKey(country => country.CountryCode);
            Property(country => country.CountryCode).IsRequired().HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("AK_Country_CountryCode") { IsUnique = true }));
            Property(country => country.CountryName).IsRequired().HasMaxLength(256);

            Property(country => country.AddedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(country => country.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(country => country.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(country => country.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}