using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class IStage
{
    public Guid StageId { get; set; }

    public string StageName { get; set; } = null!;

    public sbyte StageStatus { get; set; }
}
