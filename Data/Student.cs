﻿using System;
using System.Collections.Generic;

namespace SchoolManagementApp.MVC.Data;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? DataOfBirth { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
