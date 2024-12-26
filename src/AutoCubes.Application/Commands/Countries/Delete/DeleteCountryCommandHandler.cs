using AutoCubes.Application.Contracts.Masters;
using AutoCubes.Shared.Commands;

namespace AutoCubes.Application.Commands.Countries.Delete
{
    public class DeleteCountryCommandHandler : ICommandHandler<DeleteCountryCommand>
    {
        private readonly ICountriesCommandRepository _countryRepository;

        public DeleteCountryCommandHandler(ICountriesCommandRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public async Task HandleAsync(DeleteCountryCommand command)
        {
            await _countryRepository.DeleteAsync(command.Id);
            command.IsSuccess = true;
        }
    }
}
