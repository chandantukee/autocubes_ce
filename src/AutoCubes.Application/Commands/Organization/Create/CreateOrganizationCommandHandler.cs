using AutoCubes.Application.Contracts.Masters;
using AutoCubes.Domain.Entities;
using AutoCubes.Shared.Commands;
using System;

namespace AutoCubes.Application.Commands.Organization.Create
{
    public class CreateOrganizationCommandHandler : ICommandHandler<CreateOrganizationCommand>
    {
        private readonly IOrganizationCommandRepository _repository;

        public CreateOrganizationCommandHandler(IOrganizationCommandRepository repository)
        {
            _repository = repository;
        }
        public async Task HandleAsync(CreateOrganizationCommand command)
        {
            // add fluent validation
            var entity = new AdminOrganization()
            {
                OrganizationName = command.OrganizationName,
                OrganizationAlias = command.OrganizationAlias,
                OrganizationCode = command.OrganizationCode,
                OrganizationTypeId = command.OrganizationTypeId,
                Cin = command.Cin,
                Gstin = command.Gstin,
                Iec = command.Iec,
                Pan = command.Pan,
                OrganizationContactPerson = command.OrganizationContactPerson,
                OrganizationCountryId = command.OrganizationCountryId,
                OrganizationStateId = command.OrganizationStateId,
                OrganizationCityId = command.OrganizationCityId,
                OrganizationEmail = command.OrganizationEmail,
                OrganizationMobile = command.OrganizationMobile,
                OrganizationAddress = command.OrganizationAddress,
                OrganizationPincode = command.OrganizationPincode,

            };
            await _repository.AddAsync(entity);
        }
    }
}
