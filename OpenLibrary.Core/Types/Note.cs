using System;

namespace OpenLibrary.Model.Types
{
    public class Note :BaseEntity
    {
        public int NoteId { get; set; }
        public Guid PeopleId { get; set; }
        public People People { get; set; }
        public string Description { get; set; }

    }
}