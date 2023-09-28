using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Freireland.Implementation;
using Freireland.Model;
using Freireland.Tools;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace LaCasitaDeFreireWeb.Pages.Tutor
{
    public partial class TutorCreate : System.Web.UI.Page
    {
        Freireland.Model.Tutor t;
        TutorImpl impl;
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
                impl = new TutorImpl();
                t = new Freireland.Model.Tutor();
                t.FirstName = txtFirstName.Text;
                t.LastName = txtLastName.Text;
                t.SecondLastName = txtSecondLastName.Text;
                t.CI = txtCI.Text;
                t.Email = txtEmail.Text;
                t.NIT = txtNIT.Text;
                t.Profession = txtProfession.Text;
                t.BusinessName = txtBusinessName.Text;
                t.Address = txtAddress.Text;
                t.WorkPlace = txtWorkPlace.Text;
                t.Cellphone = txtCellphone.Text;
                t.Birthdate = DateTime.Parse(txtBirthDate.Text);
                t.Gender = char.Parse(rdbGender.SelectedValue);
                t.PlaceOfBirth = txtPlaceOfBirth.Text;
                int n = impl.Insert(t);
                if (n > 0)
                {
                    Response.Redirect("TutorIndex.aspx");
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

            if (string.IsNullOrWhiteSpace(txtAddress.Text.Trim()))
            {
                lblAddress.Visible = true;
                lblAddress.Text = "Es obligatorio llenar el campo direccion.";
                isValid = false;
            }
            else
            {
                lblAddress.Visible = true;
                lblAddress.Text = "";
                if (!validator.CheckOnlyText(txtAddress.Text.Trim()))
                {
                    lblAddress.Visible = true;
                    lblAddress.Text = "La direccion solo debe tener letras.";
                    isValid = false;
                }
            }

           

            if (!validator.IsValidBirthDate(txtBirthDate.Text))
            {
                lblBirthdate.Visible = true;
                lblBirthdate.Text = "La fecha de nacimiento no es válida.";
                isValid = false;
            }
            else
            {
                lblBirthdate.Visible = true;
                lblBirthdate.Text = "";
            }


            if (string.IsNullOrWhiteSpace(txtPlaceOfBirth.Text.Trim()))
            {
                lblPlaceBirth.Visible = true;
                lblPlaceBirth.Text = "Es obligatorio llenar el campo lugar de nacimiento.";
                isValid = false;
            }
            else
            {
                lblPlaceBirth.Visible = true;
                lblPlaceBirth.Text = "";
                if (!validator.CheckOnlyText(txtPlaceOfBirth.Text.Trim()))
                {
                    lblPlaceBirth.Visible = true;
                    lblPlaceBirth.Text = "El lugar de nacimento debe ser solo letraas.";
                    isValid = false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtWorkPlace.Text.Trim()))
            {
                lblWorkPlace.Visible = true;
                lblWorkPlace.Text = "Es obligatorio llenar el campo direccion de trabajo.";
                isValid = false;
            }
            else
            {
                lblWorkPlace.Visible = true;
                lblWorkPlace.Text = "";
                if (!validator.CheckOnlyText(txtWorkPlace.Text.Trim()))
                {
                    lblWorkPlace.Visible = true;
                    lblWorkPlace.Text = "La direccion de trabajo debe ser solo letraas.";
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

            if (string.IsNullOrWhiteSpace(txtProfession.Text.Trim()))
            {
                lblProfession.Visible = true;
                lblProfession.Text = "Es obligatorio llenar el campo profesion.";
                isValid = false;
            }
            else
            {
                lblProfession.Visible = true;
                lblProfession.Text = "";
                if (!validator.CheckOnlyText(txtProfession.Text.Trim()))
                {
                    lblProfession.Visible = true;
                    lblProfession.Text = "La profesion debe ser solo letraas.";
                    isValid = false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtBusinessName.Text.Trim()))
            {
                lblBusinessName.Visible = true;
                lblBusinessName.Text = "Es obligatorio llenar la razon social.";
                isValid = false;
            }
            

            return isValid;
        }
    }
}