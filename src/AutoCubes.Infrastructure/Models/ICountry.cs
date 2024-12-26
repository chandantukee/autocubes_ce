using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class ICountry
{
    public Guid CountryId { get; set; }

    /// <summary>
    /// IND356
    /// </summary>
    public string CountryCode { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public string? CountryAlias { get; set; }

    public sbyte CountryStatus { get; set; }

    public virtual ICollection<IState> IStates { get; set; } = new List<IState>();
}
