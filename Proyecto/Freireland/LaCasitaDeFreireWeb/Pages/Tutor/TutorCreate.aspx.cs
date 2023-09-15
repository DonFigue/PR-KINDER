using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Freireland.Implementation;
using Freireland.Model;
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
    }
}