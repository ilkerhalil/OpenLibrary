using System;
using OpenLibrary.Core.Types.BaseTypes;

namespace OpenLibrary.Core.Types
{
    public class Book : IEntity
    {
        public Guid Id { get; set; }

        public string Isbn { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Title { get; set; }

    }
}