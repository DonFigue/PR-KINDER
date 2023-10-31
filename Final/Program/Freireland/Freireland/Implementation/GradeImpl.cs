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
    public class GradeImpl : BaseImpl, IGrade
    {
        public int Delete(Grades t)
        {
            query = @"UPDATE Grade SET status=0, lastUpdate= CURRENT_TIMESTAMP, userID=@userID
                    WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
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

        public Grades Get(short id)
        {
            Grades t = null;
            query = @"SELECT id, nameGrade,level,parallel, price
					FROM Grade
					WHERE status = 1 AND id = @id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable dt = ExecutableDataTableCommand(command);
                if (dt.Rows.Count > 0)
                {
                    t = new Grades(short.Parse(dt.Rows[0][0].ToString()), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), decimal.Parse(dt.Rows[0][4].ToString()));
                }
            }
            catch (Exception ex) { throw ex; }
            return t;


        }

        public int Insert(Grades t)
        {
            query = @"INSERT INTO Grade(nameGrade, level, parallel, price, userID)
                     VALUES(@nameGrade, @level, @parallel, @price, @userID)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@nameGrade", t.nameGrade);
            command.Parameters.AddWithValue("@level", t.level);
            command.Parameters.AddWithValue("@parallel", t.parallel);
            command.Parameters.AddWithValue("@price", t.price);
            command.Parameters.AddWithValue("@userID", 1); //OJO sesiones

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
            query = @"SELECT id, nameGrade,level,parallel, price
					FROM Grade
					WHERE status = 1";

            SqlCommand command = CreateBasicCommand(query);
            try
            {
                return ExecuteDataTableCommand(command);
            }
            catch (Exception ex) { throw ex; }
            throw new NotImplementedException();
        }

        public DataTable Select(string search)
        {

            query = @"SELECT id, nameGrade,level,parallel, price
					FROM Grade
					WHERE status = 1 AND nameGrade LIKE '%' + @search + '%'";

            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@search", search);
            try
            {
                return ExecuteDataTableCommand(command);
            }
            catch (Exception ex) { throw ex; }
            throw new NotImplementedException();
        }

        public int Update(Grades t)
        {
            

            query = @"UPDATE Grade SET nameGrade = @name, level = @nivel, parallel = @parrarel, price=@price,lastUpdate=CURRENT_TIMESTAMP, userID=1 
					WHERE id=@id";

            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.nameGrade);
            command.Parameters.AddWithValue("@nivel", t.level);
            command.Parameters.AddWithValue("@parrarel", t.parallel);
            command.Parameters.AddWithValue("@price", t.price);
            command.Parameters.AddWithValue("@id", t.Id);

            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception)
            {

                throw;
            }

            throw new NotImplementedException();
        }
    }
}
