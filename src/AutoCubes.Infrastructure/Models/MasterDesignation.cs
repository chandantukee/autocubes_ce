using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class MasterDesignation
{
    public Guid DesignationId { get; set; }

    public string DesignationName { get; set; } = null!;

    public virtual ICollection<AdminUser> AdminUsers { get; set; } = new List<AdminUser>();
}
