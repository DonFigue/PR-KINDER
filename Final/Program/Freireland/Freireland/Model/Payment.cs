using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Model
{
    public class Payment : BaseModel
    {
        public int Id { get; set; }
        public DateTime DateOfPayment { get; set; }
        public decimal Amount { get; set; }
        public string PaymentState { get; set; }
        public bool Snack { get; set; }
        public int PlanID { get; set; }
        public int TutorID { get; set; }

        public Payment()
        {

        }

        public Payment(int id, DateTime dateOfPayment, decimal amount, string paymentState, bool snack, int planID, int tutorID, byte status, DateTime registerDate, DateTime lastUpdate, int userID) : base(status, registerDate, lastUpdate, userID)
        {
            Id = id;
            DateOfPayment = dateOfPayment;
            Amount = amount;
            PaymentState = paymentState;
            Snack = snack;
            PlanID = planID;
            TutorID = tutorID;
        }

        public Payment(DateTime dateOfPayment, decimal amount, string paymentState, bool snack, int userID) : base(userID)
        {
            DateOfPayment = dateOfPayment;
            Amount = amount;
            PaymentState = paymentState;
            Snack = snack;
        }
    }
}
