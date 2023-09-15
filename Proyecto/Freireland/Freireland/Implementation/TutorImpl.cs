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
    public class TutorImpl : BaseImpl, ITutor
    {
        public int Delete(Tutor t)
        {
            query = @"UPDATE Person SET status=0, userID=@userID, lastUpdate=CURRENT_TIMESTAMP WHERE id=@id";
            string query2 = @"UPDATE Tutor SET status=0, userID=@userID, lastUpdate=CURRENT_TIMESTAMP WHERE id=@id";
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

        public Tutor GET(int id)
        {
            Tutor t = null;
            query = @"SELECT T.profession, T.workPlace, T.email, T.nit, T.cellphone, T.businessName, P.firstname, P.lastName, P.secondLastName, P.ci, P.gender, P.birthdate, P.address, P.placeOfBirth
                    FROM Person P
                    INNER JOIN Tutor T ON T.id=P.id
                    WHERE P.id=@id;";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable dt = ExecutableDataTableCommand(command);
                if (dt.Rows.Count > 0)
                {
                    t = new Tutor(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), id, dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString(), char.Parse(dt.Rows[0][10].ToString()), DateTime.Parse(dt.Rows[0][11].ToString()), dt.Rows[0][12].ToString(), dt.Rows[0][13].ToString(), 1);
                }
            }
            catch (Exception ex) { throw ex; }
            return t;
        }

        public int Insert(Tutor t)
        {
            query = @"INSERT INTO Person(firstname, lastName, secondLastName, ci, gender, address,birthdate,placeOfBirth, userID) 
                    VALUES (@firstname, @lastName, @secondLastName, @ci, @gender, @address, @birthdate, @placeOfBirth, @userID)";

            string query2 = @"INSERT INTO Tutor(id,cellphone, workPlace, email, profession, nit, businessName, userID)
                    VALUES (@id, @cellphone, @workPlace, @email, @profession, @nit, @businessName, @userID);";

            List<SqlCommand> commands = Create2BasicCommand(query, query2);
            commands[0].Parameters.AddWithValue("@firstName", t.FirstName);
            commands[0].Parameters.AddWithValue("@lastName", t.LastName);
            commands[0].Parameters.AddWithValue("@secondLastName", t.SecondLastName);
            commands[0].Parameters.AddWithValue("@ci", t.CI);
            commands[0].Parameters.AddWithValue("@gender", t.Gender);
            commands[0].Parameters.AddWithValue("@address", t.Address);
            commands[0].Parameters.AddWithValue("@birthdate", t.Birthdate);
            commands[0].Parameters.AddWithValue("@placeOfBirth", t.Address);
            commands[0].Parameters.AddWithValue("@userID", 1);

            int id = int.Parse(GetGenerateIDTable("Person"));

            commands[1].Parameters.AddWithValue("@id", id);
            commands[1].Parameters.AddWithValue("@cellphone", t.Cellphone);
            commands[1].Parameters.AddWithValue("@workPlace", t.WorkPlace);
            commands[1].Parameters.AddWithValue("@email", t.Email);
            commands[1].Parameters.AddWithValue("@profession", t.Profession);
            commands[1].Parameters.AddWithValue("@nit", t.NIT);
            commands[1].Parameters.AddWithValue("@businessName", t.BusinessName);
            commands[1].Parameters.AddWithValue("@userID", 1);


            try
            {
                return ExecuteNBasicCommand(commands);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Select()
        {
            query = @"SELECT P.id,CONCAT(P.firstname, ' ',P.lastName,' ', P.secondLastName), P.ci, T.email, T.cellphone, T.workPlace
                        FROM Person P
                        INNER JOIN Tutor T ON T.id = P.id
                        WHERE P.status = 1;";
            SqlCommand command = CreateBasicCommand(query);
            try { return ExecutableDataTableCommand(command); }
            catch (Exception ex) { throw ex; }
        }
        public DataTable Select(string search)
        {
            query = @"SELECT P.id,CONCAT(P.firstname, ' ',P.lastName,' ', P.secondLastName), P.ci, T.email, T.cellphone, T.workPlace
                        FROM Person P
                        INNER JOIN Tutor T ON T.id = P.id
                        WHERE P.status = 1 AND P.firstname LIKE '%@search%'";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@search", search);
            try { return ExecutableDataTableCommand(command); }
            catch (Exception ex) { throw ex; }
        }
        public int Update(Tutor t)
        {
            query = @"UPDATE Person SET firstname=@firstname, lastName=@lastName, secondLastName=@secondLastName, ci=@ci, gender=@gender, address=@address, birthdate=@birthdate, placeOfBirth=@placeOfBirth, lastUpdate=CURRENT_TIMESTAMP, userID=1 WHERE id=@id";
            string query2 = @"UPDATE Tutor SET cellphone=@cellphone, workPlace=@workPlace, email=@email, profession=@profession, nit=@nit, businessName=@businessName, lastUpdate=CURRENT_TIMESTAMP, userID=1 WHERE id=@id";

            List<SqlCommand> commands = Create2BasicCommand(query, query2);
            commands[0].Parameters.AddWithValue("@id", t.Id);
            commands[0].Parameters.AddWithValue("@firstName", t.FirstName);
            commands[0].Parameters.AddWithValue("@lastName", t.LastName);
            commands[0].Parameters.AddWithValue("@secondLastName", t.SecondLastName);
            commands[0].Parameters.AddWithValue("@ci", t.CI);
            commands[0].Parameters.AddWithValue("@gender", t.Gender);
            commands[0].Parameters.AddWithValue("@address", t.Address);
            commands[0].Parameters.AddWithValue("@birthdate", t.Birthdate);
            commands[0].Parameters.AddWithValue("@placeOfBirth", t.Address);
            commands[0].Parameters.AddWithValue("@userID", 1);

            commands[1].Parameters.AddWithValue("@id", t.Id);
            commands[1].Parameters.AddWithValue("@cellphone", t.Cellphone);
            commands[1].Parameters.AddWithValue("@workPlace", t.WorkPlace);
            commands[1].Parameters.AddWithValue("@email", t.Email);
            commands[1].Parameters.AddWithValue("@profession", t.Profession);
            commands[1].Parameters.AddWithValue("@nit", t.NIT);
            commands[1].Parameters.AddWithValue("@businessName", t.BusinessName);
            commands[1].Parameters.AddWithValue("@userID", 1);
            try
            {
                return ExecuteNBasicCommand(commands);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
