using System;
using System.Collections.Generic;

namespace ConsoleApp26.DataEntity;

public partial class EmployeeInfo
{
    public int EmployeeId { get; set; }

    public int? EmployeeTypeId { get; set; }

    public string? EmployeeCode { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public string WhatupNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime Dob { get; set; }

    public DateTime Doj { get; set; }

    public int? DesignationId { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public string? ZipCode { get; set; }

    public int? BranchId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }
}
