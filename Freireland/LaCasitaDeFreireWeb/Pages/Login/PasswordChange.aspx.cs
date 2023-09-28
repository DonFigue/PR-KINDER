using Freireland.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaCasitaDeFreireWeb.Pages.Login
{
    public partial class PasswordChange : System.Web.UI.Page
    {
        UserImpl user;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                user = new UserImpl();

                if (txtPassword.Text == txtPasswordConfirm.Text)
                {
                    int row = user.updatePasswordChange(short.Parse(Session["id"].ToString()), txtUser.Text, txtPassword.Text, txtOldPassword.Text);
                    if (row > 0)
                    {
                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        lblError.Text = "La antigua contraseña no es correcta vuelva intentarlo";
                    }
                }
                else
                {
                    lblError.Text = "Las contraseñas no coinciden vuelva intentarlo";
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}