using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class Education
{
    public int Id { get; set; }

    public string? EducationName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
