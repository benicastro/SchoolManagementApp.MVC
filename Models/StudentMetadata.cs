using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

public class StudentMetadata
{
    // [StringLength(50)]
    // [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Date of Birth")]
    public DateOnly? DataOfBirth { get; set; }
}

[ModelMetadataType(typeof(StudentMetadata))]
public partial class Student{}