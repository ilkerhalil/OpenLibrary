using System.Data.Entity.ModelConfiguration;
using OpenLibrary.Core.Types;

namespace OpenLibrary.EntityFramework
{
    public class PhoneConfiguration:EntityTypeConfiguration<Phone>
    {
        public PhoneConfiguration()
        {
            Property(p => p.Id).IsRequired();
            Property(p => p.AreaCode).HasMaxLength(3).IsRequired();
            Property(p => p.Description).HasMaxLength(100).IsOptional();
            Property(p => p.IsDefaultContactNumber).IsRequired();
            Property(p => p.Number).HasMaxLength(10).IsRequired();
            Property(p => p.MemberId).IsRequired();
            HasRequired(p => p.Person).WithMany(p => p.PhoneNumbers).HasForeignKey(p => p.MemberId);
        }
    }
}
