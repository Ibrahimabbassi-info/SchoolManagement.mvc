using System;
using System.Collections.Generic;

namespace SchoolManagement.mvc.Data;

public partial class Student
{
    public int StudentId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public DateTime? EnrollmentDate { get; set; }
}
