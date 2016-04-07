using System;

namespace OpenLibrary.Core.Types
{
    public class Category : IEntity
    {
        public Guid Id { get; set; }

        public string CategoryName { get; set; }

    }
}