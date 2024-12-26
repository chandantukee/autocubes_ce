using AutoCubes.Application.Contracts.Masters;
using AutoCubes.Application.Queries.GetCountries;
using Dapper;
using System.Data;

namespace AutoCubes.Infrastructure.QueryRepository
{
    public class CountriesQueryRepository : ICountriesQueryRepository
    {
        private readonly IDbConnection _connection;

        public CountriesQueryRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public async Task<IEnumerable<GetCountriesQueryResult>> GetAllAsync(GetCountriesQuery query)
        {
            string sql = "SELECT CountryId, CountryCode, CountryName FROM i_country";
            var result = await _connection.QueryAsync<GetCountriesQueryResult>(sql);
            query.IsSuccess = true;
            return result;
        }
    }
}
