using Freireland.Implementation;
using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaCasitaDeFreireWeb.Pages.Teacher
{
    public partial class TeacherIndex : System.Web.UI.Page
    {
        Teachers t;
        TeacherImpl impl;

        protected void Page_Load(object sender, EventArgs e)
        {
            Select();
            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];
                if (!string.IsNullOrEmpty(id))
                {
                    try
                    {
                        impl = new TeacherImpl();
                        t = new Teachers();
                        t = impl.Get(short.Parse(id));
                        t.UserID = 1;
                        int n = impl.Delete(t);
                        if (n > 0)
                        {
                            Response.Redirect("TeacherIndex.aspx");
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                }
                else
                {

                }

            }
        }

        void SelectSearch(string search)
        {
            try
            {
                impl = new TeacherImpl();
                DataTable dt = impl.Select(search);
                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark table-striped'>");
                table.Append("<thead>" +
                            "<th class='text-center'>Nombre</th>" +
                            "<th>CI</th>" +
                            "<th>Email</th>" +
                            "<th>Celular</th>" +
                            "<th>Ciudad</th>" +
                            "<th class='text-center'><div class='d-grid gap-2'>" + "<a type='button' href='TeacherCreate.aspx' class='btn btn-success'>Registrar Profesor</a>" + "</div></th>" +
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
                    table.Append("<td>" + "<a class='btn btn-outline-success' href='#'>" + dr[4] + "</a>" + "</td>");
                    table.Append("<td>" + dt.Rows[pos][5].ToString() + "</td>");
                    table.Append("<td class='text-center'><div class='d-grid gap-2'><div class='btn-group'>" + "<a class='btn btn-outline-warning' href='TeacherUpdate.aspx?ID=" + dr[0] + "'>Editar</a>");
                    table.Append("<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Eliminar</button>" + "</div></div></td>");
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5'  id='DeleteModalLabel'>Eliminar Tutor</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Esta seguro/a de eliminar este Tutor? | " + dr[1] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger' href='TeacherIndex.aspx?ID=" + dr[0] + "'>Eliminar</a>" +
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
        void Select()
        {
            try
            {
                impl = new TeacherImpl();
                DataTable dt = impl.Select();
                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark table-striped'>");
                table.Append("<thead>" +
                            "<th class='text-center'>Nombre</th>" +
                            "<th>CI</th>" +
                            "<th>Email</th>" +
                            "<th>Celular</th>" +
                            "<th>Ciudad</th>" +
                            //"<th class='text-center'>" + "<a type='button' href='TeacherCreate.aspx' class='btn btn-success'>+ Nuevo Profesor</a>" + "</th>" +
                            "<th class='text-center'><div class='d-grid gap-2'>" + "<a type='button' href='TeacherCreate.aspx' class='btn btn-success'>Registrar Profesor</a>" + "</div></th>" +
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
                    table.Append("<td>" + "<a class='btn btn-outline-success' href='#'>" + dr[4] + "</a>" + "</td>");
                    table.Append("<td>" + dt.Rows[pos][5].ToString() + "</td>");
                    table.Append("<td class='text-center'><div class='d-grid gap-2'><div class='btn-group'>" + "<a class='btn btn-outline-warning' href='TeacherUpdate.aspx?ID=" + dr[0] + "'>Editar</a>");
                    table.Append("<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Eliminar</button>" + "</div></div></td>");
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5'  id='DeleteModalLabel'>Eliminar Profesor/a</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Esta seguro/a de eliminar este Profesor/a? | " + dr[1] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger' href='TeacherIndex.aspx?ID=" + dr[0] + "'>Eliminar</a>" +
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