using System;
using System.Collections.Generic;

namespace FuneralCRM.DataBase;

public partial class Order
{
    public int OrderId { get; set; }

    public int ClientId { get; set; }

    public DateTime? OrderDate { get; set; }

    public int StatusId { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual OrderStatus Status { get; set; } = null!;

    public virtual ICollection<SubcontractorOrder> SubcontractorOrders { get; set; } = new List<SubcontractorOrder>();
}
