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
        public short GetLastPersonID()
        {
            string connectionString = "tu_cadena_de_conexión"; // Reemplaza con tu cadena de conexión.
            string query = "SELECT IDENT_CURRENT('Person')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt16(result);
                    }
                }
            }

            // En caso de que no se haya encontrado ningún registro en la tabla "Person" o se haya producido un error.
            return -1; // Puedes manejar este valor predeterminado de acuerdo a tus necesidades.
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
