using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class IProcess
{
    public Guid ProcessId { get; set; }

    public string ProcessName { get; set; } = null!;

    /// <summary>
    /// A-Active;I-InActive
    /// </summary>
    public string ProcessStatus { get; set; } = null!;
}
