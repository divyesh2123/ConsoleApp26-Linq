using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class Account
{
    public string? AccountName { get; set; }

    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool IsActive { get; set; }
}
