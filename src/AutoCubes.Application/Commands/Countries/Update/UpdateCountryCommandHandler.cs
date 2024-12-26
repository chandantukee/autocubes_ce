using AutoCubes.Application.Contracts.Masters;
using AutoCubes.Shared.Commands;

namespace AutoCubes.Application.Commands.Countries.Update
{
    public class UpdateCountryCommandHandler : ICommandHandler<UpdateCountryCommand>
    {
        private readonly ICountriesCommandRepository _countryRepository;

        public UpdateCountryCommandHandler(ICountriesCommandRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public async Task HandleAsync(UpdateCountryCommand command)
        {
            await _countryRepository.UpdateAsync(command);
            command.IsSuccess = true;
        }
    }
}
