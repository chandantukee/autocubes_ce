using System;
using System.Collections.Generic;

namespace AutoCubes.Infrastructure.Models;

public partial class ICompanyType
{
    public Guid CompanyTypeId { get; set; }

    public string CompanyTypeName { get; set; } = null!;
}
