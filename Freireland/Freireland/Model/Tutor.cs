using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Tutor:Person
    {
        public int IdTutor { get; set; }
        public string JobOccupation { get; set; }
        public string GraduateLevel { get; set; }

        public Tutor(string jobOccupation, string graduateLevel)
        {
            JobOccupation = jobOccupation;
            GraduateLevel = graduateLevel;
        }

        public Tutor(int idPerson, string firstName, string lastName, string cI, string cellphone, int addressID, int provinceID, int idTutor, string jobOccupation, string graduateLevel)
            : base(idPerson, firstName, lastName, cI, cellphone, addressID, provinceID)
        {
            IdTutor = idTutor;
            JobOccupation = jobOccupation;
            GraduateLevel = graduateLevel;
        }

        public Tutor(string firstName, string lastName, string cI, string cellphone, int addressID, int provinceID, int idTutor, string jobOccupation, string graduateLevel)
            : base(firstName, lastName, cI, cellphone, addressID, provinceID)
        {
            IdTutor = idTutor;
            JobOccupation = jobOccupation;
            GraduateLevel = graduateLevel;
        }

        public Tutor()
        {
        }
    }
}
