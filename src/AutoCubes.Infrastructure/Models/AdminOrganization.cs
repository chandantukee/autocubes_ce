using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class AdminOrganization
{
    public Guid OrganizationId { get; set; }

    public string OrganizationCode { get; set; } = null!;

    public string OrganizationName { get; set; } = null!;

    public string OrganizationAlias { get; set; } = null!;

    public string OrganizationAddress { get; set; } = null!;

    public string OrganizationPincode { get; set; } = null!;

    public string OrganizationContactPerson { get; set; } = null!;

    public string OrganizationMobile { get; set; } = null!;

    public string OrganizationEmail { get; set; } = null!;

    /// <summary>
    /// ^[0-9]{2}[A-Z]{5}[0-9]{4}[A-Z]{1}[1-9A-Z]{1}Z[0-9A-Z]{1}$
    /// </summary>
    public string Gstin { get; set; } = null!;

    public string Cin { get; set; } = null!;

    /// <summary>
    /// ([A-Z]){5}([0-9]){4}([A-Z]){1}$
    /// </summary>
    public string Pan { get; set; } = null!;

    /// <summary>
    /// ([A-Z]){5}([0-9]){4}([A-Z]){1}$
    /// </summary>
    public string Iec { get; set; } = null!;

    public Guid OrganizationCityId { get; set; }

    public Guid OrganizationStateId { get; set; }

    public Guid OrganizationTypeId { get; set; }

    public sbyte OrganizationStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AdminUser> AdminUsers { get; set; } = new List<AdminUser>();

    public virtual AdminOrganizationType OrganizationType { get; set; } = null!;
}
