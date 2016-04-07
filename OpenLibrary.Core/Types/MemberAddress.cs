using System;

namespace OpenLibrary.Core.Types
{
    public class MemberAddress : BaseAddress
    {

        public Guid MemberId { get; set; }

        public Member Member { get; set; }

        public bool IsDefaultContactAddress { get; set; }

        public AddressType AddressType { get; set; }


    }

    public class BaseAddress : IEntity
    {
        public Guid Id { get; set; }

        public string Address { get; set; }

        public City City { get; set; }

        public Country Country { get; set; }
    }
}