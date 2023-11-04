using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class StateInfo
{
    public int Id { get; set; }

    public int? CountryId { get; set; }

    public string? StateName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }
}
