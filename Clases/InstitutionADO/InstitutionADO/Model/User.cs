using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionADO.Model
{
    internal class User : Person
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }

        public User()
        {
            
        }
    }
}
