namespace OpenLibrary.Model.Types
{
    public class Address :BaseEntity
    {
        public int AddressId { get; set; }

        public string FullAddress { get; set; }

        public string CityCode { get; set; }

        public City City { get; set; }

        public string CountryCode { get; set; }

        public Country Country { get; set; }
    }
}