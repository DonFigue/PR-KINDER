using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Asignaturee:BaseModel
    {
        public byte Id { get; set; }

        public string NameAsignaturee { get; set; }
        public string CodeAsignaturee { get; set; }

        public byte AreaID { get; set; }

        public byte GradeID { get; set; }

        /// <summary>
        /// GET
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nameAsignature"></param>
        /// <param name="areaID"></param>
        /// <param name="status"></param>
        /// <param name="registerDate"></param>
        /// <param name="lastUpdate"></param>
        /// <param name="UserID"></param>
        public Asignaturee(byte id, string nameAsignature, string codeAsignature,
            byte areaID,byte gradeID, byte status, DateTime registerDate,
            DateTime lastUpdate, short UserID)
            :base(status,
                registerDate,lastUpdate,UserID)
        { 
            Id = id;
            NameAsignaturee = nameAsignature;
            CodeAsignaturee = codeAsignature;
            AreaID = areaID;
            GradeID = gradeID;
            //Area = area;
        
        }
        /// <summary>
        /// INSERT
        /// </summary>
        /// <param name="nameAsignature"></param>
        /// <param name="areaID"></param>
        public Asignaturee(string nameAsignature, byte areaID,byte gradeID, string codeAsignature)
        {
            NameAsignaturee = nameAsignature;
            CodeAsignaturee = codeAsignature;
            AreaID = areaID;
            GradeID = gradeID;

        }

        public Asignaturee() { }

    }

}
