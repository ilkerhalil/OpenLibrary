using System.Data.Entity.ModelConfiguration;
using System.Net;
using OpenLibrary.EntityFramework.Model;

namespace OpenLibrary.EntityFramework.Configurations
{
    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserConfiguration()
        {
            //HasRequired(hh => hh.People).WithRequiredDependent(people => new ApplicationUser());
        }
    }
}