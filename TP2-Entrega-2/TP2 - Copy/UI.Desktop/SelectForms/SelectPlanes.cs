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
    public partial class SelectPlanes : Form
    {
        public SelectPlanes()
        {
            InitializeComponent();
            this.dgvSelectPlanes.AutoGenerateColumns = false;
        }
        public int idSelectPlan { get; set; }
        public string descSelectPlan { get; set; }
        public void Listar()
        {            
            try
            {
                PlanesLogic pl = new PlanesLogic();
                dgvSelectPlanes.DataSource = pl.GetAll();
            }
            catch (Exception Error)
            {
                var msError = "Error message: " + Error.Message;
                if (Error.InnerException != null)
                {
                    msError = msError + "\nInner exception: " + Error.InnerException.Message;
                }
                msError = msError + "\nStack trace: " + Error.StackTrace;
                MessageBox.Show(msError, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            id_plan.DataPropertyName = "ID";
            desc_plan.DataPropertyName = "desc_plan";
            id_especialidad.DataPropertyName = "id_especialidad";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvSelectPlanes.SelectedRows != null)
            {
                idSelectPlan = ((Business.Entities.Planes)dgvSelectPlanes.SelectedRows[0].DataBoundItem).ID;
                descSelectPlan = ((Business.Entities.Planes)dgvSelectPlanes.SelectedRows[0].DataBoundItem).desc_plan;
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (dgvSelectPlanes.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectPlanes_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
