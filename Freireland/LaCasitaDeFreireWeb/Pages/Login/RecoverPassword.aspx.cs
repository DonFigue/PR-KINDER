using Freireland.Implementation;
using Freireland.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaCasitaDeFreireWeb.Pages.Login
{
    public partial class RecoverPassword : System.Web.UI.Page
    {
        EnvMail mail;
        UserImpl user;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            try
            {
                mail = new EnvMail();
                user = new UserImpl();
                string password = GenerarContraseña(8);
                
                if(mail.EnvioGmail(txtMail.Text, txtUser.Text, password))
                {
                    int row = user.UpdateRecoverPassword(txtUser.Text,password);
                    if (row > 0)
                    {
                        Response.Redirect("Login.aspx");
                    }
                }
                else
                {
                    lblError.Text = "Error al mandar la contraseña al correo";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string GenerarContraseña(int longitud)
        {
            const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();

            var contraseña = new string(Enumerable.Repeat(caracteresPermitidos, longitud)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return contraseña;
        }
    }
}