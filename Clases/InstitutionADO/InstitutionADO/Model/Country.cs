using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionADO.Model
{
    internal class Country
    {
        public int IdCountry { get; set; }
        public string CountryName { get; set; }

        public Country()
        {
            
        }

        public Country(int idCountry, string countryName)
        {
            IdCountry = idCountry;
            CountryName = countryName;
        }
    }
}
