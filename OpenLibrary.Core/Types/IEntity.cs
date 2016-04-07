using System;

namespace OpenLibrary.Core.Types
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}