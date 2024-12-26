namespace AutoCubes.Infrastructure.Models;

public partial class AdminOrganizationType
{
    public Guid OrganizationTypeId { get; set; }

    public string OrganizationTypeName { get; set; } = null!;

    public virtual ICollection<AdminOrganization> AdminOrganizations { get; set; } = new List<AdminOrganization>();
}
