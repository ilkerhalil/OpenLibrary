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


        public static OpenLibraryDbContext CreateLibraryDbContext()
        {
            return new OpenLibraryDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new PersonAddressConfiguration());
            modelBuilder.Configurations.Add(new PhoneConfiguration());
            modelBuilder.Configurations.Add(new AuthorConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
