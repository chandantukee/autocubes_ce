using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class IState
{
    public Guid StateId { get; set; }

    public string StateCode { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public Guid CountryId { get; set; }

    public virtual ICountry Country { get; set; } = null!;
}
