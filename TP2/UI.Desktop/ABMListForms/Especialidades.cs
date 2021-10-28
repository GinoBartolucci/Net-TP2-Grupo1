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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
            dgvEspecialidades.AutoGenerateColumns = false;
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
            EspecialidadesLogic el= new EspecialidadesLogic();
            this.dgvEspecialidades.DataSource = el.GetAll();
            id_especialidades.DataPropertyName = "ID";
            desc_especialidades.DataPropertyName = "desc_especialidad";
        }

        private void especialidades_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                EspecialidadDesktop ed = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
                ed.ShowDialog();
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

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows != null)
            {
                int id = ((Business.Entities.Especialidades)dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    EspecialidadDesktop ed = new EspecialidadDesktop(id, ApplicationForm.ModoForm.Modificacion);
                    ed.ShowDialog();
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
            else if (dgvEspecialidades.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Usuario\n para edirar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvEspecialidades.SelectedRows != null)
            {
                int id = ((Business.Entities.Especialidades)dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    EspecialidadDesktop ed = new EspecialidadDesktop(id, ApplicationForm.ModoForm.Baja);
                    ed.ShowDialog();
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
            else if (dgvEspecialidades.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Usuario\n para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
