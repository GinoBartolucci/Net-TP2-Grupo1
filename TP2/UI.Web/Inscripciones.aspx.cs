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
            modificarVistaSegunPermisosDelUsuario();
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

        private void modificarVistaSegunPermisosDelUsuario()
        {
            Usuario usr = (Usuario)Session["current_user"];
            switch (usr.DescTipoPersona)
            {
                case "Administrativo": break;
                case "Docente": Response.Redirect("Home.aspx"); break;
                case "Alumno": vistaParaAlumno(); break;
            }
        }

        private void vistaParaAlumno()
        {
            editarLinkButton.Visible = false;
            idPersonaLabel.Visible = false;
            seleccionarPersonaButton.Visible = false;
            condicionLabel.Visible = false;
            condicionTextBox.Visible = false;
            notaLabel.Visible = false;
            notaTextBox.Visible = false;
            idPersonaTextBox.Visible = false;

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
            if (this.ingresoTextBox.Text != String.Empty)
            {
                try
                {
                    ingresoTextBox.BorderColor = System.Drawing.Color.White;
                    LoadForm(int.Parse(this.ingresoTextBox.Text));
                    this.formPanel.Visible = true;
                }
                catch (Exception er)
                {

                    ingresoTextBox.BorderColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                ingresoTextBox.BorderColor = System.Drawing.Color.Red;
            }


        }

        private void LoadGrid()
        {
            Usuario usr = (Usuario)Session["current_user"];
            switch (usr.DescTipoPersona)
            {
                case "Administrativo": this.gridView.DataSource = this.Logic.GetEveryone(); break;
                case "Docente": Response.Redirect("Home.aspx"); break;
                case "Alumno":
                    this.gridView.DataSource = this.Logic.GetAllAlum(usr.IdPersona);
                    this.gridView.Columns[0].Visible = false;
                    this.gridView.Columns[2].Visible = false;
                    this.gridView.Columns[7].Visible = false;

                    break;
            }
            this.gridView.Columns[1].Visible = false;

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

            idCursoTextBox.Text = Entity.IdCurso.ToString();
            idPersonaTextBox.Text = Entity.IdAlumno.ToString();
            condicionTextBox.Text = Entity.Condicion;
            notaTextBox.Text = Entity.Nota.ToString();

        }
        private void LoadEntity(Business.Entities.Inscripciones inscripcion)
        {
            Usuario usr = (Usuario)Session["current_user"];
            switch (usr.DescTipoPersona)
            {
                case "Administrativo":
                    inscripcion.IdAlumno = int.Parse(this.idPersonaTextBox.Text); ;
                    inscripcion.Condicion = this.condicionTextBox.Text;
                    inscripcion.Nota = int.Parse(this.notaTextBox.Text);
                    break;
                case "Docente":; break;
                case "Alumno":
                    inscripcion.IdAlumno = usr.IdPersona;
                    inscripcion.Condicion = "Cursando";
                    inscripcion.Nota = -1;
                    break;
            }

            inscripcion.IdCurso = int.Parse(this.idCursoTextBox.Text);

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


        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {

            TextBox[] arreglo;

            if (((Usuario)Session["current_user"]).DescTipoPersona == "Alumno")
            {
                TextBox[] nuevoArreglo = { idCursoTextBox };
                arreglo = nuevoArreglo;

            }
            else
            {
                TextBox[] nuevoArreglo = { idPersonaTextBox, idCursoTextBox, condicionTextBox };
                arreglo = nuevoArreglo;

            }



            if (methods.validarYPintarCamposVacios(arreglo))
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
                this.formPanel.Visible = false;

            }
            else
            {
                mensajeDeValidacionDeCampo.Visible = true;
            }



        }
        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.formPanel.Visible = false;

        }




        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
            ClearForm();
            this.formPanel.Visible = false;

        }

        protected void seleccionarPersonaButton_Click(object sender, EventArgs e)
        {
            this.tablaCurso.Visible = false;
            LoadPersonaGrid();
            this.alumnosPanel.Visible = true;

        }



        protected void LoadCursoGrid()
        {
            cursoGridView.DataSource = (idPersonaTextBox.Text != string.Empty) ?
                   BusinessRules.ValidarCupo(new CursoLogic().GetAllForAlum(int.Parse(idPersonaTextBox.Text)))
                    :
                    BusinessRules.ValidarCupo(new CursoLogic().GetAll());
            cursoGridView.DataBind();
        }

        protected void LoadPersonaGrid()
        {
            AlumnosGridView.DataSource = (idCursoTextBox.Text != string.Empty) ?
                   new PersonasLogic().GetAlumnsByCourse(int.Parse(idCursoTextBox.Text))
                   :
                   new PersonasLogic().GetAllAlumnos();
            AlumnosGridView.DataBind();
        }

        protected void seleccionarCursoButton_Click(object sender, EventArgs e)
        {
            Usuario usr = (Usuario)Session["current_user"];
            switch (usr.DescTipoPersona)
            {
                case "Docente": break;
                case "Alumno":
                    idPersonaTextBox.Text = usr.IdPersona.ToString();
                    break;
            }

            this.alumnosPanel.Visible = false;
            LoadCursoGrid();
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

        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridView.PageIndex = e.NewPageIndex;
            LoadGrid();
        }

        protected void cursoGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cursoGridView.PageIndex = e.NewPageIndex;
            LoadCursoGrid();
        }

        protected void AlumnosGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            AlumnosGridView.PageIndex = e.NewPageIndex;
            LoadPersonaGrid();
        }

    }
}