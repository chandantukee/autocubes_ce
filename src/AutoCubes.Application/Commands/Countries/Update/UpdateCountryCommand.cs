using AutoCubes.Shared.Commands;

namespace AutoCubes.Application.Commands.Countries.Update
{
    public class UpdateCountryCommand : BaseCommand
    {
        public Guid Id { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CountryAlias { get; set; }
    }
}
