using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class MasterItemPrice
{
    public Guid ItemPriceId { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Mrp { get; set; }

    public decimal TaxValue { get; set; }

    public Guid CreatedById { get; set; }

    public Guid? UpdatedById { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
