namespace AutoCubes.Application.DTOs
{
    public class UpdateCountryDto
    {
        public Guid  Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryAlias { get; set; }
    }
}
