using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class ReporteNotas : Form
    {
        public ReporteNotas()
        {
            InitializeComponent();
        }

        private void ReporteNotas_Load(object sender, EventArgs e)
        {
            ReporteAlumnoBindingSource.DataSource = ReporteAlumnoLogic.GetInstance().GetReporteAlumno(Session.currentUser);
            this.reportViewer1.RefreshReport();
        }
    }
}
