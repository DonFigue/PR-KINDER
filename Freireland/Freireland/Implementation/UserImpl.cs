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
            throw new NotImplementedException();
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

        public DataTable Login(string userName, string password)
        {
            query = @"SELECT id,name,password,firstLogin,role
                      FROM [User]
                      WHERE name = @userName AND password = HASHBYTES('MD5',@password)";

            SqlCommand command = CreateBasicCommand(query);

            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", password).SqlDbType = SqlDbType.VarChar;

            try
            {
                return ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }



            throw new NotImplementedException();
        }

        public int updatePasswordChange(short id, string userName, string password, string oldPassword)
        {
            query = @"UPDATE [User] SET firstLogin = 1, password = HASHBYTES('MD5',@password)
                    WHERE name = @userName AND id = @id AND password =  HASHBYTES('MD5',@oldPassword)";

            SqlCommand command = CreateBasicCommand(query);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@oldPassword", oldPassword).SqlDbType = SqlDbType.VarChar;
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", password).SqlDbType = SqlDbType.VarChar;

            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int UpdateRecoverPassword(string userName, string password)
        {
            query = @"UPDATE [User] SET firstLogin = 0, password = HASHBYTES('MD5',@password)
                    WHERE name = @userName";

            SqlCommand command = CreateBasicCommand(query);

            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", password).SqlDbType = SqlDbType.VarChar;

            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            throw new NotImplementedException();
        }

        public int Update(Users t)
        {
            throw new NotImplementedException();
        }
    }
}
