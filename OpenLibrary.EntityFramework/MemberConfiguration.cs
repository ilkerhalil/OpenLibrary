using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Core.Types;

namespace OpenLibrary.EntityFramework
{
    public class MemberConfiguration : EntityTypeConfiguration<Member>
    {
        public MemberConfiguration()
        {
            Property(p => p.Id).IsRequired();
            Property(p => p.FirstName).HasMaxLength(30).IsRequired();
            Property(p => p.LastName).HasMaxLength(30).IsRequired();
        }

    }
}