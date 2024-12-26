using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class IScreen
{
    public Guid ScreenId { get; set; }

    public string ScreenName { get; set; } = null!;

    public string ScreenSlug { get; set; } = null!;

    public sbyte ScreenStatus { get; set; }

    public virtual ICollection<IRolePermission> IRolePermissions { get; set; } = new List<IRolePermission>();
}
