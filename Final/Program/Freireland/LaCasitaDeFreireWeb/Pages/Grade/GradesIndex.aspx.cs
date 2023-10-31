using Freireland.Implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaCasitaDeFreireWeb.Pages.Grade
{
    public partial class GradesIndex : System.Web.UI.Page
    {
        GradeImpl courseImpl;
        Freireland.Model.Grades course;
        protected void Page_Load(object sender, EventArgs e)
        {
            Select();

            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];
                if (!string.IsNullOrEmpty(id))
                {

                    courseImpl = new GradeImpl();
                    course = new Freireland.Model.Grades();
                    course = courseImpl.Get(short.Parse(id));
                    course.UserID = 1;
                    int n = courseImpl.Delete(course);
                    if (n > 0)
                    {
                        Response.Redirect("GradesIndex.aspx");
                    }
                }
                else
                {

                }
                string search = Request.QueryString["search"];
                if (!string.IsNullOrEmpty(search))
                {
                    SelectSearch(search);
                }
            }
        }


        void Select()
        {
            try
            {

                courseImpl = new GradeImpl();
                DataTable dt = courseImpl.Select();

                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark table-striped'>");
                table.Append("<thead>" +
                           "<th class='text-center'>Nombre</th>" +
                           "<th>Nivel</th>" +
                           "<th>Paralelo</th>" +
                           "<th>Precio</th>" +
                           "<th class='text-center'><div class='d-grid gap-2'>" + "<a type='button' href='insert_grade.aspx' class='btn btn-success'>Registrar Curso</a>" + "</div></th>" +
                           "</thead>");
                int pos;
                //<button type='button' class='btn btn-success' data-bs-toggle='modal' data-bs-target='#exampleModal'>+ Nueva Categoria</button>
                foreach (DataRow dr in dt.Rows)
                {
                    pos = dt.Rows.IndexOf(dr);
                    table.Append("<tr>");
                    table.Append("<td class='text-center'>" + dt.Rows[pos][1].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][2].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][4].ToString() + "</td>");
                    table.Append("<td class='text-center'><div class='d-grid gap-2'><div class='btn-group'>" + "<a class='btn btn-outline-info' href='GradeStudent.aspx?IDG=" + dr[0] + "'>Estudiantes</a>" + "<a class='btn btn-outline-warning' href='GradeUpdate.aspx?ID=" + dr[0] + "'>Editar</a>");
                    table.Append("<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Eliminar</button>" + "</div></div></td>");
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5 text-light'  id='DeleteModalLabel'>Eliminar Curso</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Esta seguro/a de eliminar este Curso? | " + dr[1] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger' href='GradesIndex.aspx?ID=" + dr[0] + "'>Eliminar</a>" +
                        "</div></div></div></div>");
                }
                table.Append("</table>");

                divTable.InnerHtml = table.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void SelectSearch(string search)
        {
            try
            {

                courseImpl = new GradeImpl();
                DataTable dt = courseImpl.Select(search);

                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark table-striped'>");
                table.Append("<thead>" +
                            "<th class='text-center'>Nombre</th>" +
                            "<th>Nivel</th>" +
                            "<th>Paralelo</th>" +
                           "<th>Precio</th>" +
                            "<th class='text-center'>" + "<a type='button' href='StudentCreate.aspx' class='btn btn-success'>Registrar Curso</a>" + "</th>" +
                            "</thead>");
                int pos;
                //<button type='button' class='btn btn-success' data-bs-toggle='modal' data-bs-target='#exampleModal'>+ Nueva Categoria</button>
                foreach (DataRow dr in dt.Rows)
                {
                    pos = dt.Rows.IndexOf(dr);
                    table.Append("<tr>");
                    table.Append("<td class='text-center'>" + dt.Rows[pos][1].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][2].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                    // table.Append("<td>" + dt.Rows[pos][4].ToString() + "</td>");
                    table.Append("<td class='text-center'>" + "<a class='btn btn-outline-warning' href='GradeUpdate.aspx?ID=" + dr[0] + "'>Editar</a>");
                    table.Append("<td class='text-center'>" + "<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Eliminar</button>" + "</td>");
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5 text-light'  id='DeleteModalLabel'>Eliminar Curso</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Esta seguro/a de eliminar este Curso? | " + dr[1] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger' href='GradesIndex.aspx?ID=" + dr[0] + "'>Eliminar</a>" +
                        "</div></div></div></div>");
                }
                table.Append("</table>");

                divTable.InnerHtml = table.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SelectSearch(txtSearch.Text);
        }

    }
}