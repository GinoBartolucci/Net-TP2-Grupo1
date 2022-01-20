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

namespace UI.Desktop
{
    public partial class DocentesCursos : Form
    {
        private static DocentesCursos singleton;
        public static DocentesCursos GetInstance()
        {
            if (singleton == null)
            {
                singleton = new DocentesCursos();
            }
            return singleton;
        }

        public enum ModoF
        {
            Lista, Nota
        }
        private ModoF _Modo;
        public ModoF Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }

        public DocentesCursos()
        {
            InitializeComponent();
            this.dvgInscripcionesAlumnos.AutoGenerateColumns = false;
            if (Session.currentUser.TipoPersona == 2)//si es docente no ve los botones abm
            {
                tscInscripcionesAlumnos.Visible = false;                
            }
            Listar();
        }       

        public void Listar()
        {
            try
            {
                if (Session.currentUser.TipoPersona == 1)
                {
                    dvgInscripcionesAlumnos.DataSource = Docentes_cursosLogic.GetInstance().GetAll();
                }
                if (Session.currentUser.TipoPersona == 2)
                {
                    this.dvgInscripcionesAlumnos.DataSource = Docentes_cursosLogic.GetInstance().GetAllYearDoc(Session.currentUser.IdPersona, Int32.Parse(DateTime.Now.ToString("yyyy"))); //
                }
            }
            catch (Exception e)
            {
                NotificarError(e);
            }
            id_dictado.DataPropertyName = "id_dictado";
            id_curso.DataPropertyName = "id_curso";
            cargo.DataPropertyName = "Cargo";
            desc_Materia.DataPropertyName = "DescMateria";
            desc_Comision.DataPropertyName = "DescComision";              
            
        }

        private void InscripcionesAlumnos_Load(object sender, EventArgs e)
        {
            //Listar(); 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgInscripcionesAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            InscripcionesAlumnosDesktop ventanaNuevaInscripcion = new InscripcionesAlumnosDesktop(ApplicationForm.ModoForm.Alta);
            ventanaNuevaInscripcion.ShowDialog();
            this.Listar();
        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {
            InscripcionesAlumnosDesktop v1 = new InscripcionesAlumnosDesktop(ApplicationForm.ModoForm.Modificacion, ((Business.Entities.Inscripciones)this.dvgInscripcionesAlumnos.SelectedRows[0].DataBoundItem).ID);
            v1.ShowDialog();
            this.Listar();
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            //No es nesesario
            int ID;
            string textoID = ((Business.Entities.Inscripciones)this.dvgInscripcionesAlumnos.SelectedRows[0].DataBoundItem).ID.ToString();

            ID = int.Parse(textoID);

            InscripcionesAlumnosDesktop ventanaNuevaInscripcion = new InscripcionesAlumnosDesktop(ApplicationForm.ModoForm.Baja, ID);
            ventanaNuevaInscripcion.ShowDialog();
            this.Listar();
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

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                DocentesCursosDesktop ud = new DocentesCursosDesktop(ApplicationForm.ModoForm.Alta);
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

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            if (dvgInscripcionesAlumnos.SelectedRows.Count != 0)
            {
                int id = ((Docentes_cursos)dvgInscripcionesAlumnos.SelectedRows[0].DataBoundItem).id_dictado;
                try
                {
                    DocentesCursosDesktop ud = new DocentesCursosDesktop(ApplicationForm.ModoForm.Modificacion, id);
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
            else if (dvgInscripcionesAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error", "Seleccione un Dictado\n para editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click_1(object sender, EventArgs e)
        {
            if (dvgInscripcionesAlumnos.SelectedRows != null)
            {
                int id = ((Docentes_cursos)dvgInscripcionesAlumnos.SelectedRows[0].DataBoundItem).id_dictado;
                try
                {
                    DocentesCursosDesktop ud = new DocentesCursosDesktop(ApplicationForm.ModoForm.Baja, id);
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
            else if (dvgInscripcionesAlumnos.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Dictado\n para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
