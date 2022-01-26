using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Business.Entities.Tables;
using Business.Entities;
using Business.Logic;
namespace UI.Web
{
    public partial class Comisiones : System.Web.UI.Page
    {
        private Business.Entities.Comisiones Entity
        {
            get;
            set;
        }

        ComisionesLogic _logic;

        private ComisionesLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new ComisionesLogic();
                }
                return _logic;
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
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.descripcionTextBox.Text = this.Entity.DescComision;
            this.anioEspecialidadTextBox.Text = this.Entity.AnioEspecialidad.ToString();
            this.idPlanTextBox.Text = this.Entity.IdPlan.ToString();
        }



        private void EnableForm(bool enable)
        {

            this.descripcionTextBox.Enabled = enable;
            this.anioEspecialidadTextBox.Enabled = enable;
 

        }

        protected void Page_Load(object sender, EventArgs e)
        {

            Usuario usuario = (Usuario)Session["current_user"];
            LoadGrid();

            mostrarOpcionesABM(usuario.TipoPersona);

        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }



        private void mostrarOpcionesABM(int tipoPersona)
        {
 
                this.cancelarLinkButton.Visible = true;
                this.aceptarLinkButton.Visible = true;
                this.editarLinkButton.Visible = true;

                this.nuevoLinkButton.Visible = true;
                this.gridView.Visible = true;
                this.gridPanel.Visible = true;
      
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

            if (this.IsEntitySelected)
            {

                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        private void LoadEntity(Business.Entities.Comisiones comision)
        {
            comision.DescComision = this.descripcionTextBox.Text;
            comision.IdPlan = int.Parse(this.idPlanTextBox.Text);
            comision.AnioEspecialidad = int.Parse(this.anioEspecialidadTextBox.Text);


        }
        private void SaveEntity(Business.Entities.Comisiones comision)
        {
            this.Logic.Save(comision);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            TextBox[] arreglo = { descripcionTextBox, anioEspecialidadTextBox, idPlanTextBox };


            if (methods.validarYPintarCamposVacios(arreglo))
            {

                switch (this.FormMode)
                {
                    case FormModes.Baja:
                        this.DeleteEntity(this.SelectedID);
                        this.LoadGrid();
                        break;
                    case FormModes.Modificacion:
                        this.Entity = new Business.Entities.Comisiones();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                    default:
                        break;
                    case FormModes.Alta:
                        this.Entity = new Business.Entities.Comisiones();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        break;
                }
                this.formPanel.Visible = false;


            }
            else
            {
                validacionCartelLabel.Visible = true;
            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {

            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.descripcionTextBox.Text = string.Empty;
            this.idPlanTextBox.Text = string.Empty;
            this.anioEspecialidadTextBox.Text = string.Empty;
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.formPanel.Visible = false;

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
