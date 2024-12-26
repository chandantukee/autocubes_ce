using AutoCubes.Application.Contracts.Masters;
using AutoCubes.Shared.Queries;

namespace AutoCubes.Application.Queries.GetCountries
{
    public class GetCountriesQueryHandler : IQueryHandler<GetCountriesQuery, IEnumerable<GetCountriesQueryResult>>
    {
        private readonly ICountriesQueryRepository _countriesQueryRepository;

        public GetCountriesQueryHandler(ICountriesQueryRepository countriesQueryRepository)
        {
            _countriesQueryRepository = countriesQueryRepository;
        }
        public async Task<IEnumerable<GetCountriesQueryResult>> HandleAsync(GetCountriesQuery query)
        {
            return await _countriesQueryRepository.GetAllAsync(query);
        }
    }
}
