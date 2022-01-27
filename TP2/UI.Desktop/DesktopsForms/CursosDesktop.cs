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
using UI.Desktop.ABMListForms;


namespace UI.Desktop.DesktopsForms
{
    public partial class CursosDesktop : ApplicationForm
    {
        public CursosDesktop()
        {
            InitializeComponent();
        }
        public CursosDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            CursoActual = new Curso();
            btnComision.Enabled = false;
            btnMateria.Enabled = false;
        }

        private Curso _CursoActual;
        public Curso CursoActual
        {
            get { return _CursoActual; }
            set { _CursoActual = value; }
        }

        public CursosDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            btnComision.Enabled = false;
            btnMateria.Enabled = false;
            btnPlanEspecialidad.Enabled = false;
            nudAniocalendario.Enabled = false;
            if (modo == ModoForm.Baja)
            {
               
            }
            Modo = modo;
            CursoActual = CursoLogic.GetInstance().GetOne(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            txtId.Text = CursoActual.id_curso.ToString();
            nudCupo.Value = CursoActual.cupo;
            lblMateria.Text = "Id: " + CursoActual.id_materia + "\n" + CursoActual.DescMateria 
                + "\nEspe. " + CursoActual.DescEspecialidad;
            lblComision.Text = "Id: " + CursoActual.id_comision + "\nComision: " +
                CursoActual.DescComision + "\nEspe. " + CursoActual.DescEspecialidad;
            nudAniocalendario.Value = CursoActual.anio_calendario;
            lblPlanEspecialidad.Text = "Plan: " + CursoActual.DescPlan + "\nEspe.: " +CursoActual.DescEspecialidad;
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
                CursoActual.State = BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    CursoActual.State = BusinessEntity.States.New;
                }
                //CursoActual.id_curso = int.Parse(txtId.Text);
                CursoActual.cupo = Decimal.ToInt32(nudCupo.Value);
                CursoActual.anio_calendario = Decimal.ToInt32(nudAniocalendario.Value);

            }
            if (Modo == ModoForm.Baja)
            {
                CursoActual.State = BusinessEntity.States.Deleted;

            }
        }
        public override bool Validar()
        {
            if (nudAniocalendario.Value == 0 || nudCupo.Value == 0 || lblMateria.Text == "Materia" || lblComision.Text == "Comision")
            {
                Notificar("Todos los campos deben estar completos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic.GetInstance().Save(CursoActual);
        }
        private void btnMateria_Click(object sender, EventArgs e)
        {
            Materias vMaterias = new Materias(CursoActual.IdPlan);
            vMaterias.ShowDialog();

            if (vMaterias.DialogResult != DialogResult.Cancel)
            {
                CursoActual.id_materia = vMaterias.SelectIdMateria;
                CursoActual.DescMateria = vMaterias.SelectDescMateria;
                lblMateria.Text = "Id: " + CursoActual.id_materia + "\n" + CursoActual.DescMateria 
                    + "\n Espe. " + vMaterias.SelectDescEspecialidad; ;

            }
            else if (Modo != ModoForm.Modificacion)
            {
                Notificar("Materias", "Debe seleccionar una Materia.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComision_Click(object sender, EventArgs e)
        {
            Comisiones vComisiones= new Comisiones(CursoActual.IdPlan);
            vComisiones.ShowDialog();

            if (vComisiones.DialogResult != DialogResult.Cancel)
            {
                CursoActual.id_comision = vComisiones.SelectIdComision;
                CursoActual.DescComision = vComisiones.SelectDescComision;

                lblComision.Text = "Id: " + CursoActual.id_comision + "\n" + CursoActual.DescComision +
                    "\n Espe. "+vComisiones.SelectDescEspecialidad;
            }
            else if (Modo != ModoForm.Modificacion)
            {
                Notificar("Comisiones", "Debe seleccionar una Comision.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
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

        private void btnPlanEspecialidad_Click(object sender, EventArgs e)
        {
            SelectPlanes vPlanes = new SelectPlanes();
            vPlanes.ShowDialog();
            lblMateria.Text = "Materia";
            lblComision.Text = "Comision";

            if (vPlanes.DialogResult != DialogResult.Cancel)
            {
                CursoActual.DescPlan = vPlanes.descSelectPlan;
                CursoActual.DescEspecialidad = vPlanes.descSelectEspecialidad;
                CursoActual.IdPlan = vPlanes.idSelectPlan;

                lblPlanEspecialidad.Text = "Plan: " + CursoActual.DescPlan + "\nEspe.: " + CursoActual.DescEspecialidad;
                btnComision.Enabled = true;
                btnMateria.Enabled = true;
            }
            else if (Modo != ModoForm.Modificacion)
            {
                Notificar("Comisiones", "Debe seleccionar una Comision.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblPlanEspecialidad.Text = "Plan: " + CursoActual.DescPlan + "\nEspe.: " + CursoActual.DescEspecialidad;

        }
    }
}
