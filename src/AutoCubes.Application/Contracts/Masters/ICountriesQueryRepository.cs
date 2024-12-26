using AutoCubes.Application.Queries.GetCountries;

namespace AutoCubes.Application.Contracts.Masters
{
    public interface ICountriesQueryRepository
    {
        Task<IEnumerable<GetCountriesQueryResult>> GetAllAsync(GetCountriesQuery query);

    }
}
