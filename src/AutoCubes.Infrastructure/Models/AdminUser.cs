using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class AdminUser
{
    public Guid UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string UserMobile { get; set; } = null!;

    public string? WhatsAppNumber { get; set; }

    public string UserEmail { get; set; } = null!;

    public Guid OrganizationId { get; set; }

    public Guid DesignationId { get; set; }

    public Guid RoleId { get; set; }

    public sbyte EmailConfirmed { get; set; }

    public sbyte MobileConfirmed { get; set; }

    public sbyte UserStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual MasterDesignation Designation { get; set; } = null!;

    public virtual AdminOrganization Organization { get; set; } = null!;
}
