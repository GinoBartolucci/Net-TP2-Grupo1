using Business.Logic;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class ReporteCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 this.LoadReporteCursos();
            }
        }
        private void LoadReporteCursos()
        {
            
           var reporte =  InscripcionLogic.GetInstance().ReporteCursos();
            this.ReportesCursos.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("ReporteCursos", reporte);
            this.ReportesCursos.LocalReport.ReportEmbeddedResource = "UI.Web.ReportViewerCursos.rdlc";
            this.ReportesCursos.LocalReport.DataSources.Add(rds);
            this.ReportesCursos.LocalReport.Refresh();
        }
       
    }
}