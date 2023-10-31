﻿using Freireland.Interfaces;
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
    public class StudentImpl : BaseImpl, IStudent
    {
        public int Delete(Students t)
        {
            query = @"UPDATE Person SET status=0, userID=@userID, lastUpdate=CURRENT_TIMESTAMP WHERE id=@id";
            string query2 = @"UPDATE Student SET userID=@userID, lastUpdate=CURRENT_TIMESTAMP WHERE id=@id";
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

        public Students Get(short id)
        {
            Students s = null;
            query = @"SELECT P.id, S.codStudent, P.firstName, P.lastName , P.secondLastName, P.ci, P.gender, P.placeOfBirth,P.address, P.birthDate, S.discapacity, S.registerDate, S.tutorID, S.gradeID,
                            ISNULL(S.lastUpdate, CURRENT_TIMESTAMP), S.userID
                    FROM Student S
					INNER JOIN Person P ON S.id= P.id
                    WHERE S.id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable table = ExecuteDataTableCommand(command);
                if (table.Rows.Count > 0)
                {

                    s = new Students(
                    firstName: table.Rows[0]["firstname"].ToString(),
                    lastName: table.Rows[0]["lastName"].ToString(),
                    secondLastName: table.Rows[0]["secondLastName"].ToString(),
                    cI: table.Rows[0]["ci"].ToString(),
                    gender: char.Parse(table.Rows[0]["gender"].ToString()),
                    placeOfBirth: table.Rows[0]["placeOfBirth"].ToString(),
                    address: table.Rows[0]["address"].ToString(),
                    birthdate: DateTime.Parse(table.Rows[0]["birthDate"].ToString()),
                    codStudent: table.Rows[0]["codStudent"].ToString(),
                    discapacity: table.Rows[0]["discapacity"].ToString(),
                    userID: short.Parse(table.Rows[0]["userID"].ToString()),
                    courseID: int.Parse(table.Rows[0]["gradeID"].ToString()),
                    tutorID: int.Parse(table.Rows[0]["tutorID"].ToString()));

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return s;
        }

        public int Insert(Students t)
        {
            query = @"INSERT INTO Person( firstName,lastName,secondLastName, ci,gender,address,birthDate,placeOfBirth, userID)
                        VALUES( @firstName,@lastName,@secondLastName,@ci,@gender,@address,@birthDate,@placeOfBirth, @userID)";
            string query2 = @"INSERT INTO Student(id, codStudent,discapacity, gradeID, userID)
			            VALUES(@id,@codStudent, @discapacity , @userID)";

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
            commands[1].Parameters.AddWithValue("@codStudent", t.codStudent);
            commands[1].Parameters.AddWithValue("@discapacity", t.discapacity);
            commands[1].Parameters.AddWithValue("@gradeID", t.courseID);
            commands[1].Parameters.AddWithValue("@tutorID", t.tutorID);
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
        public int InsertWithPayment(Students t, Plan p, List<Payment> s)
        {
            List<string> querys = new List<string>();
            query = @"INSERT INTO Person( firstName,lastName,secondLastName, ci,gender,address,birthDate,placeOfBirth, userID)
                        VALUES( @firstName,@lastName,@secondLastName,@ci,@gender,@address,@birthDate,@placeOfBirth, @userID)";
            querys.Add(query);
            string query2 = @"INSERT INTO Student(id, codStudent,discapacity, gradeID, tutorID, userID)
			            VALUES(@id,@codStudent, @discapacity, @gradeID, @tutorID, @userID)";
            querys.Add(query2);
            string query3 = @"INSERT INTO [Plan] (Description, StartDate, StudentID, userID) VALUES(@Description, @StartDate, @StudentID, @userID)";
            querys.Add(query3);
            string query4 = @"INSERT INTO Payment (DateOfPayment, Amount, PaymentState, Snack, TutorID, PlanID, userID) VALUES (@DateOfPayment, @Amount, @PaymentState, @Snack, @TutorID, @PlanID, @userID)";
            for (int b = 0; b < s.Count; b++)
            {
                querys.Add(query4);
            }


            List<SqlCommand> commands = CreateNBasicCommand(querys);

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
            commands[1].Parameters.AddWithValue("@codStudent", t.codStudent);
            commands[1].Parameters.AddWithValue("@discapacity", t.discapacity);
            commands[1].Parameters.AddWithValue("@gradeID", t.courseID);
            commands[1].Parameters.AddWithValue("@tutorID", t.tutorID);
            commands[1].Parameters.AddWithValue("@userID", 1);

            commands[2].Parameters.AddWithValue("@StartDate", p.StartDate);
            commands[2].Parameters.AddWithValue("@Description", p.Description);
            commands[2].Parameters.AddWithValue("@StudentID", id);
            commands[2].Parameters.AddWithValue("@userID", 1);

            int planId = int.Parse(GetGenerateIDTable("[Plan]"));

            int i = 1;
            foreach (var item in s)
            {
                commands[2 + i].Parameters.AddWithValue("@DateOfPayment", item.DateOfPayment);
                commands[2 + i].Parameters.AddWithValue("@Amount", item.Amount);
                commands[2 + i].Parameters.AddWithValue("@PaymentState", item.PaymentState);
                commands[2 + i].Parameters.AddWithValue("@Snack", item.Snack);
                commands[2 + i].Parameters.AddWithValue("@TutorID", t.tutorID);
                commands[2 + i].Parameters.AddWithValue("@PlanID", planId);
                commands[2 + i].Parameters.AddWithValue("@userID", 1);
                querys.Add(query4);
                i++;
            }


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
            query = @"SELECT S.id, S.codStudent, CONCAT(P.firstname, ' ', P.lastName, ' ', P.secondLastName) AS Nombre, P.ci, G.nameGrade, CONCAT(PT.firstname, ' ', PT.lastName, ' ', PT.secondLastName) AS Tutor
                    FROM Student S
                    INNER JOIN Person P ON S.id=P.id
                    INNER JOIN Grade G ON G.id=S.gradeID
                    INNER JOIN Tutor T ON T.id=S.tutorID
                    INNER JOIN Person PT ON PT.id=T.id
                        WHERE P.status = 1";
            SqlCommand command = CreateBasicCommand(query);
            try { return ExecuteDataTableCommand(command); }
            catch (Exception ex) { throw ex; }
        }

        public DataTable SelectByGrade(short id)
        {
            query = @"SELECT S.id, S.codStudent, CONCAT(P.firstname, ' ', P.lastName, ' ', P.secondLastName) AS Nombre, P.ci, G.nameGrade, CONCAT(PT.firstname, ' ', PT.lastName, ' ', PT.secondLastName) AS Tutor
                    FROM Student S
                    INNER JOIN Person P ON S.id=P.id
                    INNER JOIN Grade G ON G.id=S.gradeID
                    INNER JOIN Tutor T ON T.id=S.tutorID
                    INNER JOIN Person PT ON PT.id=T.id
                        WHERE P.status = 1 AND S.gradeID=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try { return ExecuteDataTableCommand(command); }
            catch (Exception ex) { throw ex; }
        }
        public DataTable SelectByGradeSearch(string search, short id)
        {
            query = @"SELECT S.id, S.codStudent, CONCAT(P.firstname, ' ', P.lastName, ' ', P.secondLastName) AS Nombre, P.ci, G.nameGrade, CONCAT(PT.firstname, ' ', PT.lastName, ' ', PT.secondLastName) AS Tutor
                    FROM Student S
                    INNER JOIN Person P ON S.id=P.id
                    INNER JOIN Grade G ON G.id=S.gradeID
                    INNER JOIN Tutor T ON T.id=S.tutorID
                    INNER JOIN Person PT ON PT.id=T.id
                        WHERE P.status = 1 AND P.firstname LIKE '%' + @search + '%' AND S.gradeID=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@search", search);
            command.Parameters.AddWithValue("@id", id);
            try { return ExecuteDataTableCommand(command); }
            catch (Exception ex) { throw ex; }
        }
        public DataTable Select(string search)
        {
            query = @"SELECT S.id, S.codStudent, CONCAT(P.firstname, ' ', P.lastName, ' ', P.secondLastName) AS Nombre, P.ci, G.nameGrade, CONCAT(PT.firstname, ' ', PT.lastName, ' ', PT.secondLastName) AS Tutor
                    FROM Student S
                    INNER JOIN Person P ON S.id=P.id
                    INNER JOIN Grade G ON G.id=S.gradeID
                    INNER JOIN Tutor T ON T.id=S.tutorID
                    INNER JOIN Person PT ON PT.id=T.id
                        WHERE P.status = 1 AND P.firstname LIKE '%' + @search + '%'";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@search", search);
            try { return ExecuteDataTableCommand(command); }
            catch (Exception ex) { throw ex; }
        }

        public int Update(Students t)
        {
            query = @"UPDATE Person SET firstname=@firstname, lastName=@lastName, secondLastName=@secondLastName,
            ci=@ci, gender=@gender, address=@address, birthdate=@birthdate, placeOfBirth=@placeOfBirth, lastUpdate=CURRENT_TIMESTAMP, userID=1 WHERE id=@id";
            
            string query2 = @"UPDATE Student SET codStudent=@codStudent, discapacity=@discapacity, lastUpdate=CURRENT_TIMESTAMP, userID=1 WHERE id=@id
";

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
            commands[1].Parameters.AddWithValue("@codStudent", t.codStudent);
            commands[1].Parameters.AddWithValue("@discapacity", t.discapacity);
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

        public int UpdateStudent(Person p, Students t)
        {
            query = @"UPDATE Person SET firstname=@firstname, lastName=@lastName, secondLastName=@secondLastName,
            ci=@ci, gender=@gender, address=@address, birthdate=@birthdate, placeOfBirth=@placeOfBirth, lastUpdate=CURRENT_TIMESTAMP, userID=1 WHERE id=@id";

            string query2 = @"UPDATE Student SET codStudent=@codStudent, discapacity=@discapacity, lastUpdate=CURRENT_TIMESTAMP, userID=1 WHERE id=@id
";

            List<SqlCommand> commands = Create2BasicCommand(query, query2);
            commands[0].Parameters.AddWithValue("@id", p.Id);
            commands[0].Parameters.AddWithValue("@firstName", p.FirstName);
            commands[0].Parameters.AddWithValue("@lastName", p.LastName);
            commands[0].Parameters.AddWithValue("@secondLastName", p.SecondLastName);
            commands[0].Parameters.AddWithValue("@ci", p.CI);
            commands[0].Parameters.AddWithValue("@gender", p.Gender);
            commands[0].Parameters.AddWithValue("@address", p.Address);
            commands[0].Parameters.AddWithValue("@birthDate", p.Birthdate);
            commands[0].Parameters.AddWithValue("@placeOfBirth", p.PlaceOfBirth);
            commands[0].Parameters.AddWithValue("@userID", 1);

            commands[1].Parameters.AddWithValue("@id", t.Id);
            commands[1].Parameters.AddWithValue("@codStudent", t.codStudent);
            commands[1].Parameters.AddWithValue("@discapacity", t.discapacity);
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
    }
}
