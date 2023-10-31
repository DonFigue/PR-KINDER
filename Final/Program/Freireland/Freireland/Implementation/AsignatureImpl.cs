using Freireland.Interfaces;
using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Implementation
{
    public class AsignatureImpl : BaseImpl, IAsignature
    {
        public List<Area> ObtenerDatosArea()
        {
            query = @"SELECT id, areaName 
                        FROM Area 
                            WHERE status=1;";
            SqlCommand command = CreateBasicCommand(query);
            DataTable dataTable = ExecuteDataTableCommand(command);

            List<Area> areas = new List<Area>();
            foreach (DataRow row in dataTable.Rows)
            {
                byte id = Convert.ToByte(row["id"]);
                string areaName = row["areaName"].ToString();

                Area area = new Area(id, areaName);
                areas.Add(area);
            }

            return areas;
        }

        public List<Grades> ObtenerDatosGrados()
        {
            query = @"SELECT id, nameGrade, price
                FROM Grade ;";
            SqlCommand command = CreateBasicCommand(query);
            DataTable dataTable = ExecuteDataTableCommand(command);

            List<Grades> grados = new List<Grades>();
            foreach (DataRow row in dataTable.Rows)
            {
                byte id = Convert.ToByte(row["id"]);
                string nameGrade = row["nameGrade"].ToString();
                decimal price = decimal.Parse(row["price"].ToString());
                Grades grado = new Grades(id, nameGrade, price);
                grados.Add(grado);
            }

            return grados;
        }

        public int Delete(Asignaturee t)
        {
            query = @"UPDATE Asignature SET status=0, userID=@userID, lastUpdate=CURRENT_TIMESTAMP WHERE id=@id";
            string query2 = @"UPDATE Asignature SET userID=@userID, lastUpdate=CURRENT_TIMESTAMP WHERE id=@id";
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

        public Asignaturee Get(byte id)
        {
            Asignaturee a = null;
            query = @"SELECT A.id, A.nameAsignature, A.codeAsignature ,A.areaID, A.idGrade, G.nameGrade, Ar.areaName,
                    A.status, A.registerDate, ISNULL(A.lastUpdate, CURRENT_TIMESTAMP), A.userID
            FROM Asignature AS A
            LEFT JOIN Area AS Ar ON A.areaID = Ar.id
            LEFT JOIN Grade AS G ON A.idGrade = G.id
            
            WHERE A.id = @id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                DataTable table = ExecuteDataTableCommand(command);
                if (table.Rows.Count > 0)
                {
                    a = new Asignaturee(
                      id: byte.Parse(table.Rows[0]["id"].ToString()),
                      nameAsignature: table.Rows[0]["nameAsignature"].ToString(),
                      codeAsignature: table.Rows[0]["codeAsignature"].ToString(),

                      areaID: byte.Parse(table.Rows[0]["areaID"].ToString()),
                      gradeID: byte.Parse(table.Rows[0]["idGrade"].ToString()),

                      status: byte.Parse(table.Rows[0]["status"].ToString()),
                      registerDate: DateTime.Parse(table.Rows[0]["registerDate"].ToString()),
                      lastUpdate: DateTime.Parse(table.Rows[0][8].ToString()),
                      UserID: short.Parse(table.Rows[0]["userID"].ToString())
                  );


                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return a;
        }

        public int Insert(Asignaturee t)
        {
            query = @"INSERT INTO Asignature (nameAsignature,codeAsignature, areaID,idGrade,userID) 
              VALUES (@nameAsignature,@codeAsignature, @areaID,@idGrade,@userID); ";
            //SELECT SCOPE_IDENTITY();// Esta consulta devuelve el ID del registro insertado

            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@nameAsignature", t.NameAsignaturee);
            command.Parameters.AddWithValue("@codeAsignature", t.CodeAsignaturee);
            command.Parameters.AddWithValue("@idGrade", t.GradeID);

            command.Parameters.AddWithValue("@areaID", t.AreaID);
           // command.Parameters.AddWithValue("@evaluationCriteriaID", t.EvaluationCriteria.Id);
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
            query = @"SELECT A.id AS 'Id', A.nameAsignature AS 'Nombre Materia',A.codeAsignature, Ar.areaName AS 'Nombre Area'
              FROM Asignature AS A
              INNER JOIN Area AS Ar ON A.areaID = Ar.id
             
                WHERE A.status=1
                ORDER BY 2;";

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
            query = @"SELECT id,nameAsignature
                        FROM Asignature
                        WHERE status = 1 AND nameAsignature LIKE '%' + @search + '%'";
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

        public int Update(Asignaturee t)
        {
            query = @"UPDATE Asignature SET nameAsignature = @nameAsignature, codeAsignature = @codeAsignature,
              areaID = @areaID,lastUpdate=CURRENT_TIMESTAMP,
              userID = @userID
              WHERE id = @id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@nameAsignature", t.NameAsignaturee);
            command.Parameters.AddWithValue("@codeAsignature", t.CodeAsignaturee);
            command.Parameters.AddWithValue("@areaID", t.AreaID);
            command.Parameters.AddWithValue("@evaluationCriteriaID", t.GradeID);
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
    }
}
