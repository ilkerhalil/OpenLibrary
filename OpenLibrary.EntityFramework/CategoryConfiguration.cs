using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenLibrary.Core.Types;

namespace OpenLibrary.EntityFramework
{
   public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
       public CategoryConfiguration()
       {
           Property(category => category.Id).IsRequired();
           Property(category => category.CategoryName).IsRequired().HasMaxLength(255);
       }
        
    }
}
