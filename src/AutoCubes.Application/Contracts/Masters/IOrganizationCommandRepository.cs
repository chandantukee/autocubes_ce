using AutoCubes.Application.Queries.GetOrganizations;
using AutoCubes.Domain.Entities;

namespace AutoCubes.Application.Contracts.Masters
{
    public interface IOrganizationCommandRepository
    {
        Task AddAsync(AdminOrganization entity);
        Task DeleteAsync(Guid Id);
    }
}
