using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionADO.Model
{
    internal class Address
    {
        public int IdAddress { get; set; }
        public string AddressName { get; set; }
        public string Location { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Description { get; set; }
        public int ProvinceID { get; set; }

        public Address()
        {
            
        }

        public Address(int idAddress, string addressName, string location, decimal latitude, decimal longitude, string description, int provinceID)
        {
            IdAddress = idAddress;
            AddressName = addressName;
            Location = location;
            Latitude = latitude;
            Longitude = longitude;
            Description = description;
            ProvinceID = provinceID;
        }
    }
}
