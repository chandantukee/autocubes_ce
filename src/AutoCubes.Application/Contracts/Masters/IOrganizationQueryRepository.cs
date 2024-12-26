using AutoCubes.Application.Queries.GetOrganizations;

namespace AutoCubes.Application.Contracts.Masters
{
    public interface IOrganizationQueryRepository
    {
        Task<IEnumerable<GetOrganizationsQueryResult>> GetAllAsync(GetOrganizationsQuery query);
    }
}
