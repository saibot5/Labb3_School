using System;
using System.Collections.Generic;

namespace Labb3_School.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int FkemployeeId { get; set; }

    public virtual Employee Fkemployee { get; set; } = null!;
}
