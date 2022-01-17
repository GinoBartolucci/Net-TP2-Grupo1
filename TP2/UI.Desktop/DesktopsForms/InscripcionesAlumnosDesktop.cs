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
using UI.Desktop.SelectForms;

namespace UI.Desktop.DesktopsForms
{
    public partial class InscripcionesAlumnosDesktop : ApplicationForm
    {
        private static InscripcionesAlumnosDesktop singleton;
        public static InscripcionesAlumnosDesktop GetInstance()
        {
            if (singleton == null)
            {
                singleton = new InscripcionesAlumnosDesktop();
            }
            return singleton;
        }

        private Inscripciones _InscripcionActual;
        public Inscripciones InscripcionActual
        {
            get { return _InscripcionActual; }
            set { _InscripcionActual = value; }
        }

        public InscripcionesAlumnosDesktop()
        {
            InitializeComponent();           
        }

        public InscripcionesAlumnosDesktop(ModoForm modo) : this()//alta
        {
            Text = modo.ToString();
            Modo = modo;
            txtID.Visible = false;
            lblID.Visible = false;
            txtCurso.Visible = false;
            lblCurso.Visible = false;
            txtLegajo.Visible = false;
            lblLegajo.Visible = false;
            txtNombre.Visible = false;
            lblNombre.Visible = false;
            cbxCondicion.Visible = false;
            lblCondicion.Visible = false;
            cbxNotas.Visible = false;
            lblNota.Visible = false;
            InscripcionActual = new Inscripciones();

        }

        public InscripcionesAlumnosDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            lblSelecCurso.Visible = false;
            btnCurso.Visible = false;
            if (modo == ModoForm.Baja)
            {
                cbxCondicion.Enabled= false; 
                cbxNotas.Enabled = false;
                lblCurso.Visible = false;
                txtID.Enabled = false;
            }
            Modo = modo;
            InscripcionActual = Alumnos_inscripcionesLogic.GetInstance().GetOne(ID);

            MapearDeDatos();
        }
        
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.InscripcionActual.ID.ToString();
                              
            this.txtCurso.Text = this.InscripcionActual.IdCurso.ToString();
            this.txtLegajo.Text = this.InscripcionActual.Legajo.ToString();
            txtNombre.Text = this.InscripcionActual.NombreApellido.ToString();
            cbxCondicion.SelectedItem = this.InscripcionActual.Condicion;
            if (InscripcionActual.Condicion == "Aprobado" || InscripcionActual.Condicion == "Libre")
            {
                cbxNotas.Enabled = false;
                cbxCondicion.Enabled = false;//si ya esta aprobado o libre no se puede cambiar
            }            
            if (InscripcionActual.Nota != -1)
            {
                cbxNotas.SelectedItem = this.InscripcionActual.Nota.ToString();//si tiene nota la muestra
            }
            else
            {
                cbxNotas.SelectedItem = "Nota";//si no tiene nota muestra "Nota"
            }
            
            switch (Modo)
            {
                case ModoForm.Alta: btnAceptar.Text = "Guardar"; break;
                case ModoForm.Baja: btnAceptar.Text = "Eliminar"; break;
                case ModoForm.Modificacion: btnAceptar.Text = "Guardar"; break;
                case ModoForm.Consulta: btnAceptar.Text = "Aceptar"; break;                 
            }
        }

        public override void MapearADatos()
        {

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                InscripcionActual.State = BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {                    
                    InscripcionActual.State = BusinessEntity.States.New;
                    InscripcionActual.Condicion = "Cursante";
                    //this.InscripcionActual.IdCurso = InscripcionActual.IdCurso;
                    //InscripcionActual.IdCurso ya se asigno en el boton curso
                    InscripcionActual.IdAlumno = Session.currentUser.IdPersona;               
                }
                if (Modo == ModoForm.Modificacion)
                {
                    this.InscripcionActual.ID = int.Parse(this.txtID.Text);
                    this.InscripcionActual.Condicion = this.cbxCondicion.SelectedItem.ToString();
                    if (InscripcionActual.Condicion == "Aprobado") 
                    {
                        this.InscripcionActual.Nota = int.Parse(cbxNotas.SelectedItem.ToString());
                    }                    
                    //this.InscripcionActual.Nota = int.Parse(txtNota.Text);
                    this.InscripcionActual.IdCurso = int.Parse(this.txtCurso.Text);
                    this.InscripcionActual.Legajo = int.Parse(this.txtLegajo.Text);
                    this.InscripcionActual.NombreApellido = this.txtNombre.Text;
                    InscripcionActual.State = BusinessEntity.States.Modified;
                }
            }

            if (Modo == ModoForm.Baja)
            {
                InscripcionActual.State = BusinessEntity.States.Deleted;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            Alumnos_inscripcionesLogic.GetInstance().Save(InscripcionActual);

        }
       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Modo == ModoForm.Alta)
            {
                GuardarCambios();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //string[] labels = { txtID.Text, txtCurso.Text, txtLegajo.Text, txtNombre.Text };
                if (cbxNotas.SelectedItem.ToString() != "Nota" && cbxCondicion.SelectedItem.ToString() == "Aprobado")
                {
                    //if (BusinessRules.ValidarCampos(labels))
                    //{
                        GuardarCambios();
                        DialogResult = DialogResult.OK;
                        this.Close();
                    //}
                }
                else if (cbxNotas.SelectedItem.ToString() == "Nota" && (cbxCondicion.SelectedItem.ToString() == "Regular" || cbxCondicion.SelectedItem.ToString() == "Libre"))
                {
                    GuardarCambios();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    Notificar("Debe llenar o seleccionar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIdAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            SelectCurso ventanaNuevaInscripcion = new SelectCurso();
            ventanaNuevaInscripcion.ShowDialog();
            if (ventanaNuevaInscripcion.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Error al seleccionar Curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                InscripcionActual.IdCurso = ventanaNuevaInscripcion.IdCurso;
                lblSelecCurso.Text = InscripcionActual.IdCurso.ToString();
            }
        }

        private void cbxCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblCondicion.Text = cbxCondicion.SelectedItem.ToString();
            if (cbxCondicion.SelectedItem.ToString() != "Aprobado")
            {
                cbxNotas.Enabled = false;//si no esta aprobado no puede poner nota
            }
            else if (cbxCondicion.SelectedItem.ToString() == "Aprobado" && cbxNotas.SelectedItem.ToString() != "Nota")
            {
                cbxNotas.Enabled = false;//no puede cambiar la nota despues de que ya se le puso la nota
            }
            else if (cbxCondicion.SelectedItem.ToString() == "Aprobado" && cbxNotas.SelectedItem.ToString() == "Nota")
            {
                cbxNotas.Enabled = true;//si selecciono aprobado y no tiene nota le puede cambiar la nota
            }
        }
    }
}
