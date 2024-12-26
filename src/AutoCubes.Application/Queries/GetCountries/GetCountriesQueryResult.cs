namespace AutoCubes.Application.Queries.GetCountries
{
    public class GetCountriesQueryResult
    {
        public Guid CountryId { get; set; }

        public string CountryCode { get; set; }

        public string CountryName { get; set; }
    }
}