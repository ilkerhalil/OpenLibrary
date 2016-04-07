using System.Data.Entity.ModelConfiguration;
using System.Security.Permissions;
using OpenLibrary.Core.Types;

namespace OpenLibrary.EntityFramework
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            Property(p => p.Id).IsRequired();
            Property(p => p.FirstName).HasMaxLength(30).IsRequired();
            Property(p => p.LastName).HasMaxLength(30).IsRequired();
            Property(p => p.Gender).IsOptional();

        }
    }
}