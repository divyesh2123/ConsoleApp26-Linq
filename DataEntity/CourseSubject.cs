using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class CourseSubject
{
    public int Id { get; set; }

    public int? CourseId { get; set; }

    public int? SubjectId { get; set; }
}
