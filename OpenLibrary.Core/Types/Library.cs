using System;
using System.Collections.Generic;
using OpenLibrary.Core.Types.BaseTypes;

namespace OpenLibrary.Core.Types
{
    public class Library : IEntity
    {
        public Guid Id { get; set; }

        public List<LibraryOfficer> Officers { get; set; }


        public string Description { get; set; }

    }
}