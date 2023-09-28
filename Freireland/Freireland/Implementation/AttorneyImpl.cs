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
    public class AttorneyImpl : BaseImpl, IAttorney
    {
        public int Delete(Attorney t)
        {
            query = @"UPDATE Attorney SET status=0, userID=@userID, lastUpdate=CURRENT_TIMESTAMP WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@userID", 1);
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

        public Attorney GET(int id)
        {
            Attorney t = null;
            query = @"SELECT id, firstName, lastName, secondLastName, ci, gender, address, occupation, status, registerDate, lastUpdate, userID
                    FROM Attorney
                    WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable dt = ExecutableDataTableCommand(command);
                if (dt.Rows.Count > 0)
                {
                    t = new Attorney(short.Parse(dt.Rows[0][0].ToString()), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(),char.Parse(dt.Rows[0][5].ToString()), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), byte.Parse(dt.Rows[0][8].ToString()), DateTime.Parse(dt.Rows[0][9].ToString()), DateTime.Parse(dt.Rows[0][10].ToString()), int.Parse(dt.Rows[0][11].ToString()));
                }
            }
            catch (Exception ex) { throw ex; }
            return t;
        }

        public int Insert(Attorney t)
        {
            query = @"INSERT INTO Attorney( firstName,lastName,secondLastName, ci,gender,address,occupation, userID)
                        VALUES( @firstName,@lastName,@secondLastName,@ci,@gender,@address,@occupation, @userID)";
           
            SqlCommand command = CreateBasicCommand(query);

            command.Parameters.AddWithValue("@firstName", t.FirstName);
            command.Parameters.AddWithValue("@lastName", t.LastName);
            command.Parameters.AddWithValue("@secondLastName", t.SecondLastName);
            command.Parameters.AddWithValue("@ci", t.CI);
            command.Parameters.AddWithValue("@gender", t.Gender);
            command.Parameters.AddWithValue("@address", t.Address);
            command.Parameters.AddWithValue("@occupation", t.Occupation);
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

        public DataTable Select(string search)
        {
            query = @"SELECT id, firstName, lastName, ci, occupation, lastUpdate
                    FROM Attorney
                    WHERE status=1 AND firstName LIKE '%' + '@search' + '%'";
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

        public DataTable Select()
        {
            query = @"SELECT id, firstName, lastName, ci, occupation, lastUpdate
                    FROM Attorney
                    WHERE status=1 AND firstname LIKE '%' + '' + '%'";
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

        public int Update(Attorney t)
        {
            query = @"UPDATE Attorney SET firstName=@firstName, lastName=@lastName, 
                    secondLastName=@secondLastName, ci=@ci, gender=@gender, address=@address, occupation=@occupation, 
                    lastUpdate=CURRENT_TIMESTAMP, userID=@userID WHERE id=@id";

            SqlCommand command = CreateBasicCommand(query);

            command.Parameters.AddWithValue("@id", t.Id);
            command.Parameters.AddWithValue("@firstName", t.FirstName);
            command.Parameters.AddWithValue("@lastName", t.LastName);
            command.Parameters.AddWithValue("@secondLastName", t.SecondLastName);
            command.Parameters.AddWithValue("@ci", t.CI);
            command.Parameters.AddWithValue("@gender", t.Gender);
            command.Parameters.AddWithValue("@address", t.Address);
            command.Parameters.AddWithValue("@occupation", t.Occupation);
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
