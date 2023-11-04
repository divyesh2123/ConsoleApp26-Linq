using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class Branch
{
    public int Id { get; set; }

    public string? BranchName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
