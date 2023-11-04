using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class PaymentMode
{
    public string? PaymentMode1 { get; set; }

    public int Id { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
