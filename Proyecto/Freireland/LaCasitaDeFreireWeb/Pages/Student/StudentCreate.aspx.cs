using Freireland.Model;
using Freireland.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            try
            {

                t = new Students(txtCode.Text, txtFirstName.Text, txtLastName.Text, txtSecondLastName.Text, txtCI.Text, char.Parse(rdbGender.SelectedValue), txtPlaceOfBirth.Text, txtAddress.Text, DateTime.Parse(txtBirthDate.Text), txtDiscapacity.Text, 1);
                studentImpl = new StudentImpl();
                int n = studentImpl.Insert(t);
                if (n > 0)
                {
                    Response.Redirect("Student.aspx");
                    txtCI.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtSecondLastName.Text = "";
                    txtCI.Text = "";
                    txtBirthDate.Text = "";
                    rdbGender.SelectedValue = "";
                    txtPlaceOfBirth.Text = "";
                    txtAddress.Text = "";
                    txtDiscapacity.Text = "";
                    txtPlaceOfBirth.Text = "";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}