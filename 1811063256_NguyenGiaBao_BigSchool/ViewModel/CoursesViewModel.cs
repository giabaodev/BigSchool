using _1811063256_NguyenGiaBao_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1811063256_NguyenGiaBao_BigSchool.ViewModel
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}