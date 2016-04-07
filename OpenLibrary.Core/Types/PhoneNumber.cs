using System;

namespace OpenLibrary.Core.Types
{
    public class PhoneNumber : IEntity
    {
        public Guid Id { get; set; }

        public Guid MemberId { get; set; }

        public Member Member { get; set; }


        public string Number { get; set; }

        public string Description { get; set; }

        public string AreaCode { get; set; }

        public PhoneNumberType PhoneNumberType { get; set; }

        public bool IsDefaultContactNumber { get; set; }



    }
}