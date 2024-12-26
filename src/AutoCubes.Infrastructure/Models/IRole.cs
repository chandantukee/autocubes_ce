using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class IRole
{
    public Guid RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public sbyte RoleStatus { get; set; }

    public virtual ICollection<IRolePermission> IRolePermissions { get; set; } = new List<IRolePermission>();
}
