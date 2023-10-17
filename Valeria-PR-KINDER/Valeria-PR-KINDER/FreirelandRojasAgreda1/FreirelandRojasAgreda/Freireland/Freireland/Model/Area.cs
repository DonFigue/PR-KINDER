using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Area: BaseModel
    {
        public byte Id { get; set; }
        public string areaName { get; set; }

        public Area(byte id, string areaName)
        {
            Id = id;
            this.areaName = areaName;
        }
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="areaName"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        public Area(byte id, string areaName, byte status, DateTime registerDate, DateTime lastUpdate, short userID)
          : base(status, registerDate, lastUpdate, userID)

        {
            Id = id;
            this.areaName = areaName;
        }

        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="areaName"></param>
        public Area(string areaName)
        {

            this.areaName = areaName;
        }
    }
}
