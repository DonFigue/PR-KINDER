using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionDAO.Implementation
{
    public class BaseImpl
    {
        string connectionString = @"Server=LAPTOP-76I2AD0R\SQLEXPRESS;Database=dbInstitution;User Id=sa;Password=nuttertools;";

        internal string query;

        public SqlCommand CreateBasicCommand()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }

        public string GetGenereteIDTable(string table)
        {
            query = @"SELECT IDENT_CURRENT('" + table + "') + IDENT_INCR('" + table + "')";
            SqlCommand command = CreateBasicCommand(query);
            try
            {
                command.Connection.Open();
                return command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public SqlCommand CreateBasicCommand(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            return command;
        }


        public List<SqlCommand> CreateBasic2Command(string sql, string sql1)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            commands.Add(command);
            SqlCommand command1 = new SqlCommand(sql1, connection);
            commands.Add(command1);
            return commands;
        }

        public int ExecuteBasicCommand(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public void ExecuteNBasicCommand(List<SqlCommand> commands)
        {
            SqlCommand command0 = commands[0];
            SqlTransaction t = null;
            try
            {
                command0.Connection.Open();
                t = command0.Connection.BeginTransaction();
                foreach (SqlCommand item in commands)
                {
                    item.Transaction = t;
                    item.ExecuteNonQuery();
                }

                t.Commit();
            }
            catch (Exception ex)
            {
                t.Rollback();
                throw ex;
            }
            finally
            {
                command0.Connection.Close();
            }
        }

        public DataTable ExecuteDataTableCommand(SqlCommand command)
        {
            DataTable table = new DataTable();
            try
            {
                command.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
            return table;
        }
    }
}
