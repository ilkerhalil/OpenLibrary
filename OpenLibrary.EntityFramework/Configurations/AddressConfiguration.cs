using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            Property(address => address.AddressId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(address => address.CityCode).IsRequired();
            Property(address => address.CountryCode).IsRequired();
            Property(address => address.FullAddress).IsRequired().HasMaxLength(1024);

            Property(address => address.AddedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(address => address.AddedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(address => address.ModifiedDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(address => address.ModifiedUser).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);


        }
    }
}