using System;
using System.Collections.Generic;

namespace OpenLibrary.Model.Types
{
    public class BookByCategories
    {
        public virtual Book Book { get; set; }

        public virtual Category Category { get; set; }
    }
}