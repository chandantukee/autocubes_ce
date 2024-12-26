namespace AutoCubes.Domain.Entities
{
    public class AdminOrganization
    {
        public string OrganizationCode { get; set; } = null!;
        public string OrganizationName { get; set; } = null!;
        public string OrganizationAlias { get; set; } = null!;
        public string OrganizationAddress { get; set; } = null!;
        public string OrganizationPincode { get; set; } = null!;
        public string OrganizationContactPerson { get; set; } = null!;
        public string OrganizationMobile { get; set; } = null!;
        public string OrganizationEmail { get; set; } = null!;
        public string Gstin { get; set; } = null!;
        public string Cin { get; set; } = null!;
        public string Pan { get; set; } = null!;
        public string Iec { get; set; } = null!;
        public Guid OrganizationCountryId { get; set; }
        public Guid OrganizationCityId { get; set; }
        public Guid OrganizationStateId { get; set; }
        public Guid OrganizationTypeId { get; set; }
    }
}
