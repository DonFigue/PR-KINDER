using Freireland.Implementation;
using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaCasitaDeFreireWeb.Pages.Asignatures
{
    public partial class AsignatureCreate : System.Web.UI.Page
    {
        AsignatureImpl asignatureImp;
        Asignaturee a;
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }
     
        void CargarCombo()
        {
            cmbArea.DataTextField = "areaName";
            asignatureImp = new AsignatureImpl();
            List<Area> areas = asignatureImp.ObtenerDatosArea();
            cmbArea.DataSource = areas;
            cmbArea.DataBind();

            cmbGrade.DataTextField = "nameGrade";
           //cmbGrade.DataValueField = "id"; // Asegúrate de establecer el campo de valor adecuado
            List<Grades> grades = asignatureImp.ObtenerDatosGrados();
            cmbGrade.DataSource = grades;
            cmbGrade.DataBind();
        }


        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //ListItem item = cmbArea.SelectedItem;

            //Area area = (Area)item; // as Area;

            string xxx = cmbArea.SelectedItem.Value;

            asignatureImp = new AsignatureImpl();
            List<Area> areas = asignatureImp.ObtenerDatosArea();

            byte areaid = 0;
            foreach(Area area1 in areas) 
            {
                if (area1.areaName == xxx)
                {
                    areaid = area1.Id;

                    break;
                }
            }

            string ggg = cmbGrade.SelectedItem.Value;
            asignatureImp = new AsignatureImpl();
            List<Grades> grades = asignatureImp.ObtenerDatosGrados();
            short gradeid = 0;
            foreach (Grades grade in grades)
            {
                if (grade.nameGrade == ggg)
                {
                    gradeid = grade.Id;
                    break;
                }
            }


            //Freireland.Model.Area area = (Freireland.Model.Area)cmbArea.Items[cmbArea.SelectedIndex];

            a = new Asignaturee(txtNameAsignature.Text, areaid,gradeid, txtCodeAsignature.Text);
            //a = new Asignaturee(txtNameAsignature.Text, ((Area)cmbArea.SelectedItem)[cmbArea.SelectedIndex])).AreaID, txtCodeAsignature.Text);
                asignatureImp = new AsignatureImpl();
                int n = asignatureImp.Insert(a);
                if (n > 0)
                {
                    Response.Redirect("AsignatureIndex.aspx");
                }
            
            
        }
    }
}