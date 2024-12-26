using AutoCubes.Shared.Commands;

namespace AutoCubes.Application.Commands.Countries.Create
{
    public class CreateCountryCommand : BaseCommand
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryAlias { get; set; }
        public Guid CountryId { get; set; }
    }
}
