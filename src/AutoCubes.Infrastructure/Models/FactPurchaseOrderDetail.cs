using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class FactPurchaseOrderDetail
{
    public Guid PurchaseOrderDetailId { get; set; }

    public Guid PurchaseOrderId { get; set; }

    public Guid ItemTypeId { get; set; }

    public Guid ItemCategoryId { get; set; }

    public Guid ItemId { get; set; }

    public int OrderQuantity { get; set; }

    public int SuppliedQuantity { get; set; }

    public virtual FactPurchaseOrder PurchaseOrder { get; set; } = null!;
}
