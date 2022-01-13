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
using UI.Desktop.DesktopsForms;


namespace UI.Desktop.ABMListForms
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
            if (Session.currentUser.TipoPersona ==3)
            {
                tsMaterias.Visible = false; //si es alumno saca los abm
                IdPlan.Visible = false;
            }
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
            MateriaLogic m1 = new MateriaLogic();
            try
            {
                if (Session.currentUser.TipoPersona == 3)
                {
                    this.dgvMaterias.DataSource = MateriaLogic.GetInstance().GetAllPlan(Session.currentUser.IdPlan);
                }
                else
                {
                    this.dgvMaterias.DataSource = MateriaLogic.GetInstance().GetAll();
                }

            }
            catch (Exception e)
            {
                NotificarError(e);
            }
            idMateria.DataPropertyName = "ID";
            DescMateria.DataPropertyName = "DescMateria";
            HsSemanales.DataPropertyName = "HorasSemanales";
            HsTotales.DataPropertyName = "HorasTotales";
            IdPlan.DataPropertyName = "IdPlan";// no se ve
        }


        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void tlMateria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaDesktop ud = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
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

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count != 0)
            {
                int id = ((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    MateriaDesktop ud = new MateriaDesktop(ApplicationForm.ModoForm.Modificacion,id);
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
            else if (dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error", "Seleccione una mteria\n para editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows != null)
            {
                int id = ((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    MateriaDesktop ud = new MateriaDesktop(ApplicationForm.ModoForm.Baja,id);
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
            else if (dgvMaterias.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione una materia\n para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
