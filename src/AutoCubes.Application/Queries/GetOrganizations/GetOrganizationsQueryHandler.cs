using AutoCubes.Shared.Queries;

namespace AutoCubes.Application.Queries.GetOrganizations
{
    public class GetOrganizationsQueryHandler : IQueryHandler<GetOrganizationsQuery, List<GetOrganizationsQueryResult>>
    {
        public GetOrganizationsQueryHandler()
        {
            
        }
        public Task<List<GetOrganizationsQueryResult>> HandleAsync(GetOrganizationsQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
