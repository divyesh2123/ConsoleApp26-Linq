using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class FeesType
{
    public int Id { get; set; }

    public string FeesTypeName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
