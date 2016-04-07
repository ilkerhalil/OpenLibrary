using System;
using System.Diagnostics.Eventing.Reader;

namespace OpenLibrary.Core.Types
{
    public class MemberRequest : IEntity
    {
        public Guid Id { get; set; }

        public Guid BookId { get; set; }

        public Book Book { get; set; }

        public Guid MemberId { get; set; }

        public Member Member { get; set; }

        public DateTime RequestedDate { get; set; }

        public string Description { get; set; }
    }
}
