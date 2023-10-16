using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Tutor : Person
    {
        public string Profession { get; set; }
        public string WorkPlace { get; set; }
        public string Email { get; set; }
        public string NIT { get; set; }
        public string Cellphone { get; set; }
        public string BusinessName { get; set; }

        public Tutor()
        {
            
        }
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="profession"></param>
        /// <param name="workPlace"></param>
        /// <param name="email"></param>
        /// <param name="nIT"></param>
        /// <param name="cellphone"></param>
        /// <param name="businessName"></param>
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
        public Tutor(string profession, string workPlace, string email, string nIT, string cellphone, string businessName, int id, string firstName, string lastName, string secondLastName, string cI, char gender, DateTime birthdate, string address, string placeOfBirth, byte status, DateTime registerDate, DateTime lastUpdate, int userID) : base(id, firstName, lastName, secondLastName, cI, gender, birthdate, address, placeOfBirth,status, registerDate, lastUpdate, userID)
        {
            Profession = profession;
            WorkPlace = workPlace;
            Email = email;
            NIT = nIT;
            Cellphone = cellphone;
            BusinessName = businessName;
        }
        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="profession"></param>
        /// <param name="workPlace"></param>
        /// <param name="email"></param>
        /// <param name="nIT"></param>
        /// <param name="cellphone"></param>
        /// <param name="businessName"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="secondLastName"></param>
        /// <param name="cI"></param>
        /// <param name="gender"></param>
        /// <param name="birthdate"></param>
        /// <param name="address"></param>
        /// <param name="placeOfBirth"></param>
        /// <param name="userID"></param>
        public Tutor(string profession, string workPlace, string email, string nIT, string cellphone, string businessName, int id, string firstName, string lastName, string secondLastName, string cI, char gender, DateTime birthdate, string address, string placeOfBirth, int userID) : base(id, firstName, lastName, secondLastName, cI, gender, birthdate, address, placeOfBirth, userID)
        {
            Profession = profession;
            WorkPlace = workPlace;
            Email = email;
            NIT = nIT;
            Cellphone = cellphone;
            BusinessName = businessName;
        }
    }
}
