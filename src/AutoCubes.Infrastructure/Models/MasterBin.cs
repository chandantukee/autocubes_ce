using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class MasterBin
{
    public Guid BinId { get; set; }

    public string BinName { get; set; } = null!;

    public sbyte BinStatus { get; set; }
}
