using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class AdminLocation
{
    public Guid LocationId { get; set; }

    public string LocationCode { get; set; } = null!;

    public string LocationName { get; set; } = null!;

    public string? LocationAlias { get; set; }

    public string LocationAddress { get; set; } = null!;

    public string LocationPincode { get; set; } = null!;

    public string LocationPhone { get; set; } = null!;

    public string LocationEmail { get; set; } = null!;

    public string LocationContactPerson { get; set; } = null!;

    /// <summary>
    /// W - Warehouse; O - Office; B - Both
    /// </summary>
    public string LocationType { get; set; } = null!;

    public Guid OrganizationId { get; set; }

    public Guid CityId { get; set; }

    public Guid StateId { get; set; }

    public sbyte InvoiceAllowed { get; set; }

    public sbyte LocationStatus { get; set; }
}
