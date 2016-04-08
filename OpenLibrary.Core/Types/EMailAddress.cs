using System;
using OpenLibrary.Model.Types.Enumarations;

namespace OpenLibrary.Model.Types
{
    public class EMailAddress :BaseEntity
    {
        public int EMailAddressId { get; set; }

        public string EMail { get; set; }

        public Guid PeopleId { get; set; }

        public People People { get; set; }

        public EMailAddressType EMailAddressType { get; set; }

    }
}