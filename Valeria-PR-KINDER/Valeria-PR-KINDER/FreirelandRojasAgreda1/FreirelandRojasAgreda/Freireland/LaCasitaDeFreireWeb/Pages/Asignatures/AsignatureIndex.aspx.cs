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

namespace LaCasitaDeFreireWeb.Pages.Asignatures
{
    public partial class AsignatureIndex : System.Web.UI.Page
    {
        AsignatureImpl asignatureimpl;
        Asignaturee a;
        protected void Page_Load(object sender, EventArgs e)
        {
            Select();
            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];

                if (!string.IsNullOrEmpty(id))
                {
                    a = new Asignaturee();
                    asignatureimpl = new AsignatureImpl();
                    a.Id = byte.Parse(id);
                    a.UserID = 1;

                    int n = asignatureimpl.Delete(a);
                    if (n > 0)
                    {
                        Response.Redirect("AsignatureIndex.aspx");
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

                asignatureimpl = new AsignatureImpl();
                DataTable dt = asignatureimpl.Select(search);

                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark table-striped'>");
                table.Append("<thead>" +
                            //"<th class='text-center'>Materias</th>" +
                            "<th class='text-center'>Nombre Materia</th>" +
                            "<thclass='text-center'>Codigo Materia</th>" +
                            //"<th>Segundo Apellido</th>" +
                            //"<th>Ci</th>" +
                            "<th class='text-center'>" + "<a type='button' href='AsignatureCreate.aspx' class='btn btn-success'>+ Nueva Materia</a>" + "</th>" +
                            "</thead>");
                int pos;
                foreach (DataRow dr in dt.Rows)
                {
                    pos = dt.Rows.IndexOf(dr);
                    table.Append("<tr>");
                    table.Append("<td class='text-center'>" + dt.Rows[pos][1].ToString() + "</td>");
                    table.Append("<td class='text-center'>" + dt.Rows[pos][2].ToString() + "</td>");
                    //table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                    //table.Append("<td>" + dt.Rows[pos][4].ToString() + "</td>");
                    //table.Append("<td>" + dt.Rows[pos][5].ToString() + "</td>");

                    table.Append("<td class='text-center'>" + "<a class='btn btn-outline-warning' href='AsignatureUpdate.aspx?ID=" + dr[0] + "'>Editar</a>");
                    table.Append("<td class='text-center'>" + "<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Eliminar</button>" + "</td>");
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5 text-light'  id='DeleteModalLabel'>Eliminar Usuario</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Esta seguro/a de eliminar esta Materia? | " + dr[1] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger' href='AsignatureIndex.aspx?ID=" + dr[0] + "'>Eliminar</a>" +
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

                asignatureimpl = new AsignatureImpl();
                DataTable dt = asignatureimpl.Select();

                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark table-striped'>");
                table.Append("<thead>" +
                            //"<th class='text-center'>Materia</th>" +
                            "<th class='text-center'>Nombre Materia</th>" +
                            "<th class='text-center'>Codigo Materia</th>" +
                            //"<th>Segundo Apellido</th>" +
                            //"<th>Ci</th>" +
                            "<th class='text-center'>" + "<a type='button' href='AsignatureCreate.aspx' class='btn btn-success'>+ Nueva Materia</a>" + "</th>" +
                            "</thead>");
                int pos;
                foreach (DataRow dr in dt.Rows)
                {
                    pos = dt.Rows.IndexOf(dr);
                    table.Append("<tr>");
                    table.Append("<td class='text-center'>" + dt.Rows[pos][1].ToString() + "</td>");
                    table.Append("<td class='text-center'>" + dt.Rows[pos][2].ToString() + "</td>");
                    //table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                    //table.Append("<td>" + dt.Rows[pos][4].ToString() + "</td>");
                    //table.Append("<td>" + dt.Rows[pos][5].ToString() + "</td>");

                    table.Append("<td class='text-center'>" + "<a class='btn btn-outline-warning' href='AsignatureUpdate.aspx?ID=" + dr[0] + "'>Editar</a>");
                    table.Append("<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Eliminar</button>" + "</td>");
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5 text-light'  id='DeleteModalLabel'>Eliminar Usuario</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Esta seguro/a de eliminar esta Materia? | " + dr[1] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger' href='AsignatureIndex.aspx?ID=" + dr[0] + "'>Eliminar</a>" +
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