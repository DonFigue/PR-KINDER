using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Freireland.Model
{
    public class Grades : BaseModel
    {
        public short Id { get; set; }
        public string nameGrade { get; set; }
        public string parallel { get; set; }
        public string level { get; set; }
        public decimal price { get; set; }

        public Grades(byte id, string namegrade, decimal price)
        {
            Id = id;
            nameGrade = namegrade;
            this.price = price;
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
        public Grades(short id, string namegrade, string parallel, string level, decimal price, byte status, DateTime registerDate,
            DateTime lastUpdate, short userID)
          : base(status, registerDate, lastUpdate, userID)

        {

            Id = id;
            nameGrade = namegrade;
            this.parallel = parallel;
            this.level = level;
            this.price = price;
        }
        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="namegrade"></param>
        public Grades(string namegrade, string parallel, string level, decimal price, short userID)
            : base(userID)
        {
            nameGrade = namegrade;
            this.parallel = parallel;
            this.level = level;
            this.price = price;
        }

        public Grades(short id, string name, string nivel, string parrarel, decimal price)
        {
            Id = id;
            nameGrade = name;
            level = nivel;
            parallel = parrarel;
            this.price = price;
        }

        public Grades()
        {
        }
    }
}
