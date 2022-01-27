using System;
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
            get { 
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

            if (idIngresoTextBox.Text.Length > 0)
            {
                LoadForm(int.Parse(idIngresoTextBox.Text));
                this.FormMode = FormModes.Modificacion;
                formPanel.Visible = true;
            }
            else
            {
                // mostrarMensajeDeError("Ingresa la ID de un alumno");
            }

        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOneId(id);
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.emailTextBox.Text = this.Entity.Email;
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;

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
           
                usuario.Apellido = this.apellidoTextBox.Text;
                usuario.Nombre = this.nombreTextBox.Text;
                usuario.Email = this.emailTextBox.Text;
                usuario.Clave = this.ClaveTextBox.Text;
                usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
                usuario.Habilitado = this.habilitadoCheckBox.Checked;          

        }
        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {

            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Modificacion:
                    if (validacioneForm())
                    {
                        this.Entity = new Usuario();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        this.formPanel.Visible = false;
                    }
                    break;
                   
                default:
                    break; 
                case FormModes.Alta:
                    if (validacioneForm())
                    {
                        this.Entity = new Usuario();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        this.formPanel.Visible = false;
                    }
                    break; 
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
            this.apellidoTextBox.Text = string.Empty;
            this.nombreTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.habilitadoCheckBox.Text = string.Empty; 
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

        private bool validacioneForm()
        {
            bool bandera = false;
            int contador = 0;

            bandera = ( String.IsNullOrEmpty(nombreTextBox.Text)) ? true : false;
            contador = (bandera == true) ? contador + 1 : contador;
            validacionNombreCartel.Visible = bandera;

            bandera = (String.IsNullOrEmpty(apellidoTextBox.Text)) ? true : false;
            contador = (bandera == true) ? contador + 1 : contador;
            validacionApellidoCartel.Visible = bandera;

            bandera = (String.IsNullOrEmpty(emailTextBox.Text)) ? true : false;
            contador = (bandera == true) ? contador + 1 : contador;
            validacionEmailCartel.Visible = bandera;

            bandera = (String.IsNullOrEmpty(nombreUsuarioTextBox.Text)) ? true : false;
            contador = (bandera == true) ? contador + 1 : contador;
            validacionNombreUsuarioCartel.Visible = bandera;

            bandera = ( String.IsNullOrEmpty(ClaveTextBox.Text) || ClaveTextBox.Text != repetirClaveTextBox.Text) ? true : false;
            contador = (bandera == true) ? contador++ : contador;
            validacionClaveCartel.Visible = bandera;




            return contador == 0; 
        }
    } 
}