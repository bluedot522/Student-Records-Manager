using System;
using System.Collections.Generic;
using System.Text;

namespace Module7JsonStudentRecords
{
    public class Student
    {
        public int StudentId { get; set;}
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ProgramName { get; set; } = string.Empty;
        public decimal GPA {get; set;}
    }
}
