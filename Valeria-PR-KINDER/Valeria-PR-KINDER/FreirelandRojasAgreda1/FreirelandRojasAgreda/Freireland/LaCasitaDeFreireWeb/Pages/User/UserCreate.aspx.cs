using System;
using Freireland.Model;
using Freireland.Implementation;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Freireland.Tools;

namespace LaCasitaDeFreireWeb.Pages.User
{
    public partial class UserCreate : System.Web.UI.Page
    {
        UserImpl userImpl;
        Users u;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            try
            {
                u = new Users(txtNameUser.Text.Trim(), txtPassword.Text.Trim(),
                    txtFirstName.Text.Trim(), txtLastName.Text.Trim(),
                    txtSecondLastName.Text.Trim(), txtCellphone.Text.Trim(),
                    char.Parse(rdbGender.Text.Trim()), txtEmail.Text.Trim(),
                    txtCI.Text.Trim(), cmbRol.Text.Trim());

                userImpl = new UserImpl();
                int n = userImpl.Insert(u);
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

            if (!validator.IsValidRole(cmbRol.SelectedValue))
            {
                lblRolError.Visible = true;
                lblRolError.Text = "Debes seleccionar un rol.";
                isValid = false;
            }
            else
            {
                lblRolError.Visible = true;
                lblRolError.Text = "";
            }


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
                if (!string.IsNullOrWhiteSpace(trimmedText) && !validator.IsUsernameValid(trimmedText))
                {
                    lblNameUser.Visible = true;
                    lblNameUser.Text = "El nombre de usuario debe tener 5 letras y seguido 2 numeros.";
                    isValid = false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                lblPassword.Visible = true;
                lblPassword.Text = "Es obligatorio llenar el campo contraseña.";
                isValid = false;
            }
            else
            {
                lblPassword.Visible = true;
                lblPassword.Text = "";

                string trimmedText = txtPassword.Text.Trim();
                if (!string.IsNullOrWhiteSpace(trimmedText) && !validator.IsPasswordValid(trimmedText))
                {
                    lblPassword.Visible = true;
                    lblPassword.Text = "Mínimo ocho y máximo 10 caracteres, al menos una letra mayúscula, una letra minúscula, un número y un carácter especial";
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

            return isValid;
        }
    
}
}