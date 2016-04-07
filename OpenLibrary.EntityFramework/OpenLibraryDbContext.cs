using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenLibrary.Core.Types;

namespace OpenLibrary.EntityFramework
{
    public class OpenLibraryDbContext:DbContext
    {
        public OpenLibraryDbContext() : base("Default")
        {

        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Address> MemberAddresses { get; set; }

        public DbSet<BaseAddress> BaseAddresses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookConfiguration());
            modelBuilder.Configurations.Add(new MemberConfiguration());
            modelBuilder.Configurations.Add(new MemberAddressConfiguration());
            modelBuilder.Configurations.Add(new PhoneConfiguration());
            modelBuilder.Configurations.Add(new AuthorConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
