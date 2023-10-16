using Freireland.Implementation;
using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaCasitaDeFreireWeb.Pages.Student
{
    public partial class UnPaid : System.Web.UI.Page
    {
        Payment t;
        PaymentImpl impl;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];
                string st = Request.QueryString["ST"];
                //int ist = 0;
                //ist = int.Parse(st);
                if (!string.IsNullOrEmpty(id))
                {
                    int mid = int.Parse(id);
                    impl = new PaymentImpl();
                    int n = impl.UnPaid(mid);
                    if (n > 0)
                    {

                        Response.Redirect("Payments.aspx?ID=" + st);

                    }
                }
                else
                {

                }
            }
        }
    }
}