using System;
using System.Collections.Generic;

namespace FuneralCRM.DataBase;

public partial class Subcontractor
{
    public int SubcontractorId { get; set; }

    public string Name { get; set; } = null!;

    public int ServiceTypeId { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public virtual ServiceType ServiceType { get; set; } = null!;

    public virtual ICollection<SubcontractorOrder> SubcontractorOrders { get; set; } = new List<SubcontractorOrder>();
}
