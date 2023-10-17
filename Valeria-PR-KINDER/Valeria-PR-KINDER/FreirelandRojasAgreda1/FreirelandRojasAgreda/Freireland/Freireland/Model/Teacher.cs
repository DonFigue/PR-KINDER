using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Teachers: Person
    {
        public string phone { get; set; }

        public Teachers(string phone)
        {
            this.phone = phone;
        }

        public Teachers(short id, string firstName, string lastName, string secondLastName, string phone, string cI, char gender, string placeOfBirth, string address, DateTime birthdate, string discapacity, byte status, DateTime registerDate, DateTime lastUpdate, short userID)
           : base(id, firstName, lastName, secondLastName, cI, gender, birthdate, address, placeOfBirth, status, registerDate, lastUpdate, userID)
        {
            this.phone = phone;
        }

        public Teachers( string firstName, string lastName, string secondLastName, string phone, string cI, char gender, string placeOfBirth, string address, DateTime birthdate, short userID)
            : base(firstName, lastName, secondLastName, cI, gender, birthdate, address, placeOfBirth, userID)
        {
            this.phone = phone;

        }
    }
}
