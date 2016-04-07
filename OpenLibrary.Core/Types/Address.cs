using System;

namespace OpenLibrary.Core.Types
{
    public class Address : BaseAddress
    {

        public Guid MemberId { get; set; }

        public Member Member { get; set; }

        public bool IsDefaultContactAddress { get; set; }

        public AddressType AddressType { get; set; }


    }
}