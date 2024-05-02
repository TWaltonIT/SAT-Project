using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace SAT.DATA.EF.Models
{
    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course
    {

    }

    [ModelMetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {

    }

    [ModelMetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass
    {

    }

    [ModelMetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }
}
