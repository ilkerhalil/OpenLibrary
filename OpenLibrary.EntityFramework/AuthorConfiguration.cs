using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenLibrary.Core.Types;

namespace OpenLibrary.EntityFramework
{
    public class AuthorConfiguration: EntityTypeConfiguration<Author>
    {
        public AuthorConfiguration()
        {
            Property(p => p.BirthDate).IsOptional();
        }
    }
}
