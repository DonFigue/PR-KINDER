using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Freireland.Model;
using Freireland.Implementation;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using Freireland.Tools;

namespace LaCasitaDeFreireWeb.Pages.Attorney
{
    public partial class AttorneyUpdate : System.Web.UI.Page
    {
        AttorneyImpl impl;
        Freireland.Model.Attorney t;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];
                if (!string.IsNullOrEmpty(id))
                {
                    impl = new AttorneyImpl();
                    t = new Freireland.Model.Attorney();
                    t = impl.GET(short.Parse(id));
                    t.Id = short.Parse(id);
                    txtFirstName.Text = t.FirstName;
                    txtLastName.Text = t.LastName;
                    txtSecondLastName.Text = t.SecondLastName;
                    txtCI.Text = t.CI;
                    txtAddress.Text = t.Address;
                    txtOccupation.Text = t.Occupation;
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
            t = new Freireland.Model.Attorney();
            impl = new AttorneyImpl();
            try
            {
                t.Id = short.Parse(Request.QueryString["id"]);
                t.FirstName = txtFirstName.Text;
                t.LastName = txtLastName.Text;
                t.SecondLastName = txtSecondLastName.Text;
                t.CI = txtCI.Text;
                t.Address = txtAddress.Text;
                t.Gender = char.Parse(rdbGender.SelectedValue);
                t.Occupation = txtOccupation.Text;
                t.Id = short.Parse(Request.QueryString["id"]);
                int n = impl.Update(t);
                if (n > 0)
                {
                    Response.Redirect("AttorneyIndex.aspx");
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


            if (!validator.IsValidGender(rdbGender.SelectedValue))
            {
                lblGenero.Visible = true;
                lblGenero.Text = "Debes seleccionar un género.";
                isValid = false;
            }
            else
            {
                lblGenero.Visible = true;
                lblGenero.Text = "";
            }





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
            if (string.IsNullOrWhiteSpace(txtOccupation.Text.Trim()))
            {
                lblOccupation.Visible = true;
                lblNameError.Text = "Es obligatorio llenar el campo ocupacion.";
                isValid = false;
            }
            else
            {
                lblNameError.Visible = true;
                lblNameError.Text = "";

                string trimmedText = txtOccupation.Text.Trim();
                if (!string.IsNullOrWhiteSpace(trimmedText) && !validator.CheckOnlyText(trimmedText))
                {
                    lblNameError.Visible = true;
                    lblNameError.Text = "La Ocupacion solo debe tener letras.";
                    isValid = false;
                }
            }
            //if (!validator.CheckOnlyText(txtSecondLastName.Text.Trim()))
            //{
            //    lblSegError.Visible = true;
            //    lblSegError.Text = "El segundo apellido solo debe tener letras";
            //    isValid = false;
            //}
            //else
            //{
            //    lblSegError.Visible = true;
            //    lblSegError.Text = "";
            //}

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
            /*
            if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()))
            {
                lblEmail.Visible = true;
                lblEmail.Text = "Es obligatorio llenar el campo email.";
                isValid = false;
            }
            else
            {
                lblEmail.Visible = true;
                lblEmail.Text = "";
                if (!validator.CheckMailSintax(txtEmail.Text.Trim()))
                {
                    lblEmail.Visible = true;
                    lblEmail.Text = "El email no es valido";
                    isValid = false;
                }
            }
            */


            if (string.IsNullOrWhiteSpace(txtCI.Text.Trim()))
            {
                lblCiError.Visible = true;
                lblCiError.Text = "Es obligatorio llenar el campo ci.";
                isValid = false;
            }
            else
            {
                lblCiError.Visible = true;
                lblCiError.Text = "";
                if (!validator.IsValidIdentificationNumber(txtCI.Text.Trim()))
                {
                    lblCiError.Visible = true;
                    lblCiError.Text = "Ci no valido";
                    isValid = false;
                }
            }

            /*
            if (string.IsNullOrWhiteSpace(txtCellphone.Text.Trim()))
            {
                lblCellphone.Visible = true;
                lblCellphone.Text = "Es obligatorio llenar el campo telefono.";
                isValid = false;
            }
            else
            {
                lblCellphone.Visible = true;
                lblCellphone.Text = "";
                if (!validator.CheckIsPhone(txtCellphone.Text.Trim()))
                {
                    lblCellphone.Visible = true;
                    lblCellphone.Text = "Si el telefono empieza con 4, seguido 6 digitos.\n Si empieza con 7-6, seguido 7 digitos";
                    isValid = false;
                }
            }
            */
            return isValid;
        }

    }
}