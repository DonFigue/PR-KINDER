using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionADO.Model
{
    internal class Student : Person
    {
        public int CourseID { get; set; }
        public int TutorID { get; set; }


        public Student()
        {
            
        }
    }
}
