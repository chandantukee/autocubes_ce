using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class IUnitOfMeasurement
{
    public Guid Uomid { get; set; }

    public string Uomcode { get; set; } = null!;

    public string Uomname { get; set; } = null!;

    public Guid BaseUomid { get; set; }

    public string ConversionFactor { get; set; } = null!;

    public sbyte IsBaseUom { get; set; }
}
