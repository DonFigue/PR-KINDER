using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Students : Person
    {
        #region Properties
        public string codStudent { get; set; }
        public string discapacity { get; set; }
        public int courseID { get; set; }
        public int tutorID { get; set; }
        #endregion


        public Students(short id, string codStudent, string firstName, string lastName, string secondLastName, string cI, char gender, string placeOfBirth, string address, DateTime birthdate, string discapacity, byte status, DateTime registerDate, DateTime lastUpdate, short userID, int courseID, int tutorID)
            : base(id, firstName, lastName, secondLastName, cI, gender, birthdate, address, placeOfBirth, status, registerDate, lastUpdate, userID)
        {
            this.codStudent = codStudent;
            this.discapacity = discapacity;
            this.courseID = courseID;
            this.tutorID = tutorID;
        }

        public Students(string codStudent, string discapacity, int courseID, int tutorID)
        {
            this.codStudent = codStudent;
            this.courseID = courseID;
            this.discapacity = discapacity;
            this.tutorID = tutorID;
        }


        public Students(string codStudent, string firstName, string lastName, string secondLastName, string cI, char gender, string placeOfBirth, string address, DateTime birthdate, string discapacity, short userID, int courseID, int tutorID)
            : base(firstName, lastName, secondLastName, cI, gender, birthdate, address, placeOfBirth, userID)
        {
            this.codStudent = codStudent;
            this.discapacity = discapacity;
            this.courseID = courseID;
            this.tutorID = tutorID;
        }

        public Students()
        {

        }
    }
}
