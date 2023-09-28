using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Implementation
{
    public class BaseImpl
    {
         string connectionString = @"Server=VALEROJAS\VALERIA;Database=dbInstitution;User Id = sa; Password=vale123;";
        //string connectionString = @"Server=PABLOAGREDA;Database=dbInstitution;User Id=sa;Password=valeria";
        //string connectionString = @"Server=localhost\SQLEXPRESS;Database=dbInstitution;Trusted_Connection=True;";

        internal string query = "";
        public SqlCommand CreateBasicCommand()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }

        //es uma sobrecarga
        public SqlCommand CreateBasicCommand(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            return command;

        }

        public List<SqlCommand> Create2BasicCommand(string sql1, string sql2)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command1 = new SqlCommand(sql1, connection);
            commands.Add(command1);

            SqlCommand command2 = new SqlCommand(sql2, connection);
            commands.Add(command2);

            return commands;

        }

        public string GetGenerateIDTable(string table)
        {
            query = "SELECT  IDENT_CURRENT('" + table + "') + IDENT_INCR('" + table + "')";
            SqlCommand command = CreateBasicCommand(query);

            try
            {
                command.Connection.Open();
                return command.ExecuteScalar().ToString();//etorna valor de la primera fila o algo asi
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                command.Connection.Close();
            }

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


        public int ExecutNeBasicCommand(List<SqlCommand> commands)
        {
            SqlTransaction t = null;

            SqlCommand command0 = commands[0];
            int n = 0;
            try
            {
                command0.Connection.Open();
                t = command0.Connection.BeginTransaction();//controlado todo con la conexion 

                //return command0.ExecuteNonQuery();
                foreach (SqlCommand item in commands)
                {
                    item.Transaction = t;
                    n += item.ExecuteNonQuery();
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
            return n;
        }




        public DataTable ExecuteDataTableCommand(SqlCommand command)
        {
            DataTable tabla = new DataTable();

            try
            {
                command.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tabla);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                command.Connection.Close();
            }
            return tabla;
        }
        public int ExecuteNBasicCommand(List<SqlCommand> commands)
        {
            SqlTransaction t = null;
            SqlCommand command0 = commands[0];
            int n = 0;
            try
            {
                command0.Connection.Open();
                t = command0.Connection.BeginTransaction();
                foreach (SqlCommand item in commands)
                {
                    item.Transaction = t;
                    n += item.ExecuteNonQuery();
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
            return n;
        }
        public DataTable ExecutableDataTableCommand(SqlCommand command)
        {
            DataTable table = new DataTable();
            try
            {
                command.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex) { throw ex; }
            finally { command.Connection.Close(); }
            return table;
        }

    }
}
