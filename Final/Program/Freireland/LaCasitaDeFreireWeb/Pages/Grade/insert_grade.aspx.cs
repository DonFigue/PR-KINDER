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

namespace LaCasitaDeFreireWeb.Pages.Grade
{
    public partial class insert_grade : System.Web.UI.Page
    {
        GradeImpl gradeImpl;
        Grades t;
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

                t = new Grades( txtGrade.Text, cmbParallel.SelectedValue.ToString(), cmbLevel.SelectedValue.ToString(), decimal.Parse(txtPrice.Text) , 1);
                gradeImpl = new GradeImpl();
                int n = gradeImpl.Insert(t);
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

            if (!validator.IsValidGender(cmbLevel.SelectedValue))
            {
                lblLevelError.Visible = true;
                lblLevelError.Text = "Debes seleccionar un Nivel.";
                isValid = false;
            }

            if (!validator.IsValidGender(cmbParallel.SelectedValue))
            {
                lblParallelError.Visible = true;
                lblParallelError.Text = "Debes seleccionar un Paralelo.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtGrade.Text.Trim()))
            {
                lblGradeError.Visible = true;
                lblGradeError.Text = "Es obligatorio llenar el campo nombre del Curso.";
                isValid = false;
            }
            else
            {
                lblGradeError.Visible = true;
                lblGradeError.Text = "";
                isValid = true;
            }
            return isValid;
        }
    }
}