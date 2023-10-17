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
    public class UserImpl : BaseImpl, IUser
    {
        public int Delete(Users t)
        {
            query = @"UPDATE [User] SET status=0, userID=@userID, lastUpdate=CURRENT_TIMESTAMP WHERE id=@id";
            string query2 = @"UPDATE [User] SET userID=@userID, lastUpdate=CURRENT_TIMESTAMP WHERE id=@id";
            List<SqlCommand> commands = Create2BasicCommand(query, query2);
            commands[0].Parameters.AddWithValue("@userID", 1);
            commands[0].Parameters.AddWithValue("@id", t.Id);
            commands[1].Parameters.AddWithValue("@userID", 1);
            commands[1].Parameters.AddWithValue("@id", t.Id);
            try
            {
                return ExecuteNBasicCommand(commands);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Users Get(byte id)
        {
            Users u = null;
            query = @"SELECT id,name, password, firstName, lastName, secondLastName, phone,email , ci, 
                                 role, status,registerDate, ISNULL(lastUpdate, CURRENT_TIMESTAMP), userID
                        FROM [User]
                        WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable table = ExecuteDataTableCommand(command);

                if (table.Rows.Count > 0)
                {
                    char caracter = (table.Rows[0][5].ToString())[0];

                    u = new Users(byte.Parse(table.Rows[0][0].ToString()), table.Rows[0][1].ToString(),
                        table.Rows[0][2].ToString(), table.Rows[0][3].ToString(), table.Rows[0][4].ToString(),
                        table.Rows[0][5].ToString(), table.Rows[0][6].ToString(), table.Rows[0][7].ToString(),
                        table.Rows[0][8].ToString(), table.Rows[0][9].ToString(), byte.Parse(table.Rows[0][10].ToString()),
                        DateTime.Parse(table.Rows[0][11].ToString()),
                        DateTime.Parse(table.Rows[0][12].ToString()), short.Parse(table.Rows[0][13].ToString()));

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return u;
        }

        public int Insert(Users t)
        {
            query = @"INSERT INTO [User]( name, password,firstName,LastName,secondLastName,phone,
            gender,email, ci,role,userID)
                        VALUES( @name,HASHBYTES('MD5',@password),@firstName,@LastName,@secondLastName,@phone,
            @gender,@email,@ci,@role,@userID)";

            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@password", t.Password).SqlDbType = SqlDbType.VarChar;
            command.Parameters.AddWithValue("@firstName", t.FirstName);
            command.Parameters.AddWithValue("@LastName", t.LastName);
            command.Parameters.AddWithValue("@secondLastName", t.SecondlastName);

            command.Parameters.AddWithValue("@phone", t.Phone);
            command.Parameters.AddWithValue("@gender", t.Gender);

            command.Parameters.AddWithValue("@email", t.Email);
            command.Parameters.AddWithValue("@ci", t.Ci);
            command.Parameters.AddWithValue("@role", t.Role);
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
            query = @"SELECT id,name, firstname, lastName,secondLastName, ci
                        FROM [User]
                        WHERE status = 1";
            SqlCommand command = CreateBasicCommand(query);
            try 
            {
                return ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Select(string search)
        {
            query = @"SELECT id,name, firstname,lastName, secondLastName, ci
                        FROM [User]
                        WHERE status = 1 AND firstname LIKE '%' + @search + '%'";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@search", search);
            try 
            {
                return ExecuteDataTableCommand(command);
            }
            catch (Exception ex) 
            {
                throw ex; 
            }
        }
        public int Update(Users t)
        {
            query = @"UPDATE [User] SET ci = @ci,firstName=@firstName, lastName=@lastName, secondLastName=@secondLastName, phone=@phone,email=@email, name=@userName,password = HASHBYTES('MD5',@password) ,role=@role , lastUpdate=CURRENT_TIMESTAMP,userID= @userID
                WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@ci", t.Ci);
            command.Parameters.AddWithValue("@firstName", t.FirstName);
            command.Parameters.AddWithValue("@lastName", t.LastName);
            command.Parameters.AddWithValue("@secondLastName", t.SecondlastName);
            command.Parameters.AddWithValue("@phone", t.Phone);
            command.Parameters.AddWithValue("@email", t.Email);
            command.Parameters.AddWithValue("@userName", t.Name);
            command.Parameters.AddWithValue("@password", t.Password).SqlDbType = SqlDbType.VarChar;
            command.Parameters.AddWithValue("@role", t.Role);
            command.Parameters.AddWithValue("@userID", 1); //OJO SESIONES 
            command.Parameters.AddWithValue("@id", t.Id);

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
