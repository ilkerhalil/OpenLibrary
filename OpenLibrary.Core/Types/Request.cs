using System;
using System.Diagnostics.Eventing.Reader;
using OpenLibrary.Core.Types.BaseTypes;

namespace OpenLibrary.Core.Types
{
    public class Request : IEntity
    {
        public Guid Id { get; set; }

        public Guid BookId { get; set; }

        public Book Book { get; set; }

        public Guid MemberId { get; set; }

        public Person Person { get; set; }

        public DateTime RequestedDate { get; set; }

        public string Description { get; set; }
    }
}
