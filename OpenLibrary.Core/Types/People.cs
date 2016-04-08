using System;
using System.Collections.Generic;
using OpenLibrary.Model.Types.Enumarations;

namespace OpenLibrary.Model.Types
{
    public class People :BaseEntity
    {
        public Guid PeopleId{ get; set; }
        public IList<Address> Address { get; set; }
        public Gender Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; }
        public IList<Phone> PhoneNumbers { get; set; }
        public IList<EMailAddress> EMailAddresses { get; set; }
        public IList<Note> Notes { get; set; }
        public IList<Book> Books { get; set; }


    }
}