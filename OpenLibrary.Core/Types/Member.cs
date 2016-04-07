using System;
using System.Collections.Generic;

namespace OpenLibrary.Core.Types
{
    public class Member : IEntity
    {
        public Guid Id { get; set; }
        public Guid MemberAddressId { get; set; }
        public IList<MemberAddress> MemberAddress { get; set; }
        public Gender Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<PhoneNumber> PhoneNumbers { get; set; }
        public IList<EMailAddress> EMailAddresses { get; set; }
        public IList<Note> Notes { get; set; }

    }

    public class Author : Member
    {

    }
}