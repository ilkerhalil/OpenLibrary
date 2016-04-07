using System.Data.Entity.ModelConfiguration;
using System.Security.Permissions;
using OpenLibrary.Core.Types;

namespace OpenLibrary.EntityFramework
{
    public class PersonAddressConfiguration : EntityTypeConfiguration<PersonAddress>
    {
        public PersonAddressConfiguration()
        {
            Property(p => p.Id).IsRequired();
            Property(p => p.AddressType).IsRequired();
            Property(p => p.IsDefaultContactAddress).IsRequired();
            Property(p => p.MemberId).IsRequired();
            Property(p => p.FullAddress).HasMaxLength(100).IsRequired();
            HasRequired(p => p.Person).WithMany(person=>person.Address).HasForeignKey(p => p.MemberId);
            
        }
    }
}