﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;


namespace UI.Web
{
    public partial class Especialidades : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private Business.Entities.Especialidades Entity { get; set; }

        EspecialidadesLogic _logic;

        private EspecialidadesLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new EspecialidadesLogic();
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

        private void SaveEntity(Business.Entities.Especialidades especialidad)
        {
            this.Logic.Save(especialidad);
        }


        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
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
            this.descripcionTextBox.Text = this.Entity.desc_especialidad;

        }
        private void LoadEntity(Business.Entities.Especialidades especialidad)
        {
            especialidad.desc_especialidad = this.descripcionTextBox.Text;
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
                tituloForm.Text = "Modificar alumno";
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
                tituloForm.Text = "Editar especialidad";
            }
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            if(descripcionTextBox.Text.Length > 0)
            {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Business.Entities.Especialidades();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
                case FormModes.Alta:
                    this.Entity = new Business.Entities.Especialidades();
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
            tituloForm.Text = "Nueva especialidad";
        }


        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            if (especialidadIngresoTextBox.Text.Length > 0)
            {
                LoadForm(int.Parse(especialidadIngresoTextBox.Text));
                tituloForm.Text = "Modificar alumno";
                this.FormMode = FormModes.Modificacion;
              
            }
            else
            {
               // mostrarMensajeDeError("Ingresa la ID de un alumno");
            }
        }
    }
}