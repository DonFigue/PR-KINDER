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

namespace LaCasitaDeFreireWeb.Pages.User
{
    public partial class UserIndex : System.Web.UI.Page
    {
        UserImpl userImpl;
        Users u;
        protected void Page_Load(object sender, EventArgs e)
        {
            Select();
            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];

                if (!string.IsNullOrEmpty(id))
                {
                    u = new Users();
                    userImpl = new UserImpl();
                    u.Id = byte.Parse(id);
                    u.UserID = 1;

                    int n = userImpl.Delete(u);
                    if (n > 0)
                    {
                        Response.Redirect("UserIndex.aspx");
                    }
                }
                else
                {

                }
            }
        }
        void Select(string search)
        {
            try
            {

                userImpl = new UserImpl();
                DataTable dt = userImpl.Select(search);

                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark table-striped'>");
                table.Append("<thead>" +
                            "<th class='text-center'>Nombre de usuario</th>" +
                            "<th>Nombres</th>" +
                            "<th>Primer Apellido</th>" +
                            "<th>Segundo Apellido</th>" +
                            "<th>Ci</th>" +
                            "<th class='text-center'>" + "<a type='button' href='UserCreate.aspx' class='btn btn-success'>+ Nuevo Usuario</a>" + "</th>" +
                            "</thead>");
                int pos;
                foreach (DataRow dr in dt.Rows)
                {
                    pos = dt.Rows.IndexOf(dr);
                    table.Append("<tr>");
                    table.Append("<td class='text-center'>" + dt.Rows[pos][1].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][2].ToString() + "</td>");
                     table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][4].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][5].ToString() + "</td>");

                    table.Append("<td class='text-center'>" + "<a class='btn btn-outline-warning' href='UserUpdate.aspx?ID=" + dr[0] + "'>Editar</a>");
                    table.Append("<td class='text-center'>" + "<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Eliminar</button>" + "</td>");
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5 text-light'  id='DeleteModalLabel'>Eliminar Usuario</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Esta seguro/a de eliminar este Usuario? | " + dr[1] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger' href='UserIndex.aspx?ID=" + dr[0] + "'>Eliminar</a>" +
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

                userImpl = new UserImpl();
                DataTable dt = userImpl.Select();

                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark table-striped'>");
                table.Append("<thead>" +
                            "<th class='text-center'>Nombre de usuario</th>" +
                            "<th>Nombres</th>" +
                            "<th>Primer Apellido</th>" +
                            "<th>Segundo Apellido</th>" +
                            "<th>Ci</th>" +
                            "<th class='text-center'>" + "<a type='button' href='UserCreate.aspx' class='btn btn-success'>+ Nuevo Usuario</a>" + "</th>" +
                            "</thead>");
                int pos;
                foreach (DataRow dr in dt.Rows)
                {
                    pos = dt.Rows.IndexOf(dr);
                    table.Append("<tr>");
                    table.Append("<td class='text-center'>" + dt.Rows[pos][1].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][2].ToString() + "</td>");
                     table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                     table.Append("<td>" + dt.Rows[pos][4].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][5].ToString() + "</td>");

                    table.Append("<td class='text-center'>" + "<a class='btn btn-outline-warning' href='UserUpdate.aspx?ID=" + dr[0] + "'>Editar</a>");
                    table.Append("<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Eliminar</button>" + "</td>");
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5 text-light'  id='DeleteModalLabel'>Eliminar Usuario</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Esta seguro/a de eliminar este Usuario? | " + dr[1] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger' href='UserIndex.aspx?ID=" + dr[0] + "'>Eliminar</a>" +
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
            Select(txtSearch.Text);
        }
    }
}