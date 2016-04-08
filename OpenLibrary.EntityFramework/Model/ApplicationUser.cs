using System;
using Microsoft.AspNet.Identity.EntityFramework;
using OpenLibrary.Model.Types;

namespace OpenLibrary.EntityFramework.Model
{
    public class ApplicationUser : IdentityUser
    {
        public Guid PeopleId { get; set; }
        public People People { get; set; }

       

    }
}
