using Freireland.Implementation;
using Freireland.Model;
using Freireland.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace LaCasitaDeFreireWeb.Pages.Teacher
{
    public partial class TeacherUpdate : System.Web.UI.Page
    {
        Teachers t;
        TeacherImpl impl;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];
                if (!string.IsNullOrEmpty(id))
                {

                    impl = new TeacherImpl();
                    t = new Teachers();
                    t = impl.Get(short.Parse(id));
                    txtFirstName.Text = t.FirstName;
                    txtLastName.Text = t.LastName;
                    txtCI.Text = t.CI;
                    txtCellphone.Text = t.phone;
                    txtAddress.Text = t.Address;
                    txtSecondLastName.Text = t.SecondLastName;
                    txtPlaceOfBirth.Text = t.PlaceOfBirth;
                    txtBirthDate.Text = t.Birthdate.ToString();
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

            if (!validator.IsValidGender(rdbGender.SelectedValue))
            {
                lblGenero.Visible = true;
                lblGenero.Text = "Debes seleccionar un género.";
                isValid = false;
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

            return isValid;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            impl = new TeacherImpl();
            t = new Teachers();

            try
            {
                t.Id = short.Parse(Request.QueryString["id"]);
                t.FirstName = txtFirstName.Text;
                t.LastName = txtLastName.Text;
                t.SecondLastName = txtSecondLastName.Text;
                t.CI = txtCI.Text;
                t.Address = txtAddress.Text;
                t.Birthdate = DateTime.Parse(txtBirthDate.Text);
                t.Gender = char.Parse(rdbGender.SelectedValue);
                t.PlaceOfBirth = txtPlaceOfBirth.Text;
                t.phone = txtCellphone.Text;
                t.Id = short.Parse(Request.QueryString["id"]);
                int n = impl.Update(t);
                if (n > 0)
                {
                    Response.Redirect("TeacherIndex.aspx");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}