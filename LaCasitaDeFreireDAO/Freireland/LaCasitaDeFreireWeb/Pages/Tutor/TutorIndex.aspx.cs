using InstitutionDAO.Implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaCasitaDeFreireWeb.Pages.Tutor
{
    public partial class TutorIndex : System.Web.UI.Page
    {
        TutorImpl tutor;


        protected void Page_Load(object sender, EventArgs e)
        {
            Select();
        }

        public void Select()
        {
            tutor = new TutorImpl();
            DataTable dt = tutor.Select();

            GridView1.DataSource = dt;

            // Actualiza la vista del GridView
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand2(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditRow")
            {
                // Lógica para manejar el evento de "Editar"
            }
            else if (e.CommandName == "DeleteRow")
            {
                // Lógica para manejar el evento de "Eliminar"
            }
            // Agrega más casos según los botones que tengas en tu GridView
        }
    }
}