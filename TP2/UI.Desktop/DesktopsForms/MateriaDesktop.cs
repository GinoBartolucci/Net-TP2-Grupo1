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
namespace UI.Desktop.DesktopsForms
{
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();

        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            MateriaActual = new Materia();
            MateriaActual.IdPlan = -1;
        }

        private Materia _MateriaActual;
        public Materia MateriaActual
        {
            get { return _MateriaActual; }
            set { _MateriaActual = value; }
        }

        public MateriaDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            btnSeleccionarPlan.Enabled = false;
            if (modo == ModoForm.Baja)
            {
                txtId.ReadOnly = true;

            }
            Modo = modo;
            MateriaActual = MateriaLogic.GetInstance().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtId.Text = MateriaActual.ID.ToString();
            txtDescMateria.Text = MateriaActual.DescMateria;
            txtHsSemanales.Text = MateriaActual.HorasSemanales.ToString();
            lblPlan.Text = MateriaActual.DescMateria + " " + MateriaActual.DescEspecialidad;
            txtHsTotales.Text = MateriaActual.HorasTotales.ToString();


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
                    btnSeleccionarPlan.Visible = false;
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
                MateriaActual.State = BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    MateriaActual.State = BusinessEntity.States.New;
                }
                // MateriaActual.ID = int.Parse(txtId.Text);
                MateriaActual.DescMateria = txtDescMateria.Text;
                MateriaActual.HorasSemanales = int.Parse(txtHsSemanales.Text);
                MateriaActual.IdPlan = int.Parse(lblPlan.Text);
                MateriaActual.HorasTotales = int.Parse(txtHsTotales.Text);


            }
            if (Modo == ModoForm.Baja)
            {
                MateriaActual.State = BusinessEntity.States.Deleted;
              
            }
        }
        public override bool Validar()
        {
            String[] controles = { txtDescMateria.Text, txtHsSemanales.Text, txtHsTotales.Text};
            foreach (string valor in controles)
            {
                if (String.IsNullOrWhiteSpace(valor) || lblPlan.Text  == "Debés seleccionar un id plan")
                {
                    Notificar("Debe llenar todos los campos y seleccionar un id plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
 
            }
            return true;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic ul = new MateriaLogic();
            ul.Save(MateriaActual);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionarIdPlan_Click(object sender, EventArgs e)
        {
            SelectPlanes ventanaSPlanes = new SelectPlanes();
            DialogResult DRventanaSPlanes = ventanaSPlanes.ShowDialog();

            if (DRventanaSPlanes != DialogResult.Cancel)
            {
                MateriaActual.IdPlan = ventanaSPlanes.idSelectPlan;
                MateriaActual.DescMateria = ventanaSPlanes.descSelectPlan;
                MateriaActual.DescEspecialidad = ventanaSPlanes.descSelectEspecialidad;
                lblPlan.Text = MateriaActual.DescPlan +" "+ MateriaActual.DescEspecialidad;

            }
            else
            {
                Notificar("Materias", "Debe seleccionar un Plan.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 
