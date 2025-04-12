using System;
using System.Collections.Generic;

namespace FuneralCRM.DataBase;

public partial class SubcontractorOrder
{
    public int SubcontractorId { get; set; }

    public int OrderId { get; set; }

    public string? ServiceDetails { get; set; }

    public decimal? Amount { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Subcontractor Subcontractor { get; set; } = null!;
}
