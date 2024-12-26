using AutoCubes.Shared.Commands;

namespace AutoCubes.Application.Commands.Countries.Delete
{
    public class DeleteCountryCommand : BaseCommand
    {
        public Guid Id { get; set; }
    }
}
