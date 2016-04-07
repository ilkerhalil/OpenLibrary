using System;

namespace OpenLibrary.Core.Types
{
    public class BaseAddress : IEntity
    {
        public Guid Id { get; set; }

        public string FullAddress { get; set; }

        public City City { get; set; }

        public Country Country { get; set; }
    }
}