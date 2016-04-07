using System;

namespace OpenLibrary.Core.Types.BaseTypes
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}