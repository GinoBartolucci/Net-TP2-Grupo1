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
    public partial class Cursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
            modificarVistaSegunPermisosDelUsuario();
        }

        private Business.Entities.Curso Entity { get; set; }

        CursoLogic _logic;

        private CursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new CursoLogic();
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

            formActionsPanel.Visible = false;
            gridActionsPanel.Visible = false;
           

            
            selecMateriaButton.Visible = false;
            selecComisionButton.Visible = false; 
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

        private void SaveEntity(Business.Entities.Curso curso)
        {
            this.Logic.Save(curso);
        }


        private void LoadGrid()
        {
            Usuario usr = (Usuario)Session["current_user"];
            switch (usr.DescTipoPersona)
            {
                case "Administrativo": this.gridView.DataSource = this.Logic.GetAll(); break;
                case "Docente": Response.Redirect("Home.aspx"); break;
                case "Alumno": 
                    this.gridView.DataSource = this.Logic.GetAllYearAlum(usr.IdPersona,DateTime.Now.Year);
                    this.gridView.Columns[0].Visible = false;
                    this.gridView.Columns[4].Visible = false;
                    this.gridView.Columns[5].Visible = false;
                    break;
            }
          
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
            this.idComisionTextBox.Text = this.Entity.id_comision.ToString();
            this.idMateriaTextBox.Text = Entity.id_materia.ToString() ;
            this.anioCalendarioTextBox.Text = Entity.anio_calendario.ToString();
            this.cupoTextBox.Text = Entity.cupo.ToString();
           // this.idPlanTextBox.Text = Entity.IdPlan.ToString();

        }
        private void LoadEntity(Business.Entities.Curso curso)
        {
            curso.id_comision = int.Parse(this.idComisionTextBox.Text);
            curso.id_materia = int.Parse(this.idMateriaTextBox.Text);
            curso.cupo = int.Parse(this.cupoTextBox.Text);
            curso.anio_calendario = int.Parse(this.anioCalendarioTextBox.Text);
        }

        private void ClearForm()
        {

            this.idComisionTextBox.Text = string.Empty;
            this.idMateriaTextBox.Text = string.Empty;
            this.anioCalendarioTextBox.Text = string.Empty;
            this.cupoTextBox.Text = string.Empty;

        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

            if (this.IsEntitySelected)
            {

                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                tituloForm.Text = "Modificar curso";
                this.LoadForm(this.SelectedID);
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
                        this.Entity = new Business.Entities.Curso();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                    default:
                        break;
                    case FormModes.Alta:
                        this.Entity = new Business.Entities.Curso();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                }
                this.formPanel.Visible = false;
               
            
             
        }
        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.formPanel.Visible = false;

        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {

            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
            tituloForm.Text = "Nueva curso";
        }


        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {

            if (ingresoTextBox.Text.Length > 0)
            {
                LoadForm(int.Parse(ingresoTextBox.Text));
                tituloForm.Text = "Modificar alumno";
                this.FormMode = FormModes.Modificacion;

            }
            else
            {
                // mostrarMensajeDeError("Ingresa la ID de un alumno");
            }

        }
        protected void seleccionarMateriaButton(object sender, EventArgs e)
        { 
          
            tablaComision.Visible = false;

            materiaGridView.DataSource = (idComisionTextBox.Text != String.Empty)?
                new MateriaLogic().GetAllByComision(int.Parse(idComisionTextBox.Text))
                :
                new MateriaLogic().GetAll();
            materiaGridView.DataBind();

            tablaMateria.Visible = true;
        }

        protected void seleccionarComisionButton(object sender, EventArgs e)
        {
            tablaMateria.Visible = false;
            comisionGridView.DataSource = (idMateriaTextBox.Text != String.Empty)?
                new ComisionesLogic().GetAllByMateria(int.Parse(idMateriaTextBox.Text)) 
                :
                new ComisionesLogic().GetAll();
            comisionGridView.DataBind();
            tablaComision.Visible = true;
   
           
        }

        protected void materiaGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idMateriaTextBox.Text = this.materiaGridView.SelectedValue.ToString();
            tablaMateria.Visible = false;
        }

        protected void comisionGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idComisionTextBox.Text = this.comisionGridView.SelectedValue.ToString();
            tablaComision.Visible = false;
            
        }
    }
}