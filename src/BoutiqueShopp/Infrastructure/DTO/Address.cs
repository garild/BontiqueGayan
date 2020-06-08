namespace BoutiqueShopp.Infrastructure.DTO
{
    public class Address
    {
        public string StreetName { get; private set; }
        public string StreetNumber { get; private set; }
        public string City { get; private set; }
        public string PostCode { get; private set; }


        public static string Creates(string streetName, string streetNumber, string city, string postCode)
        {
            if (string.IsNullOrEmpty(postCode) && string.IsNullOrEmpty(city))
                return "Brak";
            if (string.IsNullOrEmpty(streetNumber) && string.IsNullOrEmpty(city) && string.IsNullOrEmpty(postCode))
                return "Brak";

            return $"{streetName}/{streetNumber}, {postCode} {city}";
        }

    }
}
