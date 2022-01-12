﻿using System;
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
            Listar();
        }
        public InscripcionesAlumnos(ModoF modo, int idCurso)//para prof
        {
            InitializeComponent();
            this.dvgInscripcionesAlumnos.AutoGenerateColumns = false;
            id_alumno.Visible = false;
            id_inscripcion.Visible = false;
            if (modo == ModoF.Lista)
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
            Listar(idCurso);

        }

        public void Listar(int? idCurso = null)
        {
            try
            {
                if (Session.currentUser.TipoPersona == 3)
                {
                    this.dvgInscripcionesAlumnos.DataSource = Alumnos_inscripcionesLogic.GetInstance().GetAllYearAlum(Session.currentUser.IdPersona, Int32.Parse(DateTime.Now.ToString("yyyy"))); //
                }
                if (Session.currentUser.TipoPersona == 2)
                {
                    if (idCurso != null)
                    {                        
                        this.dvgInscripcionesAlumnos.DataSource = Alumnos_inscripcionesLogic.GetInstance().GetAllYearCurso(Int32.Parse(DateTime.Now.ToString("yyyy")), idCurso);
                        
                    }
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
                desc_Comision.DataPropertyName = "DescMateria";
                desc_Comision.DataPropertyName = "DescComision";
                condicion.DataPropertyName = "Condicion";//selecccionar
                nota.DataPropertyName = "Nota";
            }
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
