using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;


namespace UI.Desktop
{
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false;
        }
        public void NotificarError(Exception Error)
        {
            var msError = "Error message: " + Error.Message;
            if (Error.InnerException != null)
            {
                msError = msError + "\nInner exception: " + Error.InnerException.Message;
            }
            msError = msError + "\nStack trace: " + Error.StackTrace;
            MessageBox.Show(msError, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Listar()
        {
            PlanesLogic pl = new PlanesLogic();
            try
            {
                dgvPlanes.DataSource = pl.GetAll();
            }
            catch (Exception Error)
            {
                NotificarError(Error);
            }
            id_planes.DataPropertyName = "ID";
            desc_plan.DataPropertyName = "desc_plan";
            id_especialidad.DataPropertyName = "id_especialidad";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPlanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }        

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                PlanesDesktop pd = new PlanesDesktop(ApplicationForm.ModoForm.Alta);
                pd.ShowDialog();
            }
            catch (Exception Error)
            {
                NotificarError(Error);
            }
            finally
            {
                Listar();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.SelectedRows != null)
            {
                int id = ((Business.Entities.Planes)dgvPlanes.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    PlanesDesktop pd = new PlanesDesktop(ApplicationForm.ModoForm.Modificacion, id);
                    pd.ShowDialog();
                }
                catch (Exception Error)
                {
                    NotificarError(Error);
                }
                finally
                {
                    Listar();
                }
            }
            else if (dgvPlanes.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Usuario\n para edirar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlanes.SelectedRows != null)
            {
                int id = ((Business.Entities.Planes)dgvPlanes.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    PlanesDesktop pd = new PlanesDesktop(ApplicationForm.ModoForm.Baja, id);
                    pd.ShowDialog();
                }
                catch (Exception Error)
                {
                    NotificarError(Error);
                }
                finally
                {
                    Listar();
                }
            }
            else if (dgvPlanes.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Usuario\n para edirar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
