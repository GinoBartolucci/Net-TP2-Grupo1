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
            this.LoadGrid();
        }

        protected Business.Entities.Inscripciones Entity = new Inscripciones();


        Alumnos_inscripcionesLogic _logicInscripciones;
        Personas _logicAlumnos;

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

        private Personas LogicAlumnos
        {
            get
            {
                if (_logicAlumnos == null)
                {
                    _logicAlumnos = new Personas();
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
            this.SelectedID = (int)this.gridView.SelectedValue;
            LoadForm(this.SelectedID);
        }


        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAllAlum();
            this.gridView.DataBind();
        }

        private void LoadGridInscripciones()
        {

        }

        private void EnableForm(bool enable)
        {

          //  this.descripcionEspecialidadLabel.Visible = enable;
           // this.descripcionTextBox.Enabled = enable; // >>> ???? >> > > > > >> > > > > > > > > 
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.idTextBox.Text = Entity.ID.ToString();
            this.idAlumnoTextBox.Text = Entity.IdAlumno.ToString();
            this.idCursoTextBox.Text = Entity.DescMateria;
            this.nombreYapellidoTextBox.Text = Entity.NombreApellido;
            this.condicionTextBox.Text = Entity.Condicion.ToString();



        }
        private void LoadEntity(Business.Entities.Especialidades especialidad)
        {
         //   especialidad.desc_especialidad = this.descripcionTextBox.Text;
        }

        private void ClearForm()
        {
           
            this.idTextBox.Text = string.Empty;
            this.idAlumnoTextBox.Text = string.Empty;
            this.idCursoTextBox.Text = string.Empty;
            this.nombreYapellidoTextBox.Text = string.Empty;
            this.condicionTextBox.Text = string.Empty;
        

        }
        /// <summary>
        /// Al momento de crear un alumno (Persona), este debe crear un usuario también
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void agregarAlumnoButton_Click(object sender, EventArgs e)
        {
            /**   Entity.Nombre = nombreTextBox.Text;
               Entity.ID =  ;
                       Entity.IdAlumno = ;
                       Entity.IdCurso =  ;
                       Entity.Condicion = ;
                       Entity.Nota = ;

                       Entity.DescMateria = ;
                       Entity.DescComision =  ;
                       Entity.NombreApellido =  ;
                       Entity.Legajo = ;
               Logic.Save(Entity);
            **/

        }

        protected void modificarAlumnoButton_Click(object sender, EventArgs e)
        {
          // nombre.Text = Entity.NombreApellido;
           

        }

        protected void asignarNotaAlumnoButton_Click(object sender, EventArgs e)
        {
           // nombre.Text = Entity.NombreApellido;


        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            LoadForm(int.Parse(IdIngresoTextBox.Text));
        }
    }
}