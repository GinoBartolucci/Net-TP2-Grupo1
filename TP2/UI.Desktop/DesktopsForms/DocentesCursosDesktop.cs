using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using UI.Desktop.SelectForms;

namespace UI.Desktop.DesktopsForms
{
    public partial class DocentesCursosDesktop : ApplicationForm
    {
        public DocentesCursosDesktop()
        {
            InitializeComponent();
            cbxCargo.SelectedIndex = 0;            
        }
        public DocentesCursosDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            DocentesCursosActual = new Docentes_cursos();
        }
        
        private int IdPlanSelec { get; set; }
        private Docentes_cursos _DocentesCursosActual;
        public Docentes_cursos DocentesCursosActual
        {
            get { return _DocentesCursosActual; }
            set { _DocentesCursosActual = value; }
        }

        public DocentesCursosDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                btnCurso.Enabled = false;
                btnDocente.Enabled = false;
            }
            Modo = modo;
            DocentesCursosActual = Docentes_cursosLogic.GetInstance().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtId.Text = DocentesCursosActual.id_dictado.ToString();
            cbxCargo.SelectedItem = DocentesCursosActual.cargo;
            lblCurso.Text = lblCurso.Text = "Id: " + DocentesCursosActual.id_curso + "\nComision: " + 
                DocentesCursosActual.DescComision + "\nMateria: " + DocentesCursosActual.DescMateria;
            lblDocente.Text = "Id: " + DocentesCursosActual.id_docente + " " + DocentesCursosActual.NombreApellido;
            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                DocentesCursosActual.State = BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    DocentesCursosActual.State = BusinessEntity.States.New;
                }
                DocentesCursosActual.id_dictado = int.Parse(txtId.Text);
                DocentesCursosActual.cargo = cbxCargo.SelectedIndex;
                
            }
            if (Modo == ModoForm.Baja)
            {
                DocentesCursosActual.State = BusinessEntity.States.Deleted;

            }
        }
        public override bool Validar()
        {             
            if (cbxCargo.SelectedIndex !=-1|| lblDocente.Text == "Docente" ||lblCurso.Text=="Curso")
            {
                Notificar("Todos los campos deben estar completos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
            return true;
        
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            Docentes_cursosLogic.GetInstance().Save(DocentesCursosActual);
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {   //si ya seleccion el docente le pasa un parametro con el id del plan del docente
            if (lblDocente.Text == "Docente") 
            {
                SelectCurso vSelectPlanes = new SelectCurso();
                vSelectPlanes.ShowDialog();
                if (vSelectPlanes.DialogResult != DialogResult.Cancel)
                {
                    DocentesCursosActual.id_curso = vSelectPlanes.IdCurso;
                    DocentesCursosActual.DescComision = vSelectPlanes.DescComision;
                    DocentesCursosActual.DescMateria = vSelectPlanes.DescMateria;
                    IdPlanSelec = vSelectPlanes.IdPlan;
                    lblCurso.Text = "Id: " + DocentesCursosActual.id_curso + "\nComision: " +
                        DocentesCursosActual.DescComision + "\nMateria: " + DocentesCursosActual.DescMateria;

                }
                else if (Modo != ModoForm.Modificacion)
                {
                    Notificar("Materias", "Debe seleccionar un Curso.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SelectCurso vSelectPlanes = new SelectCurso(IdPlanSelec);
                vSelectPlanes.ShowDialog();
                if (vSelectPlanes.DialogResult != DialogResult.Cancel)
                {
                    DocentesCursosActual.id_curso = vSelectPlanes.IdCurso;
                    DocentesCursosActual.DescComision = vSelectPlanes.DescComision;
                    DocentesCursosActual.DescMateria = vSelectPlanes.DescMateria;
                    lblCurso.Text = "Id: " + DocentesCursosActual.id_curso + "\nComision: " +
                        DocentesCursosActual.DescComision + "\nMateria: " + DocentesCursosActual.DescMateria;

                }
                else if (Modo != ModoForm.Modificacion)
                {
                    Notificar("Materias", "Debe seleccionar un Curso.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {         //si ya seleccion el curso le pasa un parametro con el id del plan del curso
            if (lblCurso.Text == "Curso")
            {
                Usuarios vSelectUsuario = new Usuarios(Usuarios.ModoForm.Docente);
                vSelectUsuario.ShowDialog();

                if (vSelectUsuario.DialogResult != DialogResult.Cancel)
                {
                    DocentesCursosActual.id_docente = vSelectUsuario.IdPersona;
                    DocentesCursosActual.Nombre = vSelectUsuario.Nombre;
                    DocentesCursosActual.Apellido = vSelectUsuario.Apellido;
                    IdPlanSelec = vSelectUsuario.IdPlan;

                    lblDocente.Text = "Id: " + DocentesCursosActual.id_docente + "\n" + DocentesCursosActual.NombreApellido;
                }
                else if (Modo != ModoForm.Modificacion)
                {
                    Notificar("Materias", "Debe seleccionar un Docente.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Usuarios vSelectUsuario = new Usuarios(Usuarios.ModoForm.Docente, IdPlanSelec);
                vSelectUsuario.ShowDialog();

                if (vSelectUsuario.DialogResult != DialogResult.Cancel)
                {
                    DocentesCursosActual.id_docente = vSelectUsuario.IdPersona;
                    DocentesCursosActual.Nombre = vSelectUsuario.Nombre;
                    DocentesCursosActual.Apellido = vSelectUsuario.Apellido;
                    lblDocente.Text = "Id: " + DocentesCursosActual.id_docente + "\n" + DocentesCursosActual.NombreApellido;
                }
                else if (Modo != ModoForm.Modificacion)
                {
                    Notificar("Materias", "Debe seleccionar un Docente.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }
    }
}
