using System;
using OpenLibrary.Model.Types.Enumarations;

namespace OpenLibrary.Model.Types
{
    public class Phone  :BaseEntity
    {
        public int PhoneId { get; set; }

        public Guid PeopleId { get; set; }

        public People People { get; set; }

        public string Number { get; set; }

        public string Description { get; set; }

        public string AreaCode { get; set; }

        public PhoneType PhoneType { get; set; }

        public bool IsDefaultContactNumber { get; set; }



    }
}