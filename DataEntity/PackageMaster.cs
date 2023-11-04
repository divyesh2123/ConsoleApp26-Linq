using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class PackageMaster
{
    public int Id { get; set; }

    public string? PackageTitle { get; set; }

    public string PackageTitleInternal { get; set; } = null!;

    public int? TotalDaysOfCourse { get; set; }

    public int? TotalAmout { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }
}
