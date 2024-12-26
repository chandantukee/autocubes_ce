using AutoCubes.Application.Contracts.Masters;
using AutoCubes.Application.Queries.GetCountries;
using AutoCubes.Application.Queries.GetOrganizations;
using Dapper;
using System.Data;

namespace AutoCubes.Infrastructure.QueryRepository
{
    public class OrganizationQueryRepository : IOrganizationQueryRepository
    {
        private readonly IDbConnection _connection;

        public OrganizationQueryRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public async Task<IEnumerable<GetOrganizationsQueryResult>> GetAllAsync(GetOrganizationsQuery query)
        {
            string sql = "SELECT OrganizationId, OrganizationName, CreatedAt FROM admin_organization";
            var result = await _connection.QueryAsync<GetOrganizationsQueryResult>(sql);
            query.IsSuccess = true;
            return result;
        }
    }
}
