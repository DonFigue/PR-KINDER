using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionADO.Model
{
    internal class Course
    {
        public int IdCourse { get; set; }
        public string CourseName { get; set; }
        public int GradeID { get; set; }
        public int TeacherID { get; set; }


    }
}
