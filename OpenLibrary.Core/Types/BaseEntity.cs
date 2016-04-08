using System;

namespace OpenLibrary.Model.Types
{
    public abstract class BaseEntity
    {
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string AddedUser { get; set; }
        public string ModifiedUser { get; set; }

    }
}
