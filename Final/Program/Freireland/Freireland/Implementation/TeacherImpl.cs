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
    public class TeacherImpl : BaseImpl, ITeacher
    {
        public int Delete(Teachers t)
        {
            query = @"UPDATE Person SET status=0, lastUpdate=CURRENT_TIMESTAMP, userID=1 WHERE id=@id";
            string query2 = @"UPDATE Teacher SET status=0, lastUpdate=CURRENT_TIMESTAMP, userID=1 WHERE id=@id";

            List<SqlCommand> commands = Create2BasicCommand(query, query2);
            commands[0].Parameters.AddWithValue("@id", t.Id);
            commands[0].Parameters.AddWithValue("@userID", 1);

            commands[1].Parameters.AddWithValue("@id", t.Id);
            commands[1].Parameters.AddWithValue("@userID", 1);

            try
            {
                return ExecutNeBasicCommand(commands);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Teachers Get(short id)
        {
            Teachers s = null;
            query = @"SELECT P.id, P.firstName, P.lastName , P.secondLastName, P.ci, P.gender, P.placeOfBirth,P.address, P.birthDate, S.phone, S.registerDate, S.status,
                            ISNULL(S.lastUpdate, CURRENT_TIMESTAMP), S.userID
                        FROM Teacher S
                        INNER JOIN Person P ON S.id=P.id
                        WHERE S.id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable table = ExecuteDataTableCommand(command);
                if (table.Rows.Count > 0)
                {

                    s = new Teachers(
                    id: short.Parse(table.Rows[0]["id"].ToString()),
                    firstName: table.Rows[0]["firstname"].ToString(),
                    lastName: table.Rows[0]["lastName"].ToString(),
                    secondLastName: table.Rows[0]["secondLastName"].ToString(),
                    cI: table.Rows[0]["ci"].ToString(),
                    gender: char.Parse(table.Rows[0]["gender"].ToString()),
                    placeOfBirth: table.Rows[0]["placeOfBirth"].ToString(),
                    address: table.Rows[0]["address"].ToString(),
                    birthdate: DateTime.Parse(table.Rows[0]["birthDate"].ToString()),
                    phone: table.Rows[0]["phone"].ToString(),

                    status: byte.Parse(table.Rows[0]["status"].ToString()),

                    registerDate: DateTime.Parse(table.Rows[0]["registerDate"].ToString()),
                    lastUpdate: DateTime.Parse(table.Rows[0][8].ToString()),
                    userID: short.Parse(table.Rows[0]["userID"].ToString())
                    );
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return s;
            throw new NotImplementedException();
        }

        public int Insert(Teachers t)
        {
            query = @"INSERT INTO Person( firstName,lastName,secondLastName, ci,gender,address,birthDate,placeOfBirth, userID)
                    VALUES( @firstName,@lastName,@secondLastName,@ci,@gender,@address,@birthDate,@placeOfBirth, @userID)";
            string query2 = @"INSERT INTO Teacher(id, phone, userID)
			        VALUES(@id,@phone, @userID)";

            List<SqlCommand> commands = Create2BasicCommand(query, query2);
            commands[0].Parameters.AddWithValue("@firstName", t.FirstName);
            commands[0].Parameters.AddWithValue("@lastName", t.LastName);
            commands[0].Parameters.AddWithValue("@secondLastName", t.SecondLastName);
            commands[0].Parameters.AddWithValue("@ci", t.CI);
            commands[0].Parameters.AddWithValue("@gender", t.Gender);
            commands[0].Parameters.AddWithValue("@address", t.Address);
            commands[0].Parameters.AddWithValue("@birthDate", t.Birthdate);
            commands[0].Parameters.AddWithValue("@placeOfBirth", t.PlaceOfBirth);
            commands[0].Parameters.AddWithValue("@userID", 1);

            short id = short.Parse(GetGenerateIDTable("Person"));

            commands[1].Parameters.AddWithValue("@id", id);
            commands[1].Parameters.AddWithValue("@phone", t.phone);
            commands[1].Parameters.AddWithValue("@userID", 1);

            try
            {
                return ExecutNeBasicCommand(commands);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable Select()
        {
            query = @"SELECT P.id, P.firstName, P.lastName , P.secondLastName, P.ci, P.placeOfBirth,P.address, P.birthDate, S.phone, S.userID
                    FROM Teacher S
                    INNER JOIN Person P ON S.id=P.id
                    WHERE S.status = 1";
            SqlCommand command = CreateBasicCommand(query);
            try { return ExecuteDataTableCommand(command); }
            catch (Exception ex) { throw ex; }
        }
        public DataTable Select(string search)
        {
            query = @"SELECT P.id, P.firstName, P.lastName , P.secondLastName, P.ci, P.placeOfBirth,P.address, P.birthDate, S.phone, S.userID
                    FROM Teacher S
                    INNER JOIN Person P ON S.id=P.id
                    WHERE S.status = 1 AND P.firstname LIKE '%' + @search + '%'";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@search", search);
            try { return ExecuteDataTableCommand(command); }
            catch (Exception ex) { throw ex; }
        }
        public int Update(Teachers t)
        {
            query = @"UPDATE Person SET firstname=@firstname, lastName=@lastName, secondLastName=@secondLastName,
            ci=@ci, gender=@gender, address=@address, birthdate=@birthdate, placeOfBirth=@placeOfBirth, lastUpdate=CURRENT_TIMESTAMP, userID=1 WHERE id=@id";
            string query2 = @"UPDATE Teacher SET phone=@phone, lastUpdate=CURRENT_TIMESTAMP, userID=1 WHERE id=@id";

            List<SqlCommand> commands = Create2BasicCommand(query, query2);
            commands[0].Parameters.AddWithValue("@id", t.Id);
            commands[0].Parameters.AddWithValue("@firstName", t.FirstName);
            commands[0].Parameters.AddWithValue("@lastName", t.LastName);
            commands[0].Parameters.AddWithValue("@secondLastName", t.SecondLastName);
            commands[0].Parameters.AddWithValue("@ci", t.CI);
            commands[0].Parameters.AddWithValue("@gender", t.Gender);
            commands[0].Parameters.AddWithValue("@address", t.Address);
            commands[0].Parameters.AddWithValue("@birthDate", t.Birthdate);
            commands[0].Parameters.AddWithValue("@placeOfBirth", t.PlaceOfBirth);
            commands[0].Parameters.AddWithValue("@userID", 1);

            commands[1].Parameters.AddWithValue("@id", t.Id);
            commands[1].Parameters.AddWithValue("@phone", t.phone);
            commands[1].Parameters.AddWithValue("@userID", 1);

            try
            {
                return ExecutNeBasicCommand(commands);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int UpdateStudent(Person p, Teachers t)
        {
            throw new NotImplementedException();
        }
    }
}
