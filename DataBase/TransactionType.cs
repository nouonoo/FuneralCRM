using System;
using System.Collections.Generic;

namespace FuneralCRM.DataBase;

public partial class TransactionType
{
    public int TypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
