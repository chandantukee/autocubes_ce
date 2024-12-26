using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class ICity
{
    public Guid CityId { get; set; }

    public string CityName { get; set; } = null!;

    public Guid StateId { get; set; }
}
