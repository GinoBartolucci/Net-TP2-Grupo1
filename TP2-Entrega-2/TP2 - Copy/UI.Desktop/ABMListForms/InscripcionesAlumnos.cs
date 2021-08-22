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
using Business.Entities.Tables;
using Business.Logic.TablesLogics;
using UI.Desktop.DesktopsForms;

namespace UI.Desktop.ABMListForms
{
    public partial class InscripcionesAlumnos : Form
    {
        public InscripcionesAlumnos()
        {
            InitializeComponent();
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
            InscripcionesAlumnosLogic IA = new InscripcionesAlumnosLogic();

            try
            {
                this.dvgInscripcionesAlumnos.DataSource = IA.GetAll();
            } 
            catch(Exception e)
            {
                 NotificarError(e);
            }

            ID.DataPropertyName = "ID";
            id_alumno.DataPropertyName = "IdAlumno";
            id_curso.DataPropertyName = "IdCurso";
            condicion.DataPropertyName = "Condicion";
            nota.DataPropertyName = "Nota";


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
            int ID;
            string textoID = ((Business.Entities.Tables.InscripcionesAlumnos)this.dvgInscripcionesAlumnos.SelectedRows[0].DataBoundItem).ID.ToString();

            ID = int.Parse(textoID);
            InscripcionesAlumnosDesktop v1 = new InscripcionesAlumnosDesktop(ApplicationForm.ModoForm.Modificacion,ID);
            v1.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID;
            string textoID = ((Business.Entities.Tables.InscripcionesAlumnos)this.dvgInscripcionesAlumnos.SelectedRows[0].DataBoundItem).ID.ToString() ;

            ID = int.Parse(textoID);

            InscripcionesAlumnosDesktop ventanaNuevaInscripcion = new InscripcionesAlumnosDesktop(ApplicationForm.ModoForm.Baja,ID);
            ventanaNuevaInscripcion.ShowDialog();
            this.Listar();
        }
    }
}
