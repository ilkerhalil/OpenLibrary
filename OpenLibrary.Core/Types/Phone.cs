using System;
using OpenLibrary.Core.Types.BaseTypes;

namespace OpenLibrary.Core.Types
{
    public class Phone  : IEntity
    {
        public Guid Id { get; set; }

        public Guid MemberId { get; set; }

        public Person Person { get; set; }

        public string Number { get; set; }

        public string Description { get; set; }

        public string AreaCode { get; set; }

        public PhoneType PhoneType { get; set; }

        public bool IsDefaultContactNumber { get; set; }



    }
}