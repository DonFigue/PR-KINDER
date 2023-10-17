using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Grade: BaseModel
    {
        public byte Id { get; set; }
        public string nameGrade { get; set; }

        public Grade(byte id, string namegrade)
        {
            Id = id;
            nameGrade = namegrade;
        }
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="namegrade"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        public Grade(byte id, string namegrade, byte status, DateTime registerDate,
            DateTime lastUpdate, short userID)
          : base(status, registerDate, lastUpdate, userID)

        {
        
            Id = id;
            nameGrade = namegrade;
        }
        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="namegrade"></param>
        public Grade(string namegrade) 
        {
            nameGrade = namegrade;
        }
    }
}
