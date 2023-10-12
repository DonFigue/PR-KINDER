using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Person : BaseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string CI { get; set; }
        public char Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string PlaceOfBirth { get; set; }

        public Person()
        {
            
        }

        /// <summary>
        /// GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="secondLastName"></param>
        /// <param name="cI"></param>
        /// <param name="gender"></param>
        /// <param name="birthdate"></param>
        /// <param name="address"></param>
        /// <param name="placeOfBirth"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        public Person(int id, string firstName, string lastName, string secondLastName, string cI, char gender, DateTime birthdate, string address, string placeOfBirth, byte status, DateTime registerDate, DateTime lastUpdate, int userID) : base(status, registerDate, lastUpdate, userID)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SecondLastName = secondLastName;
            CI = cI;
            Gender = gender;
            Birthdate = birthdate;
            Address = address;
            PlaceOfBirth = placeOfBirth;
        }

        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="secondLastName"></param>
        /// <param name="cI"></param>
        /// <param name="gender"></param>
        /// <param name="birthdate"></param>
        /// <param name="address"></param>
        /// <param name="placeOfBirth"></param>
        /// <param name="userID"></param>
        public Person(string firstName, string lastName, string secondLastName, string cI, char gender, DateTime birthdate, string address, string placeOfBirth, int userID) : base(userID)
        {
            FirstName = firstName;
            LastName = lastName;
            SecondLastName = secondLastName;
            CI = cI;
            Gender = gender;
            Birthdate = birthdate;
            Address = address;
            PlaceOfBirth = placeOfBirth;
        }

        public Person(int id, string firstName, string lastName, string secondLastName, string cI, char gender, DateTime birthdate, string address, string placeOfBirth, int userID) : base(userID)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SecondLastName = secondLastName;
            CI = cI;
            Gender = gender;
            Birthdate = birthdate;
            Address = address;
            PlaceOfBirth = placeOfBirth;
        }
    }
}
