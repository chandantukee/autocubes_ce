namespace AutoCubes.UI.Models.Supplier
{
  public class CreateSupplierViewModel
  {    
    public string SupplierCode { get; set; } = null!;

    public string SupplierName { get; set; } = null!;

    public string SupplierAlias { get; set; } = null!;

    public string SupplierAddress { get; set; } = null!;

    public string SupplierPincode { get; set; } = null!;

    public string SupplierMobile { get; set; } = null!;

    public string SupplierEmail { get; set; } = null!;

    public string SupplierContactPerson { get; set; } = null!;

    public Guid SupplierType { get; set; }

    public string Gstin { get; set; } = null!;

    public string Cin { get; set; } = null!;

    public string Pan { get; set; } = null!;

    public string Iec { get; set; } = null!;

    public Guid SupplierCityId { get; set; }

    public Guid SupplierStateId { get; set; }

    public sbyte SupplierStatus { get; set; }

    public Guid SupplierCountryId { get; set; }
    
    // Master Data

    public List<SelectModel> SupplierTypes { get; set; } = new List<SelectModel>();
    public List<SelectModel> Countries { get; set; } = new List<SelectModel>();
    public List<SelectModel> States { get; set; } = new List<SelectModel>();
    public List<SelectModel> Cities { get; set; } = new List<SelectModel>();
  }
}
