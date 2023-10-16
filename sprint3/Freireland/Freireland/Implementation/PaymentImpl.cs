using Freireland.Interfaces;
using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Implementation
{
    public class PaymentImpl : BaseImpl, IPayment
    {
        public int Delete(Payment t)
        {
            throw new NotImplementedException();
        }

        public Payment GET(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Payment t)
        {
            query = @"INSERT INTO Payment (DateOfPayment, Amount, PaymentState, Snack, TutorID, PlanID, userID) VALUES (@DateOfPayment, @Amount, @PaymentState, @Snack, @TutorID, @PlanID, @userID)";

            SqlCommand command = CreateBasicCommand(query);
            int id = short.Parse(GetGenerateIDTable("[Plan]"));

            command.Parameters.AddWithValue("@StartDate", t.DateOfPayment);
            command.Parameters.AddWithValue("@Description", t.Amount);
            command.Parameters.AddWithValue("@Description", t.PaymentState);
            command.Parameters.AddWithValue("@Description", t.Snack);
            command.Parameters.AddWithValue("@Description", t.TutorID);
            command.Parameters.AddWithValue("@Description", id);
            command.Parameters.AddWithValue("@userID", 1);


            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Select()
        {
            throw new NotImplementedException();
        }
        public DataTable Select(int id)
        {
            query = @"SELECT T.id, T.PaymentState, T.Amount, T.DateOfPayment, U.businessName, U.nit, T.registerDate, T.lastUpdate
                    FROM [Plan] P
                    INNER JOIN Payment T ON T.PlanID=P.id
                    INNER JOIN Tutor U ON U.id=T.TutorID
                    WHERE P.StudentID = @id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try { return ExecuteDataTableCommand(command); }
            catch (Exception ex) { throw ex; }
        }

        public int Update(Payment t)
        {
            throw new NotImplementedException();
        }

        public int Paid(int id)
        {
            query = @"UPDATE Payment SET PaymentState='PAGADA', lastUpdate=CURRENT_TIMESTAMP, userID=@userID WHERE id=@id";

            SqlCommand command = CreateBasicCommand(query);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@userID", 1);

            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int UnPaid(int id)
        {
            query = @"UPDATE Payment SET PaymentState='NO PAGADA', lastUpdate=CURRENT_TIMESTAMP, userID=@userID WHERE id=@id";

            SqlCommand command = CreateBasicCommand(query);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@userID", 1);

            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
