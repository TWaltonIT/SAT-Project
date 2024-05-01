using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF.Models
{
    public class CourseMetadata
    {
        
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Course")]
        [StringLength(50)]
        public string CourseName { get; set; } = null!;

        [Required]
        [Display(Name = "Description")]
        [StringLength(500)]
        [UIHint("MultilineText")]
        [DataType(DataType.MultilineText)]
        public string CourseDescription { get; set; } = null!;

        [Required]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        [StringLength(250)]
        public string? Curriculum { get; set; }

        [StringLength(500)]
        [UIHint("MultilineText")]
        [DataType(DataType.MultilineText)]
        public string? Notes { get; set; }

        [Required]
        [Display(Name = "Active?")]
        public bool IsActive { get; set; }
    }

    public class EnrollmentMetadata
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }

        [Required]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Range(typeof(DateTime), "01/01/2024", "06/01/2024", ErrorMessage = "You can only enroll between Jan 1 2024 and June 1 2024")]
        public DateTime EnrollmentDate { get; set; }

    }

    public class ScheduledClassMetadata
    {
        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Instructor")]
        [StringLength(40)]
        public string InstructorName { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string Location { get; set; } = null!;

        [Display(Name = "Class Status")]
        public int SCSID { get; set; }
    }

    public class StudentMetadata
    {
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(20)]
        public string FirstName { get; set; } = null!;

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(20)]
        public string LastName { get; set; } = null!;

        [StringLength(15)]
        public string? Major {  get; set; }

        [StringLength(50)]
        public string? Address { get; set; }

        [StringLength(25)]
        public string? City { get; set; }

        [StringLength(2)]
        public string? State { get; set; }

        [StringLength(10)]
        public string? Zip {  get; set; }

        [StringLength(13)]
        public string? Phone {  get; set; }

        [Required]
        [StringLength(60)]
        public string Email { get; set; } = null!;

        [Display(Name = "Photo")]
        [StringLength(100)]
        public string? PhotoUrl { get; set; }

        public int SSID { get; set; }
    }

}
