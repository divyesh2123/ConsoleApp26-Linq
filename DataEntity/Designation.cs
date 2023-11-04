using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class Designation
{
    public int Id { get; set; }

    public string? DesignationName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }
}
