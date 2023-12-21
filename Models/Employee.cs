using System;
using System.Collections.Generic;

namespace Labb3_School.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Pnumber { get; set; } = null!;

    public int FkpositionId { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual Position Fkposition { get; set; } = null!;
}
