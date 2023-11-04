using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class LeadSource
{
    public string? Source { get; set; }

    public int Id { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
