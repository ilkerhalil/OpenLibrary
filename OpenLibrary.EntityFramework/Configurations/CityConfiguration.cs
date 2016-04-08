using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            HasKey(city => city.CityCode);
            Property(city => city.CityCode).IsRequired().HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("AK_City_CityCode") { IsUnique = true }));
            Property(city => city.CityName).IsRequired().HasMaxLength(256);
            Property(city => city.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(city => city.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(city => city.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}