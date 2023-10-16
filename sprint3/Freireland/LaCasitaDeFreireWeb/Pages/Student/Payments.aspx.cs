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

namespace LaCasitaDeFreireWeb.Pages.Student
{
    public partial class Payments : System.Web.UI.Page
    {
        Payment t;
        PaymentImpl pyImpl;
        string st;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];
                st = id;
                //mid = int.Parse(id);
                if (!string.IsNullOrEmpty(id))
                {
                    Select(int.Parse(id));
                }
                else
                {

                }
            }
        }

        private void Select(int id)
        {

            try
            {

                pyImpl = new PaymentImpl();
                DataTable dt = pyImpl.Select(id);

                StringBuilder table = new StringBuilder();
                table.Append("<table class='table table-dark'>");
                table.Append("<thead>" +
                            "<th class='text-center'>ESTADO</th>" +
                            "<th>Monto</th>" +
                            "<th>Fecha de Pago</th>" +
                            "<th>Razon Social</th>" +
                            "<th>NIT</th>" +
                            "<th>Ultima Modificacion</th>" +
                            "<th class='text-center'>" + "<a type='button' href='StudentCreate.aspx' class='btn btn-success'>+ Agregar un Pago Extra</a>" + "</th>" +
                            "</thead>");
                int pos;
                //<button type='button' class='btn btn-success' data-bs-toggle='modal' data-bs-target='#exampleModal'>+ Nueva Categoria</button>
                bool isFirst = false;
                foreach (DataRow dr in dt.Rows)
                {
                    pos = dt.Rows.IndexOf(dr);
                    if (dt.Rows[pos][1].ToString() == "NO PAGADA")
                    {
                        table.Append("<tr>");
                        table.Append("<td class='text-center bg-danger text-white'>" + dt.Rows[pos][1].ToString() + "</td>");

                    }
                    else
                    {
                    table.Append("<tr bg-success>");
                        table.Append("<td class='text-center bg-success text-white'>" + dt.Rows[pos][1].ToString() + "</td>");

                    }
                    table.Append("<td>" + dt.Rows[pos][2].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][3].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][4].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][5].ToString() + "</td>");
                    table.Append("<td>" + dt.Rows[pos][6].ToString() + "</td>");
                    if (dt.Rows[pos][1].ToString() == "NO PAGADA")
                    {
                        table.Append("<td class='text-center'><div class='d-grid gap-2'>" + "");
                        if (!isFirst)
                        {
                            table.Append("<button type='button' class='btn btn-outline-success' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "'>Pagar</button>" + "</div></td>");

                        }
                        else
                        {
                            table.Append("<button type='button' class='btn btn-outline-success' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + "' disabled>Pagar</button>" + "</div></td>");

                        }

                    }
                    else
                    {
                        table.Append("<td class='text-center'><div class='d-grid gap-2'><div class='btn-group'>");

                        table.Append("<button type='button' class='btn btn-secondary' data-bs-toggle='modal' data-bs-target='#DeleteModal" + dr[0] + " ' disabled>Pagado</button>" + "<button type='button' class='btn btn-outline-danger' data-bs-toggle='modal' data-bs-target='#DeleteModalA" + dr[0] + " '>Revertir</button></div></div></td>");

                    }
                    table.Append("</tr>");
                    table.Append("<div class='modal fade'  id='DeleteModal" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModal" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-success'>" +
                        "<h1 class='modal-title fs-5 text-light'  id='DeleteModalLabel'>Registrar Pago</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Se realizara el pago de: "+ dr[2] +" Bs.\n A nombre de : " + dr[4] + " con NIT: "+ dr[5] +"</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-success btn-lg' href='Paid.aspx?ID=" + dr[0] +"&ST="+st+"'>Registrar Pago</a>" +
                        "</div></div></div></div>");
                    table.Append("<div class='modal fade'  id='DeleteModalA" + dr[0] + "' tabindex='-1' aria-labelledby='DeleteModalA" + dr[0] + "' aria-hidden='true'>" +
                        "<div class='modal-dialog'>" +
                        "<div class='modal-content'>" +
                        "<div class='modal-header bg-danger'>" +
                        "<h1 class='modal-title fs-5 text-light'  id='DeleteModalALabel'>Revertir Pago</h1>" +
                        "<button type='button' class='btn-close' data-bs-dismiss='modal' aria-label='Cerrar'></button>" +
                        "</div><div class='modal-body'> Se revertira el pago de: " + dr[2] + " Bs.\n A nombre de : " + dr[4] + " con NIT: " + dr[5] + "</div>" +
                        "<div class='modal-footer'>" +
                        "<button type='button' class='btn btn-outline-secondary' data-bs-dismiss='modal'>Cancelar</button>" +
                        "<a class='btn btn-outline-danger btn-lg' href='UnPaid.aspx?ID=" + dr[0] + "&ST=" + st + "'>Revertir Pago</a>" +
                        "</div></div></div></div>");
                    if (dt.Rows[pos][1].ToString() == "NO PAGADA")
                    {
                        isFirst = true;
                    }
                }
                table.Append("</table>");

                divTable.InnerHtml = table.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}