using System;

namespace OpenLibrary.Core.Types
{
    public class Note : IEntity
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public Person Person { get; set; }
        public string Description { get; set; }

    }
}