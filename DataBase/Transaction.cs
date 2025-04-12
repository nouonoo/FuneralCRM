using System;
using System.Collections.Generic;

namespace FuneralCRM.DataBase;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public int TypeId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual TransactionType Type { get; set; } = null!;
}
