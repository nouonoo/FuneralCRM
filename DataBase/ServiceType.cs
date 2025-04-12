using System;
using System.Collections.Generic;

namespace FuneralCRM.DataBase;

public partial class ServiceType
{
    public int ServiceTypeId { get; set; }

    public string ServiceName { get; set; } = null!;

    public virtual ICollection<Subcontractor> Subcontractors { get; set; } = new List<Subcontractor>();
}
