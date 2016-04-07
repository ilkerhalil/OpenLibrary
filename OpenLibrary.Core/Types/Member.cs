using System;
using System.Collections.Generic;

namespace OpenLibrary.Core.Types
{
    public class Member : IEntity
    {
        public Guid Id { get; set; }
        public IList<Address> MemberAddress { get; set; }
        public Gender Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Phone> PhoneNumbers { get; set; }
        public IList<EMailAddress> EMailAddresses { get; set; }
        public IList<Note> Notes { get; set; }

    }
}