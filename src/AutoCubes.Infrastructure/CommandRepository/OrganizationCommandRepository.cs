using AutoCubes.Application.Contracts.Masters;
using AutoCubes.Infrastructure.Context;
using AutoCubes.Infrastructure.Models;

namespace AutoCubes.Infrastructure.CommandRepository
{
    public class OrganizationCommandRepository : IOrganizationCommandRepository
    {
        private readonly AutoCubesDbContext _context;

        public OrganizationCommandRepository(AutoCubesDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Domain.Entities.AdminOrganization entity)
        {
            var model = new AdminOrganization() 
            {
                OrganizationName = entity.OrganizationName,
                OrganizationAlias = entity.OrganizationAlias,
                OrganizationCode = entity.OrganizationCode,
                OrganizationTypeId = entity.OrganizationTypeId,
                Cin = entity.Cin,
                Gstin = entity.Gstin,
                Iec = entity.Iec,
                Pan = entity.Pan,
                OrganizationContactPerson = entity.OrganizationContactPerson,
                OrganizationStateId = entity.OrganizationStateId,
                OrganizationCityId = entity.OrganizationCityId,
                OrganizationEmail = entity.OrganizationEmail,
                OrganizationMobile = entity.OrganizationMobile,
                OrganizationAddress = entity.OrganizationAddress,
                OrganizationPincode = entity.OrganizationPincode,
                CreatedAt = DateTime.Now,
            };
            await _context.AdminOrganizations.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
