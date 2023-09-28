using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionADO.Model
{
    internal class Payment
    {
        public int IdPayment { get; set; }
        public DateTime DateOfPayment { get; set; }
        public decimal Amount { get; set; }
        public string NIT { get; set; }
        public string BussinessName { get; set; }
        public bool Snack { get; set; }
        public int PlanID { get; set; }
        public string PaymentState { get; set; }
        public Payment()
        {
            
        }

        public Payment(int idPayment, DateTime dateOfPayment, decimal amount, string nIT, string bussinessName, bool snack, int planID, string paymentState)
        {
            IdPayment = idPayment;
            DateOfPayment = dateOfPayment;
            Amount = amount;
            NIT = nIT;
            BussinessName = bussinessName;
            Snack = snack;
            PlanID = planID;
            PaymentState = paymentState;
        }
    }
}
