using System;
using OpenLibrary.Core.Types.BaseTypes;

namespace OpenLibrary.Core.Types
{
    public class City : IEntity
    {
        public Guid Id { get; set; }

        public string CityCode { get; set; }

        public string CityName { get; set; }

    }
}