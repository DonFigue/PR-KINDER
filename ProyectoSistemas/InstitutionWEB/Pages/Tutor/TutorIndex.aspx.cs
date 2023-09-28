using InstitutionDAO.Implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InstitutionWEB.Pages.Tutor
{
    public partial class TutorIndex : System.Web.UI.Page
    {
        TutorImpl tutor;
        protected void Page_Load(object sender, EventArgs e)
        {
            Select();
        }

        void Select()
        {
            tutor = new TutorImpl();
            DataTable dt = tutor.Select();
            gvTutor.DataSource = dt;
            gvTutor.DataBind();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Tutor/TutorCreate.aspx");
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            string id;
            Button btnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectedrow.Cells[0].Text;
            Response.Redirect("~/Pages/Tutor/TutorInfo.aspx?id=" + id);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string id;
            Button btnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectedrow.Cells[0].Text;
            Response.Redirect("~/Pages/Tutor/TutorCreate.aspx?id=" + id);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            tutor = new TutorImpl();
            DataTable dt = tutor.SelectLike(txtSearch.Text);
            gvTutor.DataSource = dt;
            gvTutor.DataBind();
        }
    }
}