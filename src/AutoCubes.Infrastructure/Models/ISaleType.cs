using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class ISaleType
{
    public Guid SaleTypeId { get; set; }

    /// <summary>
    /// B2B; B2C
    /// </summary>
    public string SaleTypeName { get; set; } = null!;

    public sbyte Gstrequired { get; set; }
}
