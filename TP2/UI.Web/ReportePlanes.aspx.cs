using Business.Logic;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
 
namespace UI.Web
{
    public partial class ReportePlanes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
            this.LoadReportePlanes();
 
        }
        private void LoadReportePlanes()
        {
   
            // var dt = InscripcionLogic.GetAll();
            this.ReportViewer1.LocalReport.DataSources.Clear();
           // ReportDataSource rds = new ReportDataSource("ReportePlanes",dt);
            this.ReportViewer1.LocalReport.ReportEmbeddedResource = "UI.Web.ReportViewerPlanes.rdlc";
           // this.ReportViewer1.LocalReport.DataSources.Add(rds);
            this.ReportViewer1.LocalReport.Refresh();
        

        }
    }
}