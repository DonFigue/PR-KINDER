﻿using Freireland.Model;
using Freireland.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Freireland.Tools;
using System.Xml.Linq;

namespace LaCasitaDeFreireWeb.Pages.Student
{
    public partial class StudentCreate : System.Web.UI.Page
    {
        Person p;
        StudentImpl studentImpl;
        Students t;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }
            try
            {

                t = new Students(txtCode.Text, txtFirstName.Text, txtLastName.Text, txtSecondLastName.Text, 
                    txtCI.Text, char.Parse(rdbGender.SelectedValue), txtPlaceOfBirth.Text, txtAddress.Text, 
                    DateTime.Parse(txtBirthDate.Text), txtDiscapacity.Text, 1);
                studentImpl = new StudentImpl();
                int n = studentImpl.Insert(t);
                if (n > 0)
                {
                    
                    Response.Redirect("Student.aspx");

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

            /*if (!validator.IsValidGender(rdbGender.SelectedValue))
            {
                lblGenero.Visible = true;
                lblGenero.Text = "Debes seleccionar un género.";
                isValid = false;
            }*/


            if (string.IsNullOrWhiteSpace(txtCode.Text.Trim()))
            {
                lblCodeError.Visible = true;
                lblCodeError.Text = "Es obligatorio llenar el campo codigo estudiante.";
                isValid = false;
            }
            else
            {
                lblCodeError.Visible = true;
                lblCodeError.Text = "";

                string trimmedText = txtCode.Text.Trim();
                if (!string.IsNullOrWhiteSpace(trimmedText) && !validator.ValidateStudentCode(trimmedText))
                {
                    lblCodeError.Visible = true;
                    lblCodeError.Text = "El codigo debe tener 3 letras al principio seguido de 7 numeros.";
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

            if (string.IsNullOrWhiteSpace(txtDiscapacity.Text.Trim()))
            {
                lblDiscapacity.Visible = true;
                lblDiscapacity.Text = "Es obligatorio llenar el campo discapacidad.";
                isValid = false;
            }
            else
            {
                lblDiscapacity.Visible = true;
                lblDiscapacity.Text = "";
                if (!validator.CheckOnlyText(txtDiscapacity.Text.Trim()))
                {
                    lblDiscapacity.Visible = true;
                    lblDiscapacity.Text = "El campo dispacidad debe ser solo letras.";
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
    }
}