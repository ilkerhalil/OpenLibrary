using System;

namespace OpenLibrary.Model.Types
{
    public class Request :BaseEntity
    {
        public int RequestId { get; set; }

        public string Isbn  { get; set; }

        public Book Book { get; set; }

        public Guid MemberId { get; set; }

        public People People { get; set; }

        public DateTime RequestedDate { get; set; }

        public string Description { get; set; }
    }
}
