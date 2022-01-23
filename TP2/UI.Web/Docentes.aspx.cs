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
    public partial class Docentes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            div_mensaje_error.Visible = false;
            HiddeElements();
            this.LoadGrid();
        }

        protected Business.Entities.Personas Entity = new Personas();


        Alumnos_inscripcionesLogic _logicInscripciones;
        PersonasLogic _logicDocentes;


        private PersonasLogic LogicDocentes
        {
            get
            {
                if (_logicDocentes == null)
                {
                    _logicDocentes = new PersonasLogic();
                }
                return _logicDocentes;
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


        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.DocentesGridView.SelectedValue;
            showAdminButtons();
            //LoadForm(this.SelectedID);

        }


        private void LoadGrid()
        {
            try
            {
                this.DocentesGridView.DataSource = this.LogicDocentes.GetAllDocentes();
                this.DocentesGridView.DataBind();
            }
            catch (Exception ex)
            {
                div_mensaje_error.Visible = true;
                mensaje_error.Text = ex.ToString();
            }

        }

        private void LoadGridInscripciones(int id)
        {
         


        }

        private void HiddeElements()
        {
            // BOTONES
            cursosAlumnoButton.Visible = false;
            // bajaAlumnoButton.Visible = false;
            inscripcionesAlumnoButton.Visible = false;
 
            modificarAlumnoButton.Visible = false;

            // SECCIONES
 
            form_docente.Visible = false;

        }

        private void showAdminButtons()
        {
            cursosAlumnoButton.Visible = true;
            //  bajaAlumnoButton.Visible = true;
            inscripcionesAlumnoButton.Visible = true;
            modificarAlumnoButton.Visible = true;

        }


        private void LoadForm(int id)
        {
            this.Entity = this.LogicDocentes.GetOne(id);

            this.idDocenteIngresoTextBox.Text = this.Entity.ID.ToString();
            this.nombreAlumnoTextBox.Text = this.Entity.Nombre;
            this.apellidoAlumnoTextBox.Text = this.Entity.Apellido;
            this.legajoTextBox.Text = this.Entity.Legajo.ToString();
            this.direccionAlumnoTextBox.Text = this.Entity.Direccion;
            this.telefonoTextBox.Text = this.Entity.Telefono;
            this.emailAlumnoTextBox.Text = this.Entity.Email;
            this.idPlanTextBox.Text = this.Entity.Id_Plan.ToString();
            this.fechaNacimientoTextBox.Text = this.Entity.Fecha_nac.ToString();

            form_docente.Visible = true;

        }
        private void LoadEntity(Business.Entities.Personas docente)
        {
            try
            {
                docente.Tipo_perona = 1;
                docente.Legajo = int.Parse(legajoTextBox.Text);
                docente.Nombre = nombreAlumnoTextBox.Text;
                docente.Apellido = apellidoAlumnoTextBox.Text;
                docente.Nombre = nombreAlumnoTextBox.Text;
                docente.Direccion = direccionAlumnoTextBox.Text;
                docente.Telefono = telefonoTextBox.Text;
                docente.Email = emailAlumnoTextBox.Text;
                docente.Id_Plan = int.Parse(idPlanTextBox.Text);
            }
            catch (Exception error)
            {
                mostrarMensajeDeError("Completa todos los campos" + error.ToString());
            }


            try
            {
                docente.Fecha_nac = DateTime.Parse(fechaNacimientoTextBox.Text);
            }
            catch (Exception error)
            {
                mostrarMensajeDeError("Ingrese la fecha con el siguiente formato: yyyy-mm-dd \n" + error.ToString());
            }

        }

        private void ClearForm()
        {
            this.idDocenteIngresoTextBox.Text = string.Empty;
            this.nombreAlumnoTextBox.Text = string.Empty;
            this.apellidoAlumnoTextBox.Text = string.Empty;
            this.legajoTextBox.Text = string.Empty;
            this.direccionAlumnoTextBox.Text = string.Empty;
            this.fechaNacimientoTextBox.Text = string.Empty;
        }
        /// <summary>
        /// Al momento de crear un docente (Persona), este debe crear un usuario también
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void agregarAlumnoButton_Click(object sender, EventArgs e)
        {
            ClearForm();

            this.form_docente.Visible = true;
            this.FormMode = FormModes.Alta;
            tituloForm.Text = "Agregar nuevo docente";

        }

        protected void modificarAlumnoButton_Click1(object sender, EventArgs e)
        {

            try
            {
                if (IsEntitySelected)
                {
                    ClearForm();
                    LoadForm(this.SelectedID);
                    modificarAlumnoButton.Visible = false;
                    tituloForm.Text = "Modificar docente";
                    this.FormMode = FormModes.Modificacion;
                }
                else
                {
                    mostrarMensajeDeError("Selecciona a un docente");
                }

            }
            catch (Exception ex)
            {

                mostrarMensajeDeError(ex.ToString());
            }

        }


        protected void asignarNotaAlumnoButton_Click(object sender, EventArgs e)
        {
            // nombre.Text = Entity.NombreApellido;


        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            if (idDocenteIngresoTextBox.Text.Length > 0)
            {
                LoadForm(int.Parse(idDocenteIngresoTextBox.Text));
                tituloForm.Text = "Modificar docente";
                this.FormMode = FormModes.Modificacion;
                cursosAlumnoButton.Visible = true;
                inscripcionesAlumnoButton.Visible = true;
            }
            else
            {
                mostrarMensajeDeError("Ingresa la ID de un docente");
            }

        }

        protected void inscripcionesAlumnoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (idDocenteIngresoTextBox.Text.Length > 0 || IsEntitySelected)
                {
                    LoadGridInscripciones(int.Parse(this.idDocenteIngresoTextBox.Text));
                }
                else
                {
                    mostrarMensajeDeError("Selecciona a un docente");
                }

            }
            catch (Exception ex)
            {

                mostrarMensajeDeError(ex.ToString());
            }
        }
        private void mostrarMensajeDeError(string mensaje)
        {
            div_mensaje_error.Visible = true;
            mensaje_error.Text = mensaje;
        }

        protected void asignarInscripcionButton_Click(object sender, EventArgs e)
        {

        }

        protected void formAlumnoButton_Click(object sender, EventArgs e)
        {
            Personas nuevoAlumno = new Personas();

            try
            {

                switch (this.FormMode)
                {
                    case FormModes.Baja:
                        // this.DeleteEntity(this.SelectedID);
                        this.LoadGrid();
                        break;
                    case FormModes.Modificacion:
                        this.Entity = new Business.Entities.Personas();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        LogicDocentes.Save(Entity);
                        this.LoadGrid();
                        break;
                    default:
                        break;
                    case FormModes.Alta:
                        this.Entity = new Business.Entities.Personas();
                        this.LoadEntity(this.Entity);
                        LogicDocentes.Save(Entity);
                        this.LoadGrid();
                        break;
                }
                this.form_docente.Visible = false;
            }
            catch (Exception error)
            {
                mostrarMensajeDeError(error.ToString());
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

        protected void cancelarFormAlumnoButton_Click(object sender, EventArgs e)
        {

            this.form_docente.Visible = false;
            showAdminButtons();

        }
    }


}
