using BT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BT1.ViewModel
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        
    }

}