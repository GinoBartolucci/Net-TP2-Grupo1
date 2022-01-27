using Business.Logic;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities; 

namespace UI.Web
{
    public partial class Reporte_Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      
            Usuario alumnoActual = (Usuario)Session["current_user"];
           
            var reporte = new ReporteAlumnoLogic().GetReportesDelAlumno(alumnoActual.ID);

            this.Reporte_AlumnoViewer.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("Reporte_AlumnoViewer", reporte);
          
 

            this.Reporte_AlumnoViewer.LocalReport.ReportEmbeddedResource = "UI.Web.ReporteAlumno.rdlc";
             this.Reporte_AlumnoViewer.LocalReport.DataSources.Add(rds);

            this.Reporte_AlumnoViewer.LocalReport.Refresh();

      

        }
    }
}
