using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class SubjectMaster
{
    public int Id { get; set; }

    public string Subject { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
