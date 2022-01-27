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
        private static Materias singleton;
        public static Materias GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Materias();
            }
            return singleton;
        }
        public Materias(int? idPlan = null)
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
            Text = "Materias";
            Modo = ModoForm.Modo;
            btnSeleccionar.Visible = false;
            if (Session.currentUser.TipoPersona ==3)
            {
                tsMaterias.Visible = false; //si es alumno saca los abm
                btnSeleccionar.Visible = false;
            }
            if(idPlan != null)
            {
                Modo = ModoForm.SelectIdPlan;
                IdPlan = idPlan.Value;
                btnSeleccionar.Visible = true;
                tsMaterias.Visible = false;

            }
        }
        public enum ModoForm
        {
            Modo ,SelectIdPlan
        }
        private ModoForm _Modo;
        public ModoForm Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }
        public int IdPlan { get; set; }
        public int SelectIdMateria { get; set; }
        public string SelectDescMateria { get; set; }
        public string SelectDescEspecialidad{ get; set; }
        public void Listar()
        {
            try
            {
                if (Session.currentUser.TipoPersona == 3)
                {
                    this.dgvMaterias.DataSource = MateriaLogic.GetInstance().GetAllPlan(Session.currentUser.IdPlan);
                    ReporteAlumnoBindingSource.DataSource = ReporteAlumnoLogic.GetInstance().GetReporteAlumno(Session.currentUser);
                    this.reportViewer1.RefreshReport();
                }
                if (Modo == ModoForm.SelectIdPlan) 
                {
                    this.dgvMaterias.DataSource = MateriaLogic.GetInstance().GetAllPlan(IdPlan);
                }
                else if(Session.currentUser.TipoPersona != 3)
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
            desc_plan.DataPropertyName = "DescPlan";
            desc_especialidad.DataPropertyName = "DescEspecialidad";
            //anio_especialidad
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
            this.reportViewer1.RefreshReport();
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count != 0)
            {
                // al seleccionar un curso traer todas las personas que estan en ese curso haceindo un join entre inscripciones alumno y personas
                SelectIdMateria = ((Business.Entities.Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID; // selecciona toda la linea y solo asigna id_curso
                SelectDescMateria = ((Business.Entities.Materia)dgvMaterias.SelectedRows[0].DataBoundItem).DescMateria;
                SelectDescEspecialidad= ((Business.Entities.Materia)dgvMaterias.SelectedRows[0].DataBoundItem).DescEspecialidad;

                DialogResult = DialogResult.OK;
                Close();

            }
            else if (dgvMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error", "Seleccione una Materia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
