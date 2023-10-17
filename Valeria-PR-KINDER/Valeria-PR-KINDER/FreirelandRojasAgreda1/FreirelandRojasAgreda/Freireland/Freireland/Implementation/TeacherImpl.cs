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
            throw new NotImplementedException();
        }

        public Teachers Get(short id)
        {
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
            throw new NotImplementedException();
        }

        public int Update(Teachers t)
        {
            throw new NotImplementedException();
        }

        public int UpdateStudent(Person p, Teachers t)
        {
            throw new NotImplementedException();
        }
    }
}
