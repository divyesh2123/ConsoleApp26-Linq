using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class CourseBranchInfo
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public int? BranchId { get; set; }

    public int? BranchSalesPrice { get; set; }
}
