﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Tools
{
    public class EnvMail
    {
        public bool EnvioGmail(string mail, string userName, string password)
        {
            MailMessage ms = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            ms.From = new MailAddress("borissejas9@gmail.com");
            ms.To.Add(new MailAddress(mail));

            ms.Subject = "Credenciales";

            string html = "<!DOCTYPE html> <html lang=\"en\"> <head> <meta charset=\"UTF-8\"> <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\"> <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"> <title>Document</title> </head> <body> <h1> BIENVENIDOS </h1><h3> Credenciales: </h3> <p>Nombre de Usuario: " + userName + " </p> <p>Contraseña: " + password + " </p> <p>Por seguridad no comparta su contraseña</p> </body> </html>";

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8, MediaTypeNames.Text.Html);
            ms.AlternateViews.Add(htmlView);


            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;


            smtp.Credentials = new NetworkCredential("borissejas9@gmail.com", "jnzs kjnu zlro cfox");

            smtp.EnableSsl = true;

            try
            {
                smtp.Send(ms);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
