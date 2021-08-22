using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities.Tables;
using Business.Entities;
using Business.Logic.TablesLogics;
using Business.Logic;
using UI.Desktop.SelectForms;

namespace UI.Desktop.DesktopsForms
{
    public partial class InscripcionesAlumnosDesktop : ApplicationForm
    {
        public InscripcionesAlumnosDesktop()
        {
            InitializeComponent();
        }

        public InscripcionesAlumnosDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            InscripcionActual = new InscripcionesAlumnos();

        }

        public InscripcionesAlumnosDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtCondicion.ReadOnly = true; 
                btnIdAlumno.Enabled = false;
                btnIdCurso.Enabled = false;
                txtNota.ReadOnly = true;
               
                txtID.Enabled = false;
            }
            Modo = modo;
            Business.Logic.TablesLogics.InscripcionesAlumnosLogic ul = new InscripcionesAlumnosLogic();
            InscripcionActual = ul.GetOne(ID);
            MapearDeDatos();
        }

        private InscripcionesAlumnos _InscripcionActual;

        public InscripcionesAlumnos InscripcionActual
        {
            get { return _InscripcionActual;  }
            set { _InscripcionActual = value; }

        }
        
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.InscripcionActual.ID.ToString();
            this.btnIdCurso.Text = this.InscripcionActual.IdCurso.ToString();
            this.txtCondicion.Text = this.InscripcionActual.Condicion.ToString();
            this.txtNota.Text = this.InscripcionActual.Nota.ToString();
            this.btnIdAlumno.Text = this.InscripcionActual.IdAlumno.ToString();

            switch (Modo)
            {
                case ModoForm.Alta: btnAceptar.Text = "Guardar"; break;
                case ModoForm.Baja: btnAceptar.Text = "Eliminar";
                    btnIdCurso.Enabled = false;
                    btnIdAlumno.Enabled = false;
                    break;
                case ModoForm.Modificacion: btnAceptar.Text = "Guardar"; break;
                case ModoForm.Consulta: btnAceptar.Text = "Aceptar"; break;
                 
            }

        }

        public override void MapearADatos()
        {
         
            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                InscripcionActual.State = BusinessEntity.States.Modified;
                if(Modo == ModoForm.Alta)
                {
                    InscripcionActual = new Business.Entities.Tables.InscripcionesAlumnos();
                    InscripcionActual.State = BusinessEntity.States.New;
                }

              //  InscripcionActual.ID = int.Parse(this.txtID.ToString());
                InscripcionActual.IdAlumno = int.Parse(this.btnIdAlumno.Text);
                InscripcionActual.IdCurso = int.Parse(this.btnIdCurso.Text);
                InscripcionActual.Nota = int.Parse(this.txtNota.Text);
                InscripcionActual.Condicion = this.txtCondicion.Text;

            }

            if (Modo == ModoForm.Baja)
            {
                InscripcionActual.State = BusinessEntity.States.Deleted;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            InscripcionesAlumnosLogic InscripcionLogic = new InscripcionesAlumnosLogic();
            InscripcionLogic.Save(InscripcionActual);

        }
        public override bool Validar()
        {
            bool bandera = true;
            string[] labels = { txtCondicion.Text,/** txtIDAlumno.Text, txtIDCurso.Text, **/txtNota.Text };
    
           foreach(string labelPosicion in labels)
            {
                bandera = txtVacio(labelPosicion);
                if (!bandera)
                {
                    break;
                }
            }


            return bandera;
        }


        private bool txtVacio(string contenido)
        {
            if(String.IsNullOrWhiteSpace(contenido) || btnIdCurso.Text == " Seleccionar" )
            {
                Notificar("Debe llenar todos los campos y seleccionar los ID",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIdAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btnIdCurso_Click(object sender, EventArgs e)
        {
            SelectCurso SC = new SelectCurso();
            DialogResult DRIdCurso = SC.ShowDialog();

            if(DRIdCurso != DialogResult.Cancel)
            {
                btnIdCurso.Text = SC.IdSelectCurso.ToString();
                InscripcionActual.IdCurso = SC.IdSelectCurso;
            }
           
        }
    }
}
