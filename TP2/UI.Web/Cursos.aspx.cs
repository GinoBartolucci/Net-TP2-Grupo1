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
                case "Docente": vistaParaDocente(); break;
                case "Alumno": vistaParaAlumno(); break;
            }
        }

        private void vistaParaAlumno()
        {

            formActionsPanel.Visible = false;
            gridActionsPanel.Visible = false;

            selecMateriaButton.Visible = false;
            selecComisionButton.Visible = false;
            buscadorPorID.Visible = false;
        }

        private void vistaParaDocente()
        {
            vistaParaAlumno();


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
            try
            {

                this.Logic.Save(curso);
            }
            catch (Exception er)
            {
                mensajeDeValidacionDeCampo.Visible = true;
            }
        }


        private void LoadGrid()
        {
            Usuario usr = (Usuario)Session["current_user"];
            switch (usr.DescTipoPersona)
            {
                case "Administrativo": this.gridView.DataSource = this.Logic.GetAll(); break;
                case "Docente":
                    this.gridView.DataSource = this.Logic.GetAllDoc(usr.IdPersona);
                    // this.gridView.Columns[0].Visible = false; 
                    break;
                case "Alumno":
                    this.gridView.DataSource = this.Logic.GetAllYearAlum(usr.IdPersona, DateTime.Now.Year);
                    //  this.gridView.Columns[0].Visible = false;
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
            this.idMateriaTextBox.Text = Entity.id_materia.ToString();
            this.anioCalendarioTextBox.Text = Entity.anio_calendario.ToString();
            this.cupoTextBox.Text = Entity.cupo.ToString();
            // this.idPlanTextBox.Text = Entity.IdPlan.ToString();

        }
        private void LoadEntity(Business.Entities.Curso curso)
        {
            curso.cupo = int.Parse(this.cupoTextBox.Text);
            curso.anio_calendario = int.Parse(this.anioCalendarioTextBox.Text);
            curso.id_materia = int.Parse(this.idMateriaTextBox.Text);
            curso.id_comision = int.Parse(this.idComisionTextBox.Text);
            curso.id_curso = curso.ID;
        }

        private void ClearForm()
        {

            this.cupoTextBox.Text = string.Empty;
            this.anioCalendarioTextBox.Text = string.Empty;
            this.idMateriaTextBox.Text = string.Empty;
            this.idComisionTextBox.Text = string.Empty;

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
            TextBox[] arreglo = { cupoTextBox, idMateriaTextBox, idComisionTextBox, anioCalendarioTextBox };


            if (methods.validarYPintarCamposVacios(arreglo))
            {
                switch (this.FormMode)
                {

                    case FormModes.Modificacion:
                        this.Entity = new Business.Entities.Curso();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = Business.Entities.BusinessEntity.States.Modified;
                        //this.Entity = Logic.GetOne(Entity.ID);
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
            else
            {
                mensajeDeValidacionDeCampo.Visible = true;
                this.formPanel.Visible = true;
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
            tituloForm.Text = "Nueva curso";
        }


        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
            listarAlumnosButton.Visible = true;
            alumnosDelCursoPanel.Visible = false;
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
            int idIngreso = int.Parse(this.ingresoTextBox.Text);
            if (ingresoTextBox.Text.Length > 0)
            {
                try
                {
                    ingresoTextBox.BorderColor = System.Drawing.Color.White;
                    ClearForm();
                    LoadForm(idIngreso);
                    tituloForm.Text = "Modificar curso";
                    this.FormMode = FormModes.Modificacion;
                    this.formPanel.Visible = true;
                }
                catch (Exception er)
                {

                    ingresoTextBox.BorderColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                ingresoTextBox.BorderColor = System.Drawing.Color.Red;
            }

        }
        protected void seleccionarMateriaButton(object sender, EventArgs e)
        {

            tablaComision.Visible = false;

            materiaGridView.DataSource = (idComisionTextBox.Text != String.Empty) ?
                new MateriaLogic().GetAllByComision(int.Parse(idComisionTextBox.Text))
                :
                new MateriaLogic().GetAll();
            materiaGridView.DataBind();

            tablaMateria.Visible = true;
        }

        protected void seleccionarComisionButton(object sender, EventArgs e)
        {
            tablaMateria.Visible = false;
            comisionGridView.DataSource = (idMateriaTextBox.Text != String.Empty) ?
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

        protected void listarAlumnosButton_Click(object sender, EventArgs e)
        {
            if (IsEntitySelected)
            {
                AlumnosDelCursoGridView.DataSource = new Alumnos_inscripcionesLogic().GetAllCurso(this.SelectedID);
                AlumnosDelCursoGridView.DataBind();
                alumnosDelCursoPanel.Visible = true;

            }
        }

        protected void AlumnosDelCursoGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarCondicionYNota(int.Parse(AlumnosDelCursoGridView.SelectedValue.ToString()));

        }

        protected void mostrarCondicionYNota(int idAlumno)
        {
            Business.Entities.Inscripciones inscripcionAlumno = new Alumnos_inscripcionesLogic().GetOne(idAlumno);

            notaTextBox.Text = inscripcionAlumno.Nota.ToString();
            // condicionTextBox.Text = inscripcionAlumno.Condicion;
            condicionDropDownList.SelectedValue = inscripcionAlumno.Condicion;
            notaTextBox.Enabled = false;
            if (inscripcionAlumno.Condicion == "Cursando" || inscripcionAlumno.Nota < 0)
            {

                condicionDropDownList.Enabled = true;
            }
            else
            {

                condicionDropDownList.Enabled = false;
            }

        }

        protected void asignarleNotaButton_Click(object sender, EventArgs e)
        {
            TextBox[] arregloTexBox = { notaTextBox };
            if (methods.validarYPintarCamposVacios(arregloTexBox) && condicionDropDownList.SelectedValue != string.Empty
                    && int.Parse(notaTextBox.Text) >= -1)
            {
                int idAlumnoInscripcion = int.Parse(AlumnosDelCursoGridView.SelectedValue.ToString());

                Alumnos_inscripcionesLogic aiDB = new Alumnos_inscripcionesLogic();

                Business.Entities.Inscripciones inscripcionAlumno = aiDB.GetOne(idAlumnoInscripcion);


                inscripcionAlumno.Nota = int.Parse(notaTextBox.Text);
                inscripcionAlumno.Condicion = condicionDropDownList.SelectedValue;

                inscripcionAlumno.State = Business.Entities.BusinessEntity.States.Modified;
                aiDB.Save(inscripcionAlumno);
                alumnosDelCursoPanel.Visible = false;
            }

        }

        protected void condicionDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            notaTextBox.Enabled =
                    (condicionDropDownList.SelectedValue == "Aprobado") ?
                    true
                    : false;

            notaTextBox.Text =
                    (condicionDropDownList.SelectedValue == "Aprobado") ?
                     notaTextBox.Text
                    : "-1";

        }


        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridView.PageIndex = e.NewPageIndex;
            LoadGrid();
        }


    }
}