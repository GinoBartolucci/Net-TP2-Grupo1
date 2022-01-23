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
        private static Comisiones singleton;
        public static Comisiones GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Comisiones();
            }
            return singleton;
        }
        public Comisiones()
        {        
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
        }
        public int SelectIdComision { get; set; }
        public string SelectDescComision { get; set; }
        public string SelectDescEspecialidad { get; set; }

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
            ComisionesLogic cl= new ComisionesLogic();
            try
            {
                dgvComisiones.DataSource = cl.GetAll();
            }
            catch (Exception Error)
            {
                NotificarError(Error);
            }

            Id.DataPropertyName = "ID";
            descripcion.DataPropertyName = "DescComision";
            anioEspecialidad.DataPropertyName = "AnioEspecialidad"; 
            desc_plan.DataPropertyName = "DescPlan";
            desc_specialidad.DataPropertyName = "DescEspecialidad";

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
            catch (Exception Error)
            {
                NotificarError(Error);
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
                catch (Exception Error)
                {
                    NotificarError(Error);
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
                catch (Exception Error)
                {
                    NotificarError(Error);
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvComisiones.SelectedRows.Count != 0)
            {
                // al seleccionar un curso traer todas las personas que estan en ese curso haceindo un join entre inscripciones alumno y personas
                SelectIdComision = ((Business.Entities.Comisiones)dgvComisiones.SelectedRows[0].DataBoundItem).ID; // selecciona toda la linea y solo asigna id_curso
                SelectDescComision = ((Business.Entities.Comisiones)dgvComisiones.SelectedRows[0].DataBoundItem).DescComision;
                SelectDescEspecialidad = ((Business.Entities.Comisiones)dgvComisiones.SelectedRows[0].DataBoundItem).DescEspecialidad;
                DialogResult = DialogResult.OK;
                Close();

            }
            else if (dgvComisiones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error", "Seleccione una Materia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
 
