using Freireland.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaCasitaDeFreireWeb.Pages.Tutor
{
    public partial class TutorUpdate : System.Web.UI.Page
    {
        TutorImpl impl;
        Freireland.Model.Tutor t;
        int mid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];
                if (!string.IsNullOrEmpty(id))
                {
                mid = int.Parse(id);
                    impl = new TutorImpl();
                    t = new Freireland.Model.Tutor();
                    t = impl.GET(int.Parse(id));
                    t.Id = int.Parse(id);
                    txtFirstName.Text = t.FirstName;
                    txtLastName.Text = t.LastName;
                    txtSecondLastName.Text = t.SecondLastName;
                    txtCI.Text = t.CI;
                    txtEmail.Text = t.Email;
                    txtCellphone.Text = t.Cellphone;
                    txtBirthDate.Text = t.Birthdate.ToString();
                    txtAddress.Text = t.Address;
                    txtBusinessName.Text = t.BusinessName;
                    txtNIT.Text = t.NIT;
                    txtWorkPlace.Text = t.WorkPlace;
                    txtPlaceOfBirth.Text = t.PlaceOfBirth;
                    txtProfession.Text = t.Profession;

                }
                else
                {

                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            impl = new TutorImpl();
            t = new Freireland.Model.Tutor();
           
            try
            {
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
                int n = impl.Update(t);
                if (n != 0)
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