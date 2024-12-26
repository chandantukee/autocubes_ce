namespace AutoCubes.Domain.Entities
{
    public class PurchaseOrder
    {
        public int Id { get; private set; }
        public DateTime OrderDate { get; private set; }
        public string Vendor { get; private set; }
        public List<PurchaseOrderDetail> Items { get; private set; } = new List<PurchaseOrderDetail>();

        public PurchaseOrder(int id, DateTime orderDate, string vendor)
        {
            Id = id;
            OrderDate = orderDate;
            Vendor = vendor;
        }

        public void AddItem(PurchaseOrderDetail item)
        {
            Items.Add(item);
        }
    }

    public class PurchaseOrderDetail
    {
        public int Id { get; private set; }
        public int PurchaseOrderId { get; private set; }
        public string Product { get; private set; }
        public int Quantity { get; private set; }

        public PurchaseOrderDetail(int id, int purchaseOrderId, string product, int quantity)
        {
            Id = id;
            PurchaseOrderId = purchaseOrderId;
            Product = product;
            Quantity = quantity;
        }
    }
}
