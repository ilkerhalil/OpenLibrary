using System;
using OpenLibrary.Core.Types.BaseTypes;

namespace OpenLibrary.Core.Types
{
    public class PersonAddress : Address
    {

        public Guid MemberId { get; set; }

        public Person Person { get; set; }

        public bool IsDefaultContactAddress { get; set; }

        public AddressType AddressType { get; set; }


    }
}