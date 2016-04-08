using System;

namespace OpenLibrary.Model.Types
{
    public class Book :BaseEntity
    {

        public string Isbn { get; set; }


        public DateTime PublicationDate { get; set; }

        public string Title { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string PeopleId { get; set; }
        public People Author { get; set; }


        public int LibraryId { get; set; }
        public Library Library { get; set; }
        
    }
}