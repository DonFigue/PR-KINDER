using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Freireland.Model;
using Freireland.Implementation;
using System.Data;
using System.Text;

namespace LaCasitaDeFreireWeb.Pages.Attorney
{
    public partial class AttorneyIndex : System.Web.UI.Page
    {
        AttorneyImpl impl;
        Freireland.Model.Attorney t;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Select();
                string id = Request.QueryString["ID"];

                if (!string.IsNullOrEmpty(id))
                {
                    t = new Freireland.Model.Attorney();
                    impl = new AttorneyImpl();
                    t.Id = short.Parse(id);
                    t.UserID = 1;

                    int n = impl.Delete(t);
                    if (n > 0)
                    {
                        Response.Redirect("AttorneyIndex.aspx");
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

                impl = new AttorneyImpl();
                DataTable dt = impl.Select(search);

                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark table-striped'>");
                table.Append("<thead>" +
                            "<th class='text-center'>Nombre</th>" +
                            "<th>CI</th>" +
                            "<th>Ocupacion</th>" +
                            "<th>Ultima Actualizacion</th>" +
                            "<th class='text-center'>" + "<a type='button' href='AttorneyCreate.aspx' class='btn btn-success'>+ Nuevo Profesor</a>" + "</th>" +
                            "</thead>");
                int pos;
                //<button type='button' class='btn btn-success' data-bs-toggle='modal' data-bs-target='#exampleModal'>+ Nueva Categoria</button>
                foreach (DataRow dr in dt.Rows)
                {
                    pos = dt.Rows.IndexOf(dr);
                    table.Append("<tr>");
                    table.Append("<td class='text-center'>" + dt.Rows[pos][1].ToString() +" " + dt.Rows[pos][2] + "</td>");
                    table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                    // table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][4].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][5].ToString() + "</td>");
                    table.Append("<td class='text-center'>" + "<a class='btn btn-outline-warning' href='AttorneyUpdate.aspx?ID=" + dr[0] + "'>Editar</a>");
                    table.Append("<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Eliminar</button>" + "</td>");
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5 text-light'  id='DeleteModalLabel'>Eliminar Profesor</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Esta seguro/a de eliminar este Profesor? | " + dr[1] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger' href='AttorneyIndex.aspx?ID=" + dr[0] + "'>Eliminar</a>" +
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

                impl = new AttorneyImpl();
                DataTable dt = impl.Select();

                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark table-striped'>");
                table.Append("<thead>" +
                            "<th class='text-center'>Nombre</th>" +
                            "<th>CI</th>" +
                            "<th>Ocupacion</th>" +
                            "<th>Ultima Actualizacion</th>" +
                            "<th class='text-center'>" + "<a type='button' href='AttorneyCreate.aspx' class='btn btn-success'>+ Nuevo Profesor</a>" + "</th>" +
                            "</thead>");
                int pos;
                //<button type='button' class='btn btn-success' data-bs-toggle='modal' data-bs-target='#exampleModal'>+ Nueva Categoria</button>
                foreach (DataRow dr in dt.Rows)
                {
                    pos = dt.Rows.IndexOf(dr);
                    table.Append("<tr>");
                    table.Append("<td class='text-center'>" + dt.Rows[pos][1].ToString() + " " + dt.Rows[pos][2] + "</td>");
                    table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                    // table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][4].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][5].ToString() + "</td>");
                    table.Append("<td class='text-center'>" + "<a class='btn btn-outline-warning' href='AttorneyUpdate.aspx?ID=" + dr[0] + "'>Editar</a>");
                    table.Append("<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Eliminar</button>" + "</td>");
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5 text-light'  id='DeleteModalLabel'>Eliminar Profesor</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Esta seguro/a de eliminar este Profesor? | " + dr[1] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger' href='AttorneyIndex.aspx?ID=" + dr[0] + "'>Eliminar</a>" +
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