using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class Country
{
    public int Id { get; set; }

    public string Country1 { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }
}
