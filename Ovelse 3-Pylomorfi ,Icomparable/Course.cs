using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovelse_3_Pylomorfi__Icomparable
{
    internal class Course
    {
        public Subject CourseName;

        public Teacher Teacherinfo;
        
        public Course(Subject courseName, Teacher teacherinfo)
        {
            CourseName = courseName;
            Teacherinfo = teacherinfo;


        }
        
    
}
}
