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

        public SelectCurso()
        {
            InitializeComponent();
            this.dgvSelectCurso.AutoGenerateColumns = false;
        }
        public int IdCurso { get; set; }
        

        public void Listar()
        {
            try
            {
                if (Session.currentUser.TipoPersona == 3)
                {
                    //Trae de la base los cursos de este año
                    List<Curso> listaCursos = CursoLogic.GetInstance().GetAllYear(Int32.Parse(DateTime.Now.ToString("yyyy")));    
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
                    //Habrir selectcurso para seleccionar los cursos en los que da clase el profesor
                    List<Curso> listaCursos = CursoLogic.GetInstance().GetAllDoc(Session.currentUser.IdPersona);
                    if (listaCursos.Count == 0)
                    {
                        MessageBox.Show("No hay cursos en los que dicte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                    Cupo.Visible = false;
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
            AnioCalendario.DataPropertyName = "anio_calendario";            
            descComision.DataPropertyName = "descComision";
            descMateria.DataPropertyName = "descMateria";
            descPlan.DataPropertyName = "descPlan";
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
        
    }
}
