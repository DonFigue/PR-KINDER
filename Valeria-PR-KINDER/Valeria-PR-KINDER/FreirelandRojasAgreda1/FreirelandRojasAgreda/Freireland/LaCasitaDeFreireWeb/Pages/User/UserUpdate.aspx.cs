using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Freireland.Implementation;
using Freireland.Model;
using Freireland.Implementation;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using Freireland.Tools;

namespace LaCasitaDeFreireWeb.Pages.User
{
    public partial class UserUpdate : System.Web.UI.Page
    {
        Users s;
        UserImpl userImpl;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];
                if (!string.IsNullOrEmpty(id))
                {
                    userImpl = new UserImpl();
                    s = new Users();
                    s = userImpl.Get(byte.Parse(id));
                    s.Id = byte.Parse(id);
                    txtFirstName.Text = s.FirstName;
                    txtLastName.Text = s.LastName;
                    txtSecondLastName.Text = s.SecondlastName;
                    txtCI.Text = s.Ci;
                    txtNameUser.Text = s.Name;
                    Password.Text = s.Password;
                    txtCellphone.Text = s.Phone;
                    txtEmail.Text = s.Email;
                    cmbRol.SelectedValue = s.Role;
                }
                else
                {

                }
            }
        }


        private bool ValidateFields()
        {
            Validate validator = new Validate();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtNameUser.Text.Trim()))
            {
                lblNameUser.Visible = true;
                lblNameUser.Text = "Es obligatorio llenar el campo nombre de usuario.";
                isValid = false;
            }
            else
            {
                lblNameUser.Visible = true;
                lblNameUser.Text = "";

                string trimmedText = txtNameUser.Text.Trim();
                if (!string.IsNullOrWhiteSpace(trimmedText) && !validator.ValidateStudentCode(trimmedText))
                {
                    lblNameUser.Visible = true;
                    lblNameUser.Text = "El nombre de usuario debe tener 3 letras al principio seguido de 7 numeros.";
                    isValid = false;
                }
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

            return isValid;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            userImpl = new UserImpl();
            s = new Users();

            try
            {
                s.Id = short.Parse(Request.QueryString["id"]);
                s.FirstName = txtFirstName.Text;
                s.LastName = txtLastName.Text;
                s.SecondlastName = txtSecondLastName.Text;
                s.Ci = txtCI.Text;
                //s.Gender = char.Parse(rdbGender.SelectedValue);
                s.Name = txtNameUser.Text;
                s.Password = Password.Text;
                s.Phone = txtCellphone.Text;
                s.Email = txtEmail.Text;
                s.Role = cmbRol.SelectedValue;

                int n = userImpl.Update(s);
                if (n > 0)
                {
                    Response.Redirect("UserIndex.aspx");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}