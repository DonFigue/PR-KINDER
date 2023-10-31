using Freireland.Implementation;
using Freireland.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaCasitaDeFreireWeb.Pages.Grade
{
    public partial class GradeUpdate : System.Web.UI.Page
    {
        Freireland.Model.Grades t;
        GradeImpl impl;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];
                if (!string.IsNullOrEmpty(id))
                {
                    impl = new GradeImpl();
                    t = new Freireland.Model.Grades();
                    t = impl.Get(short.Parse(id));
                    t.Id = short.Parse(id);
                    txtFirstName.Text = t.nameGrade;
                    txtLastName.Text = t.level;
                    txtSecondLastName.Text = t.parallel;
                    txtPrice.Text = t.price+"";
                }
                else
                {

                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            impl = new GradeImpl();
            t = new Freireland.Model.Grades();

            try
            {
                t.Id = short.Parse(Request.QueryString["id"]);
                t.nameGrade = txtFirstName.Text;
                t.level = txtLastName.Text;
                t.parallel = txtSecondLastName.Text;
                t.price = decimal.Parse(txtPrice.Text);
                int n = impl.Update(t);
                if (n > 0)
                {
                    Response.Redirect("GradesIndex.aspx");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidateFields()
        {
            Validate validator = new Validate();
            bool isValid = true;






            if (string.IsNullOrWhiteSpace(txtFirstName.Text.Trim()))
            {
                lblNameError.Visible = true;
                lblNameError.Text = "Es obligatorio llenar el campo nombre.";
                isValid = false;
            }
            else
            {
                lblNameError.Visible = true;
                lblNameError.Text = "";

                string trimmedText = txtFirstName.Text.Trim();
                if (!string.IsNullOrWhiteSpace(trimmedText) && !validator.CheckOnlyText(trimmedText))
                {
                    lblNameError.Visible = true;
                    lblNameError.Text = "El nombre solo debe tener letras.";
                    isValid = false;
                }
            }


            if (string.IsNullOrWhiteSpace(txtLastName.Text.Trim()))
            {
                lblApellidoError.Visible = true;
                lblApellidoError.Text = "Es obligatorio llenar el campo apellido.";
                isValid = false;
            }
            else
            {
                lblApellidoError.Visible = true;
                lblApellidoError.Text = "";
                if (!validator.CheckOnlyText(txtLastName.Text.Trim()))
                {
                    lblApellidoError.Visible = true;
                    lblApellidoError.Text = "El apellido solo debe tener letras";
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}