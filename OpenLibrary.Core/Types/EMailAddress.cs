using System;

namespace OpenLibrary.Core.Types
{
    public class EMailAddress : IEntity
    {
        public Guid Id { get; set; }

        public string EMail { get; set; }

        public Guid MemberId { get; set; }

        public Member Member { get; set; }

        public EMailAddressType EMailAddressType { get; set; }

    }
}