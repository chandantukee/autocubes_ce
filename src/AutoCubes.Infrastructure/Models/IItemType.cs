using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class IItemType
{
    public Guid ItemTypeId { get; set; }

    /// <summary>
    /// P - Product; S - Service
    /// </summary>
    public string ItemTypeCode { get; set; } = null!;

    public sbyte ItemTypeStatus { get; set; }
}
