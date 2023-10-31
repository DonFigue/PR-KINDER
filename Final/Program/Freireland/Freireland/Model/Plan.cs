using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Plan : BaseModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int StudentID { get; set; }

        public Plan()
        {

        }
        /// <summary>
        /// GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="startDate"></param>
        /// <param name="studentID"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="userID"></param>
        public Plan(int id, string description, DateTime startDate, int studentID, byte status, DateTime registerDate, DateTime lastUpdate, int userID) : base(status, registerDate, lastUpdate, userID)
        {
            Id = id;
            Description = description;
            StartDate = startDate;
            StudentID = studentID;
        }
        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="description"></param>
        /// <param name="startDate"></param>
        /// <param name="studentID"></param>
        /// <param name="userID"></param>
        public Plan(string description, DateTime startDate, int userID) : base(userID)
        {
            Description = description;
            StartDate = startDate;
        }
    }
}
