using Freireland.Implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaCasitaDeFreireWeb.Pages.Login
{
    public partial class Login : System.Web.UI.Page
    {
        UserImpl user;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    user = new UserImpl();
                    DataTable dt = user.Login(txtUser.Text, txtPassword.Text);
                    if (dt.Rows.Count > 0)
                    {
                        Session["id"] = dt.Rows[0][0].ToString();
                        Session["login"] = true;

                        ConfirmUser(dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString());
                    }
                    else
                    {
                        lblError.Text = "Usuario o Contraseña Incorrecta";
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                lblError.Text = "Llene todos los campos";
            }

        }

        void ConfirmUser(string firstLogin, string role)
        {
            switch (firstLogin)
            {
                case "0":
                    Response.Redirect("PasswordChange.aspx");
                    break;
                case "1":

                    Response.Redirect("/Default.aspx");

                    break;
            }
        }
    }
}