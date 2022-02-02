﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Business.Entities.Tables;
//using Business.Logic.TablesLogics;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {


        private Usuario Entity
        {
            get;
            set;
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


        UsuarioLogic _logic;

        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
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

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            int idIngreso = int.Parse(this.idIngresoTextBox.Text);

            if (idIngresoTextBox.Text.Length > 0)
            {
                try
                {
                    idIngresoTextBox.BorderColor = System.Drawing.Color.White;
                    ClearForm();
                    LoadForm(idIngreso);

                    this.FormMode = FormModes.Modificacion;
                    this.formPanel.Visible = true;
                }
                catch (Exception er)
                {
                  idIngresoTextBox.BorderColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                idIngresoTextBox.BorderColor = System.Drawing.Color.Red;
            }

        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOneId(id);
            this.idPersonaTextBox.Text = this.Entity.IdPersona.ToString();
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.emailTextBox.Text = this.Entity.Email;
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;

            LoadPersonaForm(Entity.IdPersona);
            // EnablePersonaForm(false);


        }



        private void EnableForm(bool enable)
        {
            this.apellidoTextBox.Enabled = enable;
            this.nombreTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.nombreUsuarioTextBox.Enabled = enable;

            this.habilitadoCheckBox.Enabled = enable;
            this.claveLabel.Visible = enable;
            this.ClaveTextBox.Visible = enable;
            this.repetirClaveLabel.Visible = enable;
            this.repetirClaveTextBox.Visible = enable;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        protected void habilitarLinkButton_Click(object sender, EventArgs e)
        {

            if (this.IsEntitySelected)
            {

                this.Entity = Logic.GetOneId(this.SelectedID);
                this.Entity.Habilitado = !Entity.Habilitado;
                this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                this.FormMode = FormModes.Modificacion;
                this.SaveEntity(this.Entity);
                this.LoadGrid();

            }
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

        private void LoadEntity(Usuario usuario)
        {

            usuario.IdPersona = (this.idPersonaTextBox.Text != string.Empty) ?
                int.Parse(this.idPersonaTextBox.Text)
                :
                usuario.IdPersona
                ;
            usuario.Apellido = this.apellidoTextBox.Text;
            usuario.Nombre = this.nombreTextBox.Text;
            usuario.Email = this.emailTextBox.Text;
            usuario.Clave = this.ClaveTextBox.Text;
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;

            usuario.Telefono = this.telefonoTextBox.Text;
            usuario.Direccion = this.direccionTextBox.Text;
            usuario.FechaNac = DateTime.Parse(this.fechaNacimientoTextBox.Text);
            usuario.TipoPersona = int.Parse(tipoPersonaTextBox.Text);
            usuario.IdPlan = int.Parse(idPlanTextBox.Text);
        }
        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {

            if (validacioneForm())
            {

                switch (this.FormMode)
                {

                    case FormModes.Modificacion:

                        this.Entity = new Usuario();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        this.formPanel.Visible = false;

                        break;

                    default:
                        break;
                    case FormModes.Alta:

                        this.Entity = new Usuario();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        this.formPanel.Visible = false;

                        break;
                }
                EnablePersonaForm(true);
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


            this.idPersonaTextBox.Text = string.Empty;
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.habilitadoCheckBox.Text = string.Empty;
            this.nombreUsuarioTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.telefonoTextBox.Text = string.Empty;
            this.fechaNacimientoTextBox.Text = string.Empty;
            this.tipoPersonaTextBox.Text = string.Empty;
            this.ClaveTextBox.Text = string.Empty;
            this.repetirClaveTextBox.Text = string.Empty;

        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
            formPanel.Visible = false;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.formPanel.Visible = false;
            planPanel.Visible = false;
            EnablePersonaForm(true);
            validacionCamposVacios.Visible = false;

            validacionEmailCartel.Visible = false;

            validacionClaveCartel.Visible = false;
        }

        private bool validacioneForm()
        {
            TextBox[] textBoxes = {nombreTextBox, apellidoTextBox, nombreUsuarioTextBox,
                direccionTextBox, telefonoTextBox, fechaNacimientoTextBox,tipoPersonaTextBox,
                idPlanTextBox};

            validacionCamposVacios.Visible = !methods.validarYPintarCamposVacios(textBoxes);
            validacionEmailCartel.Visible =  !methods.validarEmail(this.emailTextBox);
            validacionClaveCartel.Visible =  !methods.validarClaves(ClaveTextBox, repetirClaveTextBox);

            return !validacionEmailCartel.Visible
                    &&
                    !validacionCamposVacios.Visible
                    &&
                    !validacionClaveCartel.Visible;
        }

        protected void idPersonaButton_Click(object sender, EventArgs e)
        {
            AlumnosGridView.DataSource = new PersonasLogic().GetAll();
            AlumnosGridView.DataBind();
            personaPanel.Visible = !personaPanel.Visible;

        }

        protected void AlumnosGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadPersonaForm(int.Parse(AlumnosGridView.SelectedValue.ToString()));

            EnablePersonaForm(false);


            personaPanel.Visible = !personaPanel.Visible;


        }


        protected void EnablePersonaForm(bool bandera)
        {
            this.nombreTextBox.Enabled = bandera;
            this.apellidoTextBox.Enabled = bandera;
            this.telefonoTextBox.Enabled = bandera;
            this.tipoPersonaTextBox.Enabled = bandera;
            this.fechaNacimientoTextBox.Enabled = bandera;
            this.direccionTextBox.Enabled = bandera;
            this.seleccionarPlanButton.Enabled = bandera;
            this.tipoPersonaDropDownList.Enabled = bandera; 
     
        }

        protected void LoadPersonaForm(int idPersona)
        {
            Personas personaSelecionada = new PersonasLogic()
               .GetOne(idPersona);

            this.idPlanTextBox.Text = personaSelecionada.Id_Plan.ToString();
            this.idPersonaTextBox.Text = personaSelecionada.ID.ToString();
            this.nombreTextBox.Text = personaSelecionada.Nombre;
            this.apellidoTextBox.Text = personaSelecionada.Apellido;
            this.telefonoTextBox.Text = personaSelecionada.Telefono;
            this.fechaNacimientoTextBox.Text = String.Format("{0:yyyy-MM-dd}", personaSelecionada.Fecha_nac);
            this.tipoPersonaTextBox.Text = personaSelecionada.Tipo_perona.ToString();
            this.direccionTextBox.Text = personaSelecionada.Direccion;
           
        }

        protected void tipoPersonaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoPersonaTextBox.Text = tipoPersonaDropDownList.SelectedValue;
        }
        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridView.PageIndex = e.NewPageIndex;
            LoadGrid();
        }

        protected void seleccionarPlanButton_Click(object sender, EventArgs e)
        {
            planGridView.DataSource = new PlanesLogic().GetAll();
            planGridView.DataBind();
            planPanel.Visible = true;
        }

        protected void planGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPlanTextBox.Text = planGridView.SelectedValue.ToString();
            planPanel.Visible = false;
        }
        protected void AlumnosGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            AlumnosGridView.PageIndex = e.NewPageIndex;
            AlumnosGridView.DataSource = new PersonasLogic().GetAll();
            AlumnosGridView.DataBind();
        }
    }
}