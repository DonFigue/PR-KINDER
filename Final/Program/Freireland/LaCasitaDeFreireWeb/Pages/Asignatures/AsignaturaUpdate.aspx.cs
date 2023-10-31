using Freireland.Implementation;
using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace LaCasitaDeFreireWeb.Pages.Asignatures
{
    public partial class AsignaturaUpdate : System.Web.UI.Page
    {
        AsignatureImpl asignatureImpl;
        Asignaturee s;
        byte id;
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCombo();



            if (!IsPostBack)
            {
                string id = Request.QueryString["Id"];
                if (!string.IsNullOrEmpty(id))
                {

                    asignatureImpl = new AsignatureImpl();
                    s = new Asignaturee();
                    s = asignatureImpl.Get(byte.Parse(id));
                    s.Id = byte.Parse(id);
                    txtCodeAsignature.Text = s.CodeAsignaturee;
                    txtNameAsignature.Text = s.NameAsignaturee;
                    cmbArea.SelectedValue = s.AreaID.ToString();
                    cmbGrade.SelectedValue = s.GradeID.ToString();


                }
                else
                {

                }
            }
        }

        void CargarCombo()
        {
            cmbArea.DataTextField = "areaName";
            asignatureImpl = new AsignatureImpl();
            List<Area> areas = asignatureImpl.ObtenerDatosArea();
            cmbArea.DataSource = areas;
            cmbArea.DataBind();

            cmbGrade.DataTextField = "nameGrade";
            //cmbGrade.DataValueField = "id"; // Asegúrate de establecer el campo de valor adecuado
            List<Grades> grades = asignatureImpl.ObtenerDatosGrados();
            cmbGrade.DataSource = grades;
            cmbGrade.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            //--------------------------------------------
            string newAreaName = cmbArea.Text;
            string newGradeName = cmbGrade.Text;
            asignatureImpl = new AsignatureImpl();

            try
            {
                //Buscar los nuevos objetos Area y grado
                Area newArea = null;
                foreach (Area area in asignatureImpl.ObtenerDatosArea())
                {
                    if (area.areaName == newAreaName)
                    {
                        newArea = area;
                        break;
                    }
                }

                Grades newGrade = null;
                foreach (Grades grade in asignatureImpl.ObtenerDatosGrados())
                {
                    if (grade.nameGrade == newGradeName)
                    {
                        newGrade = grade;
                        break;
                    }
                }

                

                s = new Asignaturee();

                s.Id = byte.Parse(Request.QueryString["Id"]);
                s.CodeAsignaturee = txtCodeAsignature.Text;
                s.NameAsignaturee = txtNameAsignature.Text;
                s.AreaID = newArea.Id;
                s.GradeID = newGrade.Id;

                int n = asignatureImpl.Update(s);
                if (n > 0)
                {
                    Response.Redirect("AsignatureIndex.aspx");
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}