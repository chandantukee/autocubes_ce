using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class IItemCategory
{
    public Guid ItemCategoryId { get; set; }

    /// <summary>
    /// HelmetsPaddings/Visors/PinLock
    /// </summary>
    public string ItemCategoryName { get; set; } = null!;
}
