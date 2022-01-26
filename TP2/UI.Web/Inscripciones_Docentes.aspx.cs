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
    public partial class Inscripciones_Docentes: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
            modificarVistaSegunPermisosDelUsuario();
        }
        private Business.Entities.Docentes_cursos Entity { get; set; }

        Docentes_cursosLogic _logic;

        private Docentes_cursosLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new Docentes_cursosLogic();
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
                case "Docente": vistaParaDocente();  break;
                case "Alumno": Response.Redirect("Home.aspx");  break;
            }
        }

        private void vistaParaDocente()
        {
            editarLinkButton.Visible = false;
            idPersonaLabel.Visible = false;
            seleccionarPersonaButton.Visible = false;
           
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

        private void SaveEntity(Business.Entities.Docentes_cursos Docente_curso)
        {
            this.Logic.Save(Docente_curso);
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            LoadForm(int.Parse(this.ingresoTextBox.Text));
            this.formPanel.Visible = true;


        }

        private void LoadGrid()
        {
            Usuario usr = (Usuario)Session["current_user"];
            switch (usr.DescTipoPersona)
            {
                case "Administrativo": this.gridView.DataSource = this.Logic.GetAll(); break;
                case "Docente":
                    this.gridView.DataSource = this.Logic.GetAllYearDoc(usr.IdPersona, 2020);
                    this.gridView.Columns[0].Visible = false;
                    this.gridView.Columns[1].Visible = false;
                    this.gridView.Columns[6].Visible = false;
                    break;
                case "Alumno":
                    Response.Redirect("Home.aspx");


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

            idCursoTextBox.Text = Entity.id_curso.ToString();
            idPersonaTextBox.Text = Entity.id_docente.ToString();
            cargoTextBox.Text = Entity.cargo.ToString();

        }
        private void LoadEntity(Business.Entities.Docentes_cursos Docente_curso)
        {
            Usuario usr = (Usuario)Session["current_user"];
            switch (usr.DescTipoPersona)
            {
                case "Administrativo":
                    Docente_curso.id_docente = int.Parse(this.idPersonaTextBox.Text); ;
               
                    Docente_curso.id_curso = int.Parse(this.idCursoTextBox.Text);
       
                    break;
                case "Docente":
                    Docente_curso.id_docente = usr.IdPersona;
            
                    Docente_curso.cargo = int.Parse(this.cargoTextBox.Text);
                    break;
             
            }

            Docente_curso.id_curso = int.Parse(this.idCursoTextBox.Text);

        }

        private void ClearForm()
        {

            idCursoTextBox.Text = string.Empty;
            idPersonaTextBox.Text = string.Empty;
            cargoTextBox.Text = string.Empty;


        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                tituloForm.Text = "Modificar Docente_curso";
                this.LoadForm(this.SelectedID);

            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            tituloForm.Text = "Crear Docente_curso";
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
                TextBox[] nuevoArreglo = { idPersonaTextBox, idCursoTextBox, cargoTextBox };
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
                        this.Entity = new Business.Entities.Docentes_cursos();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                    default:
                        break;
                    case FormModes.Alta:
                        this.Entity = new Business.Entities.Docentes_cursos();
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
            AlumnosGridView.DataSource = (idCursoTextBox.Text != string.Empty) ?
                    new PersonasLogic().GetAlumnsByCourse(int.Parse(idCursoTextBox.Text))
                    :
                    new PersonasLogic().GetAllAlumnos();
            AlumnosGridView.DataBind();
            this.alumnosPanel.Visible = true;

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
            cursoGridView.DataSource = (idPersonaTextBox.Text != string.Empty) ?
                    new CursoLogic().GetAllForAlum(int.Parse(idPersonaTextBox.Text))
                    :
                    new CursoLogic().GetAll();
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
