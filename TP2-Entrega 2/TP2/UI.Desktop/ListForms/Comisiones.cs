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
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
        
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
        public void Listar()
        {
            ComisionesLogic cl= new ComisionesLogic();
            //dgvComisiones.DataSource = ul.GetAll();
            try
            {
                dgvComisiones.DataSource = cl.GetAll();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nError Interno: ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Id.DataPropertyName = "ID";
            descripcion.DataPropertyName = "DescComision";
            anioEspecialidad.DataPropertyName = "AnioEspecialidad"; 
            idplan.DataPropertyName = "IdPlan";


        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tlComisiones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ComisionesDesktop ud = new ComisionesDesktop(ApplicationForm.ModoForm.Alta);
                ud.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nError Interno: " + Ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Listar();
            }
        }

        private void tsbEdiar_Click(object sender, EventArgs e)
        {
            if (dgvComisiones.SelectedRows != null)
            {
                int id = ((Business.Entities.Comisiones)dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    ComisionesDesktop ud = new ComisionesDesktop(ApplicationForm.ModoForm.Modificacion, id);
                    ud.ShowDialog();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nError Interno: " + Ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Listar();
                }
            }
            else if (dgvComisiones.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Comision\n para edirar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComisiones.SelectedRows != null)
            {
                int id = ((Business.Entities.Comisiones)dgvComisiones.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    ComisionesDesktop ud = new ComisionesDesktop(ApplicationForm.ModoForm.Baja, id);
                    ud.ShowDialog();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nError Interno: " + Ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Listar();
                }
            }
            else if (dgvComisiones.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione una Comision\n para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvComisiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 
