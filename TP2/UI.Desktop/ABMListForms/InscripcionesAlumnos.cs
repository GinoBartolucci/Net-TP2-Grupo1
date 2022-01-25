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
    public partial class InscripcionesAlumnos : Form
    {
        private static InscripcionesAlumnos singleton;
        public static InscripcionesAlumnos GetInstance()
        {
            if (singleton == null)
            {
                singleton = new InscripcionesAlumnos();
            }
            return singleton;
        }
        public int idCursoDocente;
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

        public InscripcionesAlumnos()//solo para alumnos
        {
            InitializeComponent();
            this.dvgInscripcionesAlumnos.AutoGenerateColumns = false;
            if (Session.currentUser.TipoPersona == 3)//si es alumno no ve los botones abm
            {
                tscInscripcionesAlumnos.Visible = false;
                id_alumno.Visible = false;
                nombreApellido.Visible = false;
                legajo.Visible = false;
                condicion.Visible = false;
                nota.Visible = false;
            }
        }
        public InscripcionesAlumnos(ModoF modo, int idCurso)//para prof
        {
            InitializeComponent();
            Modo = modo;
            this.dvgInscripcionesAlumnos.AutoGenerateColumns = false;
            id_alumno.Visible = false;
            id_inscripcion.Visible = false;
            if (Modo == ModoF.Lista)
            {
                tsbNuevo.Visible = false;
                tsbEliminar.Visible = false;
                tsbEditar.Visible = false;
                id_alumno.Visible = false;
            }
            else {
                tsbNuevo.Visible = false;
                tsbEliminar.Visible = false;

                id_alumno.Visible = false;
            }
            idCursoDocente = idCurso;
        }

        public void Listar()
        {
            try
            {
                if (Session.currentUser.TipoPersona == 3)
                {
                    List<Inscripciones> listaInscrip= Alumnos_inscripcionesLogic.GetInstance().GetAllYearAlum(Session.currentUser.IdPersona, Int32.Parse(DateTime.Now.ToString("yyyy"))); 
                    listaInscrip.RemoveAll(item => item.Condicion != "Cursando");
                    dvgInscripcionesAlumnos.DataSource = listaInscrip;

                }
                if (Session.currentUser.TipoPersona == 2)
                {                      
                        List<Inscripciones> listaInscrip = Alumnos_inscripcionesLogic.GetInstance().GetAllCurso(idCursoDocente);
                        if (Modo == ModoF.Nota)
                        {
                            listaInscrip.RemoveAll(item => item.Condicion == "Aprobado" || item.Condicion == "Libre");// para poder la nota solo trae los regulares
                            if (listaInscrip.Count == 0)
                            {
                                MessageBox.Show("No hay alumnos no aprobados en este curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Close();
                            }
                        }
                        dvgInscripcionesAlumnos.DataSource = listaInscrip;                    
                }
            } 
            catch(Exception e)
            {
                 NotificarError(e);
            }

            if (Session.currentUser.TipoPersona == 3)
            {
                id_curso.DataPropertyName = "IdCurso";
                id_inscripcion.DataPropertyName = "ID";
                desc_Materia.DataPropertyName = "DescMateria";
                desc_Comision.DataPropertyName = "DescComision";
            }
            if (Session.currentUser.TipoPersona == 2)
            {
                id_inscripcion.DataPropertyName = "ID";
                nombreApellido.DataPropertyName = "NombreApellido";
                legajo.DataPropertyName = "Legajo";
                id_curso.DataPropertyName = "IdCurso";
                desc_Materia.DataPropertyName = "DescMateria";
                desc_Comision.DataPropertyName = "DescComision";
                condicion.DataPropertyName = "Condicion";//selecccionar
                nota.DataPropertyName = "Nota";
                
            }
        }

        private void InscripcionesAlumnos_Load(object sender, EventArgs e)
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
            string textoID = ((Business.Entities.Inscripciones)this.dvgInscripcionesAlumnos.SelectedRows[0].DataBoundItem).ID.ToString() ;

            ID = int.Parse(textoID);

            InscripcionesAlumnosDesktop ventanaNuevaInscripcion = new InscripcionesAlumnosDesktop(ApplicationForm.ModoForm.Baja,ID);
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
    }
}
