using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionADO.Model
{
    internal class Town
    {
        public int IdTown { get; set; }
        public string TownName { get; set; }
        public int CountryID { get; set; }

        public Town()
        {
            
        }
        public Town(int idTown, string townName, int countryID)
        {
            IdTown = idTown;
            TownName = townName;
            CountryID = countryID;
        }


    }
}
