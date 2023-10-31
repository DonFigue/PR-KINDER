using Freireland.Interfaces;
using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
            query = @"SELECT Y.id, Y.PaymentState, Y.Amount, Y.DateOfPayment, CONCAT(PS.firstName,' ',PS.lastName,' ',PS.secondLastName) AS Student, T.nit, T.businessName, Y.registerDate, Y.lastUpdate, Y.PlanID, Y.userID
                    FROM Payment Y
                    INNER JOIN Tutor T ON T.id=Y.TutorID
                    INNER JOIN [Plan] P ON P.id=Y.PlanID
                    INNER JOIN Student S ON S.id=P.StudentId
                    INNER JOIN Person PS ON PS.id=S.id
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
