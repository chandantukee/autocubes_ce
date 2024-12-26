using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class IRolePermission
{
    public Guid RolePermissionId { get; set; }

    public Guid RoleId { get; set; }

    public Guid ScreenId { get; set; }

    public virtual IRole Role { get; set; } = null!;

    public virtual IScreen Screen { get; set; } = null!;
}
