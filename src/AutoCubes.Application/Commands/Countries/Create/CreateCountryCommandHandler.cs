using AutoCubes.Application.Contracts.Masters;
using AutoCubes.Shared.Commands;

namespace AutoCubes.Application.Commands.Countries.Create
{
    public class CreateCountryCommandHandler : ICommandHandler<CreateCountryCommand>
    {
        private readonly ICountriesCommandRepository _repository;

        public CreateCountryCommandHandler(ICountriesCommandRepository repository)
        {
            _repository = repository;
        }
        public async Task HandleAsync(CreateCountryCommand command)
        {
            await _repository.AddAsync(command);
            command.IsSuccess = true;
        }
    }
}
