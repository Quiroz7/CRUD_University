using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace proyectUniversity.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
