using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using OpenLibrary.EntityFramework.Configurations;
using OpenLibrary.EntityFramework.Model;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework
{
    public class OpenLibraryDbContext:IdentityDbContext<ApplicationUser>
    {
        public OpenLibraryDbContext() 
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            
        }

        //public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EMailAddress> EMailAddresses { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public static OpenLibraryDbContext CreateLibraryDbContext()
        {
            return new OpenLibraryDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new ApplicationUserConfiguration());
            modelBuilder.Configurations.Add(new PeopleConfiguration());
            modelBuilder.Configurations.Add(new BookConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CityConfiguration());
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new EmailAddressConfiguration());
            modelBuilder.Configurations.Add(new LibraryConfiguration());
            modelBuilder.Configurations.Add(new NoteConfiguration());
            modelBuilder.Configurations.Add(new PhoneConfiguration());
            modelBuilder.Configurations.Add(new RequestConfiguration());

            //modelBuilder.Configurations.Add(new BookByCategoriesConfiguration());
            //modelBuilder.Configurations.Add(new BooksAtLibrariesConfiguration());
            //modelBuilder.Configurations.Add(new BooksByAuthorConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
