using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Attorney : BaseModel
    {
        public short Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public string CI { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }

        public Attorney()
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
        /// <param name="address"></param>
        /// <param name="occupation"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        public Attorney(short id, string firstName, string lastName, string secondLastName, string cI, char gender, string address, string occupation, byte status, DateTime registerDate, DateTime lastUpdate, int userID) : base(status,registerDate,lastUpdate,userID)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SecondLastName = secondLastName;
            CI = cI;
            Gender = gender;
            Address = address;
            Occupation = occupation;
        }
        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="secondLastName"></param>
        /// <param name="cI"></param>
        /// <param name="gender"></param>
        /// <param name="address"></param>
        /// <param name="occupation"></param>
        public Attorney(string firstName, string lastName, string secondLastName, string cI, char gender, string address, string occupation, int userID) : base(userID) 
        {
            FirstName = firstName;
            LastName = lastName;
            SecondLastName = secondLastName;
            CI = cI;
            Gender = gender;
            Address = address;
            Occupation = occupation;
        }
    }
}
