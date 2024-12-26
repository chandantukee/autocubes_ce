using AutoCubes.Application.Commands.Countries.Create;
using AutoCubes.Application.Commands.Countries.Update;

namespace AutoCubes.Application.Contracts.Masters
{
    public interface ICountriesCommandRepository
    {
        Task AddAsync(CreateCountryCommand command);
        Task UpdateAsync(UpdateCountryCommand command);
        Task DeleteAsync(Guid Id);
    }
}
