using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class LeadType
{
    public int LeadTypeId { get; set; }

    public string? Type { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
