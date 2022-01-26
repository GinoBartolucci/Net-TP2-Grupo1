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
    public partial class Alumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            div_mensaje_error.Visible = false;
       
            this.LoadGrid();
        }

        protected Business.Entities.Personas Entity = new Personas();


        Alumnos_inscripcionesLogic _logicInscripciones;
        PersonasLogic _logicAlumnos;

        private Alumnos_inscripcionesLogic Logic
        {
            get
            {
                if (_logicInscripciones == null)
                {
                    _logicInscripciones = new Alumnos_inscripcionesLogic();
                }
                return _logicInscripciones;
            }
        }

        private PersonasLogic LogicAlumnos
        {
            get
            {
                if (_logicAlumnos == null)
                {
                    _logicAlumnos = new PersonasLogic();
                }
                return _logicAlumnos;
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
            this.SelectedID = (int)this.AlumnosGridView.SelectedValue;
            showAdminButtons();
            //LoadForm(this.SelectedID);

        }


        private void LoadGrid()
        {
            try
            {
            this.AlumnosGridView.DataSource = this.LogicAlumnos.GetAllAlumnos();
            this.AlumnosGridView.DataBind();
            }
            catch(Exception ex)
            {
                div_mensaje_error.Visible = true;
                mensaje_error.Text = ex.ToString();
            }

        }

        private void LoadGridInscripciones(int id)
        {
            List<Business.Entities.Inscripciones> inscripcionesDelAlumno = this.Logic.GetAllAlum(id);
            if(inscripcionesDelAlumno.Count > 0)
            {
                this.gridView.DataSource = this.Logic.GetAllAlum(id);
                this.gridView.DataBind();
                inscripciones_alumno.Visible = true;
                asignarNotaInscripcionButton.Visible = true;
                darDeBajaInscripcionButton.Visible = true;
            }
            else
            {
                mostrarMensajeDeError("No se encontraron inscripciones de este alumno");
                asignarInscripcionButton.Visible = true;
            }
          

        }

        private void HiddeElements()
        { 

            // BOTONES
            cursosAlumnoButton.Visible = false;
           // bajaAlumnoButton.Visible = false;
            inscripcionesAlumnoButton.Visible = false;
            asignarNotaInscripcionButton.Visible = false;
            darDeBajaInscripcionButton.Visible = false;
            modificarAlumnoButton.Visible = false;

            // SECCIONES
            inscripciones_alumno.Visible = false;
            form_alumno.Visible = false;
            
        }

        private void modificarVistaSegunPermisosDelUsuario()
        {
            Usuario usr = (Usuario)Session["current_user"];
            switch (usr.DescTipoPersona)
            {
                case "Administrativo": break;
                case "Docente": Response.Redirect("Home.aspx"); break;
                case "Alumno": Response.Redirect("Home.aspx");  break;
            }

            HiddeElements();
        }

        private void vistaParaDocente()
        {
            agregarAlumnoButton.Visible = false;
            AlumnosGridView.Columns[0].Visible = false;
            AlumnosGridView.Columns[4].Visible = false;
            AlumnosGridView.Columns[5].Visible = false;
            AlumnosGridView.Columns[6].Visible = false;
            modificarAlumnoButton.Visible = false;


            
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
            this.Entity = this.LogicAlumnos.GetOne(id);

            this.idAlumnoIngresoTextBox.Text = this.Entity.ID.ToString();
            this.nombreAlumnoTextBox.Text = this.Entity.Nombre;
            this.apellidoAlumnoTextBox.Text = this.Entity.Apellido;
            this.legajoTextBox.Text = this.Entity.Legajo.ToString();
            this.direccionAlumnoTextBox.Text = this.Entity.Direccion;
            this.telefonoTextBox.Text = this.Entity.Telefono;
            this.emailAlumnoTextBox.Text = this.Entity.Email;
            this.idPlanTextBox.Text = this.Entity.Id_Plan.ToString();
            this.fechaNacimientoTextBox.Text = this.Entity.Fecha_nac.ToString();

            form_alumno.Visible = true;

            /**this.Entity = this.Logic.GetOne(id); 
            this.idTextBox.Text = Entity.ID.ToString();
            this.idAlumnoTextBox.Text = Entity.IdAlumno.ToString();
            this.idCursoTextBox.Text = Entity.DescMateria;
            this.nombreYapellidoTextBox.Text = Entity.NombreApellido;
            this.condicionTextBox.Text = Entity.Condicion.ToString();
            **/ 
        }
        private void LoadEntity(Business.Entities.Personas alumno)
        {
            try
            {
                alumno.Tipo_perona = 2;
                alumno.Legajo = int.Parse(legajoTextBox.Text);
                alumno.Nombre = nombreAlumnoTextBox.Text;
                alumno.Apellido = apellidoAlumnoTextBox.Text;
                alumno.Nombre = nombreAlumnoTextBox.Text;
                alumno.Direccion = direccionAlumnoTextBox.Text;
                alumno.Telefono = telefonoTextBox.Text;
                alumno.Email = emailAlumnoTextBox.Text;
                alumno.Id_Plan = int.Parse(idPlanTextBox.Text);
            }
            catch (Exception error)
            {
                mostrarMensajeDeError("Completa todos los campos" + error.ToString());
            }


            try
            {
                alumno.Fecha_nac = DateTime.Parse(fechaNacimientoTextBox.Text);
            }
            catch (Exception error)
            {
                mostrarMensajeDeError("Ingrese la fecha con el siguiente formato: yyyy-mm-dd \n" + error.ToString());
            }
          
        }

        private void ClearForm()
        { 
            this.idAlumnoIngresoTextBox.Text = string.Empty;
            this.nombreAlumnoTextBox.Text =string.Empty;
            this.apellidoAlumnoTextBox.Text = string.Empty;
            this.legajoTextBox.Text = string.Empty;
            this.direccionAlumnoTextBox.Text = string.Empty;
            this.fechaNacimientoTextBox.Text = string.Empty;
        }
        /// <summary>
        /// Al momento de crear un alumno (Persona), este debe crear un usuario también
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void agregarAlumnoButton_Click(object sender, EventArgs e)
        {
            ClearForm();

            this.form_alumno.Visible = true;
            this.FormMode = FormModes.Alta;
            tituloForm.Text = "Agregar nuevo alumno";

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
                    tituloForm.Text = "Modificar alumno";
                    this.FormMode = FormModes.Modificacion;
                }
                else
                {
                    mostrarMensajeDeError("Selecciona a un alumno");
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
            if (idAlumnoIngresoTextBox.Text.Length > 0)
            {
                LoadForm(int.Parse(idAlumnoIngresoTextBox.Text));
                tituloForm.Text = "Modificar alumno";
                this.FormMode = FormModes.Modificacion;
                cursosAlumnoButton.Visible = true;
                inscripcionesAlumnoButton.Visible = true;
            }
            else
            {
                mostrarMensajeDeError("Ingresa la ID de un alumno");
            }
             
        } 

        protected void inscripcionesAlumnoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(idAlumnoIngresoTextBox.Text.Length > 0 || IsEntitySelected )
                {
                LoadGridInscripciones(int.Parse(this.idAlumnoIngresoTextBox.Text));
                }
                else
                {
                    mostrarMensajeDeError("Selecciona a un alumno");
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
                    LogicAlumnos.Save(Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
                case FormModes.Alta:
                    this.Entity = new Business.Entities.Personas();
                    this.LoadEntity(this.Entity);
                    LogicAlumnos.Save(Entity);
                    this.LoadGrid();
                    break;
            }
            this.form_alumno.Visible = false;
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

            this.form_alumno.Visible = false;
            showAdminButtons();

        }

        protected void cursosAlumnoButton_Click(object sender, EventArgs e)
        {
            cursoGridView.DataSource = new CursoLogic().GetAllAlum(this.SelectedID);
            cursoGridView.DataBind();
            cursos_alumno.Visible = true;
        }
    }

       


    }

 
