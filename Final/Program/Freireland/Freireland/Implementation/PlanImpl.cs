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
    public class PlanImpl : BaseImpl, IPlan
    {
        public int Delete(Plan t)
        {
            throw new NotImplementedException();
        }

        public Plan GET(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Plan t)
        {
            query = @"INSERT INTO [Plan] (Description, StartDate, StudentID, userID) VALUES(@Description, @StartDate, @StudentID, @userID)";

            SqlCommand command = CreateBasicCommand(query);
            short id = short.Parse(GetGenerateIDTable("Person"));

            command.Parameters.AddWithValue("@StartDate", t.StartDate);
            command.Parameters.AddWithValue("@Description", t.Description);
            command.Parameters.AddWithValue("@StudentID", id);
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

        public int Update(Plan t)
        {
            throw new NotImplementedException();
        }
    }
}
