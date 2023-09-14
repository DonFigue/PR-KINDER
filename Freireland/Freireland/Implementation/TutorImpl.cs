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
    internal class TutorImpl : BaseImpl, ITutor
    {
        public void InsertTutor(Person p, Tutor t)
        {
            query = @"INSERT INTO Person(ci,firstName,lastName,secondLastName,birthDate,gender,phone,photo,userID)
            VALUES(@ci,@firstName,@lastName,@secondLastName,@birthDate,@gender,@phone,@photo,@userID)";

            string query1 = @"INSERT INTO Customer(id,homeAddress,businessAddress,occupation,income,userID)
            VALUES (@id,@homeAddress,@businessAddress,@occupation,@income,@userID)";

            List<SqlCommand> commads = Create2BasicCommand(query, query1);

            commads[0].Parameters.AddWithValue("@ci", p.CI);
            commads[0].Parameters.AddWithValue("@firstName", p.FirstName);
            commads[0].Parameters.AddWithValue("@lastName", p.LastName);
            commads[0].Parameters.AddWithValue("@birthDate", p.Cellphone);

            int n = int.Parse(GetGenerateIDTable("Person"));

            commads[1].Parameters.AddWithValue("@id", n);
            commads[1].Parameters.AddWithValue("@homeAddress", t.GraduateLevel);
            commads[1].Parameters.AddWithValue("@businessAddress", t.JobOccupation);


            try
            {
                ExecutNeBasicCommand(commads);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteTutor(Person p, Tutor t)
        {
            query = @"UPDATE Person SET status = 0, lastUpdate = CURRENT_TIMESTAMP,userID =@userID
                    WHERE id = @id";

            string query1 = @"UPDATE Customer SET status = 0,lastUpdate = CURRENT_TIMESTAMP,userID=@userID
                    WHERE id = @idCustomer"
            ;

            List<SqlCommand> commands = Create2BasicCommand(query, query1);

            commands[0].Parameters.AddWithValue("@id", p.IdPerson);
            commands[1].Parameters.AddWithValue("@idCustomer", t.IdTutor);
            try
            {
                ExecutNeBasicCommand(commands);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void UpdateTutor(Person p, Tutor t)
        {
            query = @"UPDATE Person SET lastUpdate = CURRENT_TIMESTAMP, userID = @userID ,firstName = @firstName, lastName = @lastName,
		            secondLastName = @secondLastName,phone = @phone
		            WHERE id = @id";

            string query1 = @"UPDATE Customer SET lastUpdate = CURRENT_TIMESTAMP, userID = @userID, homeAddress = @homeAddress, 
		            businessAddress = @businessAddress, occupation = @occupation, income = @income
		            WHERE id = @idCustommer";


            List<SqlCommand> commands = Create2BasicCommand(query, query1);

            commands[0].Parameters.AddWithValue("@firstName", p.FirstName);
            commands[0].Parameters.AddWithValue("@lastName", p.LastName);
            commands[0].Parameters.AddWithValue("@phone", p.Cellphone);
            commands[0].Parameters.AddWithValue("@id", p.IdPerson);
            commands[0].Parameters.AddWithValue("@ci", p.CI);

            commands[1].Parameters.AddWithValue("@homeAddress", t.JobOccupation);
            commands[1].Parameters.AddWithValue("@businessAddress", t.GraduateLevel);
            commands[1].Parameters.AddWithValue("@idCustommer", t.IdTutor);

            try
            {
                ExecutNeBasicCommand(commands);
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public DataTable Select()
        {
            query = @"SELECT id,firstname,ci,address 
                    FROM Person
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
    }
}
