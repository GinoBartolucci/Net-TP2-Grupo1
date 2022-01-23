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
    public partial class Materias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.LoadGrid();
            modificarVistaSegunPermisosDelUsuario();
        }

        private Business.Entities.Materia Entity { get; set; }

        MateriaLogic _logic;


        private MateriaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new MateriaLogic();
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
            seleccionaBtn.Visible = false;
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

        private void SaveEntity(Business.Entities.Materia materia)
        {
            this.Logic.Save(materia);
        }


        private void LoadGrid()
        {
            Usuario usr = (Usuario)Session["current_user"];
            switch (usr.DescTipoPersona)
            {
                case "Administrativo":
                    this.gridView.DataSource = this.Logic.GetAll(); break;
                case "Alumno":
                    this.gridView.DataSource = this.Logic.GetAllPlan(usr.IdPlan);
                    this.gridView.Columns[0].Visible = false;
                    this.gridView.Columns[4].Visible = false;
                    this.gridView.Columns[5].Visible = false;
                    break;
            }
            this.gridView.DataBind();

        }

        private void EnableForm(bool enable)
        {

            this.descripcionEspecialidadLabel.Visible = enable;
            this.descripcionTextBox.Enabled = enable; // >>> ???? >> > > > > >> > > > > > > > > 
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.descripcionTextBox.Text = this.Entity.DescMateria;
            this.descripcionTextBox.Text = Entity.DescMateria;
            this.horasSemanalesTextBox.Text = Entity.HorasSemanales.ToString();
            this.horasTotalesTextBox.Text = Entity.HorasTotales.ToString();
            this.idPlanTextBox.Text = Entity.IdPlan.ToString();

        }
        private void LoadEntity(Business.Entities.Materia materia)
        {
            materia.DescMateria = this.descripcionTextBox.Text;
            materia.HorasSemanales = int.Parse(this.horasSemanalesTextBox.Text);
            materia.HorasTotales = int.Parse(this.horasTotalesTextBox.Text);
            materia.IdPlan = int.Parse(this.idPlanTextBox.Text);
        }

        private void ClearForm()
        {
            this.descripcionTextBox.Text = string.Empty;

        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

            if (this.IsEntitySelected)
            {

                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                tituloForm.Text = "Modificar especialidad";
                this.LoadForm(this.SelectedID);
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.LoadForm(this.SelectedID);
                tituloForm.Text = "Eliminar materia";
            }
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            if (descripcionTextBox.Text.Length > 0)
            {
                switch (this.FormMode)
                {
                    case FormModes.Baja:
                        this.DeleteEntity(this.SelectedID);
                        this.LoadGrid();
                        break;
                    case FormModes.Modificacion:
                        this.Entity = new Business.Entities.Materia();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                    default:
                        break;
                    case FormModes.Alta:
                        this.Entity = new Business.Entities.Materia();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                }
                this.formPanel.Visible = false;
                validacionDescripcionEspecialidad.Visible = false;
            }
            else
            {
                validacionDescripcionEspecialidad.Visible = true;
            }
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
            tituloForm.Text = "Nueva materia";
        }


        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {

            if (materiaIngresoTextBox.Text.Length > 0)
            {
                LoadForm(int.Parse(materiaIngresoTextBox.Text));
                tituloForm.Text = "Modificar alumno";
                this.FormMode = FormModes.Modificacion;

            }
            else
            {
                // mostrarMensajeDeError("Ingresa la ID de un alumno");
            }

        }
        protected void seleccionarButton(object sender, EventArgs e)
        {
            LoadEspecialidadGrid();
            tablaPlan.Visible = true;

        }

        private void LoadEspecialidadGrid()
        {
            this.planGridView.DataSource = new PlanesLogic().GetAll();
            this.planGridView.DataBind();
        }

        protected void planGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idPlanTextBox.Text = this.planGridView.SelectedValue.ToString();
            this.tablaPlan.Visible = false;
        }
    }
}
