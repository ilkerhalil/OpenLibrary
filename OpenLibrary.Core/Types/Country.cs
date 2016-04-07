using System;

namespace OpenLibrary.Core.Types
{
    public class Country : IEntity
    {
        public Guid Id { get; set; }

        public string CountryCode { get; set; }

        public string CountryName { get; set; }


    }
}