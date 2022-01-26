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

namespace UI.Desktop.SelectForms
{
    public partial class SelectCurso : Form
    {
        private static SelectCurso singleton;
        public static SelectCurso GetInstance()
        {
            if (singleton == null)
            {
                singleton = new SelectCurso();
            }
            return singleton;
        }

        public SelectCurso(int? idPlan = null)
        {
            InitializeComponent();
            this.dgvSelectCurso.AutoGenerateColumns = false;
            Modo = ModoForm.Select;
            if (idPlan != null)
            {
                IdPlan = idPlan.Value;
                Modo = ModoForm.SelectIdPlan;
            }
        }
        public enum ModoForm
        {
            SelectIdPlan, Select
        }
        private ModoForm _Modo;
        public ModoForm Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }
        public int IdPlan{ get; set; }
        public int IdCurso { get; set; }
        public string DescComision { get; set; }
        public string DescMateria { get; set; }

        public void Listar()
        {
            try
            {
                if (Session.currentUser.TipoPersona == 3)
                {
                    tsCurso.Visible = false;
                    //Trae de la base los cursos de este año
                    List<Curso> listaCursos = CursoLogic.GetInstance().GetAllYearPlan(Int32.Parse(DateTime.Now.ToString("yyyy")), Session.currentUser.IdPlan);    
                    listaCursos = BusinessRules.ValidarCursosAlumnos(listaCursos);
                    this.dgvSelectCurso.DataSource = listaCursos;                    
                 
                    if (listaCursos.Count == 0)
                    {
                        MessageBox.Show("No quedan mas Cursos en los que puedas inscribirte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                } 
                if (Session.currentUser.TipoPersona == 2)
                {
                    tsCurso.Visible = false;
                    //Habrir selectcurso para seleccionar los cursos en los que da clase el profesor
                    List<Curso> listaCursos = CursoLogic.GetInstance().GetAllDoc(Session.currentUser.IdPersona);
                    this.dgvSelectCurso.DataSource = listaCursos;
                    if (listaCursos.Count == 0)
                    {
                        MessageBox.Show("No hay cursos en los que dicte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                    Cupo.Visible = false;
                }
                if (Session.currentUser.TipoPersona == 1)
                {
                    //Trae de la base los cursos de este año
                    List<Curso> listaCursos = CursoLogic.GetInstance().GetAll();
                    if (Modo == ModoForm.SelectIdPlan)
                    {
                        listaCursos.RemoveAll(item => item.IdPlan !=IdPlan);
                    }
                    this.dgvSelectCurso.DataSource = listaCursos;
                    if (listaCursos.Count == 0)
                    {
                        MessageBox.Show("No quedan mas Cursos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }

            } 
            catch(Exception Error)
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
            id_curso.DataPropertyName = "id_curso";
            anio_especialidad.DataPropertyName = "AnioEspecialidad";
            AnioCalendario.DataPropertyName = "anio_calendario";            
            descComision.DataPropertyName = "DescComision";
            descMateria.DataPropertyName = "DescMateria";
            descPlan.DataPropertyName = "DescPlan";
            Cupo.DataPropertyName = "cupo";


        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {            
            if(dgvSelectCurso.SelectedRows.Count != 0)
            {
                // al seleccionar un curso traer todas las personas que estan en ese curso haceindo un join entre inscripciones alumno y personas
                IdCurso = ((Business.Entities.Curso)dgvSelectCurso.SelectedRows[0].DataBoundItem).id_curso; // selecciona toda la linea y solo asigna id_curso
                DescComision = ((Business.Entities.Curso)dgvSelectCurso.SelectedRows[0].DataBoundItem).DescComision;
                DescMateria = ((Business.Entities.Curso)dgvSelectCurso.SelectedRows[0].DataBoundItem).DescMateria;
                IdPlan = ((Business.Entities.Curso)dgvSelectCurso.SelectedRows[0].DataBoundItem).IdPlan; // selecciona toda la linea y solo asigna id_curso

                DialogResult = DialogResult.OK;
                Close();
                                               
            }
            else if (dgvSelectCurso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error", "Seleccione un Curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
                      
        }

        private void SelectCurso_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                CursosDesktop ud = new CursosDesktop(ApplicationForm.ModoForm.Alta);
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
            if (dgvSelectCurso.SelectedRows.Count != 0)
            {
                int id = ((Curso)dgvSelectCurso.SelectedRows[0].DataBoundItem).id_curso;
                try
                {
                    CursosDesktop ud = new CursosDesktop(ApplicationForm.ModoForm.Modificacion, id);
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
            else if (dgvSelectCurso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error", "Seleccione un Curso\n para editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
