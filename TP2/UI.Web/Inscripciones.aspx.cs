using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Inscripciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
        }
        private Business.Entities.Inscripciones Entity { get; set; }

        Alumnos_inscripcionesLogic _logic;

        private Alumnos_inscripcionesLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new Alumnos_inscripcionesLogic();
                }
                return _logic;
            }
        }


        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }


        public enum FormModes
        {
            Alta, Baja, Modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }


        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        private void SaveEntity(Business.Entities.Inscripciones inscripcion)
        {
            this.Logic.Save(inscripcion);
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            LoadForm(int.Parse(this.ingresoTextBox.Text));
            this.formPanel.Visible = true;


        }

        private void LoadGrid()
        {
           
                this.gridView.DataSource = this.Logic.GetEveryone();
                this.gridView.DataBind();
          
           
        }

        private void EnableForm(bool enable)
        {

            // this.descripcionEspecialidadLabel.Visible = enable;
            //  this.descripcionTextBox.Enabled = enable; // >>> ???? >> > > > > >> > > > > > > > > 
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            idCursoTextBox.Text = Entity.IdAlumno.ToString();
            idPersonaTextBox.Text = Entity.IdCurso.ToString();
            condicionTextBox.Text = Entity.Condicion;
            notaTextBox.Text = Entity.Nota.ToString();

        }
        private void LoadEntity(Business.Entities.Inscripciones inscripcion)
        {
            inscripcion.IdAlumno = int.Parse(this.idPersonaTextBox.Text);
            inscripcion.IdCurso = int.Parse(this.idCursoTextBox.Text);
            inscripcion.Condicion = this.condicionTextBox.Text;
            inscripcion.Nota = int.Parse(this.notaTextBox.Text);
        }

        private void ClearForm()
        {
  
            idCursoTextBox.Text = string.Empty;
            idPersonaTextBox.Text = string.Empty;
            condicionTextBox.Text = string.Empty;
            notaTextBox.Text = string.Empty;
 
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                tituloForm.Text = "Modificar inscripcion";
                this.LoadForm(this.SelectedID);

            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            tituloForm.Text = "Crear inscripcion";
            this.ClearForm();
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.LoadForm(this.SelectedID);
                tituloForm.Text = "Eliminar inscripcion";
            }
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {

            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Business.Entities.Inscripciones();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
                case FormModes.Alta:
                    this.Entity = new Business.Entities.Inscripciones();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
            }
            //this.formPanel.Visible = false;



        }
        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.formPanel.Visible = false;

        }

     


        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected void seleccionarPersonaButton_Click(object sender, EventArgs e)
        {
            AlumnosGridView.DataSource = new PersonasLogic().GetAllAlumnos();
            AlumnosGridView.DataBind();
            this.alumnosPanel.Visible = true;
        }

 

        protected void seleccionarCursoButton_Click(object sender, EventArgs e)
        {
            cursoGridView.DataSource = new CursoLogic().GetAll();
            cursoGridView.DataBind();
            this.tablaCurso.Visible = true;
        }

        protected void cursoGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCursoTextBox.Text = this.cursoGridView.SelectedValue.ToString();
            this.tablaCurso.Visible = false;
        }

        protected void AlumnosGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPersonaTextBox.Text = this.AlumnosGridView.SelectedValue.ToString();
            this.alumnosPanel.Visible = false;
        }
    }
}