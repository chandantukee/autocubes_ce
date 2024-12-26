using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class AdminDealer
{
    public Guid DealerId { get; set; }

    public string DealerCode { get; set; } = null!;

    public string DealerName { get; set; } = null!;

    public string DealerAlias { get; set; } = null!;

    public string DealerAddress { get; set; } = null!;

    public string DealerPincode { get; set; } = null!;

    public string Gstin { get; set; } = null!;

    public string Cin { get; set; } = null!;

    public string Pan { get; set; } = null!;

    public string Iec { get; set; } = null!;

    public Guid DealerType { get; set; }

    public Guid DealerCityId { get; set; }

    public Guid DealerStateId { get; set; }

    public string DealerMobile { get; set; } = null!;

    public string DealerEmail { get; set; } = null!;

    public string DealerContactPerson { get; set; } = null!;

    public sbyte DealerStatus { get; set; }

    public int? DealerCreditTime { get; set; }

    public decimal? DealerCreditValue { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
