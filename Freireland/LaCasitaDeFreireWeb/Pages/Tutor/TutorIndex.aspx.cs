using Freireland.Model;
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
        //TutorImpl tutor;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Llama al método Select() solo si la página no se está cargando debido a un postback
                Select();
            }
        }

        public void Select()
        {
            //tutor = new TutorImpl();
            DataTable dt = tutor.Select();

            // Asigna el DataTable como origen de datos del GridView
            GridView1.DataSource = dt;

            // Actualiza la vista del GridView
            GridView1.DataBind();
        }
    }
}