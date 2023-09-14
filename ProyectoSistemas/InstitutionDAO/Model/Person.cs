using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionDAO.Model
{
    public class Person
    {
        public int IdPerson { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CI { get; set; }
        public string Cellphone { get; set; }
        public int AddressID { get; set; }
        public int ProvinceID { get; set; }

        public Person()
        {

        }
        public Person(int idPerson, string firstName, string lastName, string cI, string cellphone, int addressID, int provinceID)
        {
            IdPerson = idPerson;
            FirstName = firstName;
            LastName = lastName;
            CI = cI;
            Cellphone = cellphone;
            AddressID = addressID;
            ProvinceID = provinceID;
        }

        public Person(string firstName, string lastName, string cI, string cellphone, int addressID, int provinceID)
        {
            FirstName = firstName;
            LastName = lastName;
            CI = cI;
            Cellphone = cellphone;
            AddressID = addressID;
            ProvinceID = provinceID;
        }
    }
}
