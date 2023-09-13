using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionADO.Model
{
    internal class PaymentPlan
    {
        public int IdPlan { get; set; }
        public int StudentID { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; }

        public PaymentPlan()
        {
            
        }


    }
}
