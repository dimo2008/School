using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class Student
    {
       public string Name { get; set; }
       public string Gender { get; set; }
       public string Phone { get; set; }
       public string Mobile { get; set; }
       public string Email { get; set; }
       public string Address { get; set; }
       public float GPA { get; set; }
       public DateTime BirthDate { get; set; }
    }
}