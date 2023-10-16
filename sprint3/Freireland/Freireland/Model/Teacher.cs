using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Teacher : Person
    {
        public string Phone { get; set; }

        public Teacher()
        {
            
        }

        public Teacher(string phone,int id, string firstName, string lastName, string secondLastName, string cI, char gender, string placeOfBirth, string address, DateTime birthdate, byte status, DateTime registerDate, DateTime lastUpdate, short userID)
            : base(id, firstName, lastName, secondLastName, cI, gender, birthdate, address, placeOfBirth, status, registerDate, lastUpdate, userID)
        {
            Phone = phone;
        }
        /*
        public Teacher(string phone, string firstName, string lastName, string secondLastName, string cI, char gender, string placeOfBirth, string address, DateTime birthdate, byte status, DateTime registerDate, DateTime lastUpdate, short userID)
            : base(firstName, lastName, secondLastName, cI, gender, birthdate, address, placeOfBirth, status, registerDate, lastUpdate, userID)
        {
            Phone = phone;
        }
        */
    }
}
