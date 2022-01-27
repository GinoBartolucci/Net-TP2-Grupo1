using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.ABMListForms;
using UI.Desktop.SelectForms;
using UI.Desktop.DesktopsForms;
using Business.Entities;


namespace UI.Desktop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Login lg = new Login();   
            if(lg.ShowDialog() != DialogResult.OK) //Si no logeo correctamente cierra el form
            {
                Close();
            }
            else
            {
                switch (Session.currentUser.TipoPersona)
                {
                    case 1:
                        AdminDisplay();
                        break;
                    case 2:
                        DocentesDisplay();
                        break;
                    case 3:
                        AlumnosDisplay();
                        break;
                    default:
                        break;

                }
            }
        }
        private void AlumnosDisplay()
        {
            lblNombre.Text = "Alumno: "+ Session.currentUser.NombreCompleto;
            lblPlan.Text = Session.currentUser.DescPlan;
            lblEspecialidad.Text = Session.currentUser.DescEspecialidad;
            //Muestra u oculta para alumnos:
            btnListadoAlumnos.Visible = false;
            btnCargarNotas.Visible = false;
            btnDictado.Visible = false;

            btnABMUsuario.Visible = false;
            btnABMPlanes.Visible = false;
            btnABMEspecialidad.Visible = false;
            btnABMComision.Visible = false;
            btnABMCurso.Visible = false;
            btnABMMateria.Visible = false;
            btnABMDictadoDocentes.Visible = false;
        }
        private void DocentesDisplay() 
        { 
            lblNombre.Text = "Docente: "+ Session.currentUser.NombreCompleto;
            lblPlan.Text = Session.currentUser.DescPlan;
            lblEspecialidad.Text = Session.currentUser.DescEspecialidad;
            //muestra u oculta para docentes
            btnNotasAlumno.Visible = false;
            btnIncribirse.Visible = false;
            btnMateriasPlanAlumno.Visible = false;
            btnCursadoAlumno.Visible = false;

            btnABMUsuario.Visible = false;
            btnABMPlanes.Visible = false;
            btnABMEspecialidad.Visible = false;
            btnABMComision.Visible = false;
            btnABMCurso.Visible = false;
            btnABMMateria.Visible = false;
            btnABMDictadoDocentes.Visible = false;
        }

        private void AdminDisplay()
        {
            btnListadoAlumnos.Visible = false;
            btnCargarNotas.Visible = false;
            btnDictado.Visible = false;

            btnNotasAlumno.Visible = false;
            btnIncribirse.Visible = false;
            btnMateriasPlanAlumno.Visible = false;
            btnCursadoAlumno.Visible = false;
        }             

        //ALUMNO
        //reporte
        private void btnNotasAlumno_Click(object sender, EventArgs e)// REPORTE
        {
            //REPORTE
            ReporteNotas reporte = new ReporteNotas();
            reporte.ShowDialog();
        }
        private void btnIncribirse_Click(object sender, EventArgs e)
        {
            InscripcionesAlumnosDesktop nuevaInscripcion = new InscripcionesAlumnosDesktop(InscripcionesAlumnosDesktop.ModoForm.Alta);
            nuevaInscripcion.ShowDialog();
            if (nuevaInscripcion.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Inscripcion Correcta", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void btnMateriasPlanAlumno_Click(object sender, EventArgs e)
        {
            ABMListForms.Materias m = new ABMListForms.Materias();
            m.ShowDialog();
        }
        private void btnCursadoAlumno_Click(object sender, EventArgs e)
        {
            InscripcionesAlumnos.GetInstance().ShowDialog(); 
        }

        //PROFESORES
        private void btnListadoAlumnos_Click(object sender, EventArgs e)
        {
            //Muestra los cursos en los que el docente da clases
            //selecciona el curso luego muestra las inscipciones de este año para ese curso sin los botones abm
            SelectCurso listadoAlumnos = new SelectCurso();
            listadoAlumnos.ShowDialog();
            if (listadoAlumnos.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Error al seleccionar Curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InscripcionesAlumnos inscripcionesListado = new InscripcionesAlumnos(InscripcionesAlumnos.ModoF.Lista, listadoAlumnos.IdCurso);
            inscripcionesListado.ShowDialog();
        }
        private void btnCargarNotas_Click(object sender, EventArgs e)
        {
            //Muestra los cursos en los que el docente da clases
            //selecciona el curso luego abre las inscripciones de este año para ese curso con el boton editar habilitado
            //Que no muestre los alumnos que ya esten aprobados, que muestre los cursos de todos los años
            SelectCurso listadoAlumnos = new SelectCurso();
            listadoAlumnos.ShowDialog();
            if (listadoAlumnos.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Error al seleccionar Curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InscripcionesAlumnos inscripcionesNotas = new InscripcionesAlumnos(InscripcionesAlumnos.ModoF.Nota, listadoAlumnos.IdCurso);
            inscripcionesNotas.ShowDialog();
        }
        private void btnDictado_Click(object sender, EventArgs e)
        {
            DocentesCursos.GetInstance().ShowDialog();
        }

        private void btnABMUsuario_Click(object sender, EventArgs e)
        {
            Usuarios.GetInstance().ShowDialog();
        }

        private void btnABMPlanes_Click(object sender, EventArgs e)
        {
            Planes.GetInstance().ShowDialog();
        }

        private void btnABMEspecialidad_Click(object sender, EventArgs e)
        {
            Especialidades.GetInstance().ShowDialog();
        }

        private void btnABMComision_Click(object sender, EventArgs e)
        {
            Comisiones.GetInstance().ShowDialog();
        }

        private void btnABMCurso_Click(object sender, EventArgs e)
        {
            SelectCurso.GetInstance().ShowDialog();
        }

        private void btnABMMateria_Click(object sender, EventArgs e)
        {
            Materias.GetInstance().ShowDialog();
        }

        private void btnABMDictadoDocentes_Click(object sender, EventArgs e)
        {
            DocentesCursos.GetInstance().ShowDialog();
        }

        private void btnContrasenia_Click(object sender, EventArgs e)
        {
            CambiarPassword.GetInstance().ShowDialog();
        }

        //ADMIN

    }
}
