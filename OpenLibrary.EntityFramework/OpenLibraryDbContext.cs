using System.Data.Entity;
using OpenLibrary.Core.Types;

namespace OpenLibrary.EntityFramework
{
    public class OpenLibraryDbContext:DbContext
    {
        public OpenLibraryDbContext() 
            : base("DefaultConnection")
        {

        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Person> Members { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<PersonAddress> PersonAddresses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new PersonAddressConfiguration());
            modelBuilder.Configurations.Add(new PhoneConfiguration());
            modelBuilder.Configurations.Add(new AuthorConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
