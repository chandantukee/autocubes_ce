using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class FactPurchaseOrder
{
    public Guid PurchaseOrderId { get; set; }

    public Guid SupplierId { get; set; }

    public Guid DealerId { get; set; }

    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public string OrderStatus { get; set; } = null!;

    public decimal SupplierOrderValue { get; set; }

    public Guid CreatedById { get; set; }

    public DateTime? CreatedDate { get; set; }

    public Guid? ApprovedByid { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public Guid? ModifiedById { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid? CancelledById { get; set; }

    public DateTime? CancelledDate { get; set; }

    public DateTime? ExpectedDeliveryDate { get; set; }

    public string? Remarks { get; set; }

    public virtual ICollection<FactPurchaseOrderDetail> FactPurchaseOrderDetails { get; set; } = new List<FactPurchaseOrderDetail>();
}
