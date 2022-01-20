using Business.Entities;
using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class PlanesDesktop : ApplicationForm
    {
        private static PlanesDesktop singleton;
        public static PlanesDesktop GetInstance()
        {
            if (singleton == null)
            {
                singleton = new PlanesDesktop();
            }
            return singleton;
        }
        public PlanesDesktop()
        {
            InitializeComponent();
        }
        public PlanesDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            PlanActual = new Business.Entities.Planes();
            PlanActual.IdEspecialidad = -1;// se pone en -1 para validar que se selecciono una FK
        }
        private Business.Entities.Planes _PlanActual;
        public Business.Entities.Planes PlanActual
        {
            get { return _PlanActual; }
            set { _PlanActual = value; }
        }
        public PlanesDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            btnSeleccionarEspecialidad.Visible = false;
            if (modo == ModoForm.Baja)
            {
                txtDesc.ReadOnly = true;
            }
            Modo = modo;       
            PlanActual = PlanesLogic.GetInstance().GetOne(ID);
            MapearDeDatos();            
        }
        public override void MapearDeDatos()
        {
            txtID.Text = PlanActual.ID.ToString();       
            txtDesc.Text = PlanActual.DescPlan;
            lbNombreEspecialidad.Text = PlanActual.DescEspecialidad;
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
                PlanActual.State = BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    PlanActual.State = BusinessEntity.States.New;
                }
                PlanActual.DescPlan = txtDesc.Text;
               /*PlanActual.id_especialidad se setea al seleccionar el boton especialidad
                Y en validacion es obligatorio seleccionar un boton antes de MapearADatos*/
            }
            if (Modo == ModoForm.Baja)
            {
                PlanActual.State = BusinessEntity.States.Deleted;
            }
        }
        public override bool Validar()
        {     
            if (String.IsNullOrWhiteSpace(txtDesc.Text))
            {
                Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PlanActual.IdEspecialidad < 0)//si no se apreto el boton seleccionar especialidad queda -1 (seteado al principio ene l constructor)
            {
                Notificar("Planes", "Debe seleccionar una Especialidad.\nSi no hay debe crear una", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
 
            return true;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            Business.Logic.PlanesLogic pl = new Business.Logic.PlanesLogic();
            pl.Save(PlanActual);                        
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tlPlan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SelectEspecialidades se = new SelectEspecialidades();
            se.ShowDialog();
            if (se.DialogResult == DialogResult.OK)
            {
                PlanActual.IdEspecialidad = se.idSelectEspecilidad;
                PlanActual.DescPlan = se.descSelectEspecialidad;
                lbNombreEspecialidad.Text = se.descSelectEspecialidad;
            }
            else if (se.DialogResult != DialogResult.OK)
            {
                Notificar("Planes", "Debe seleccionar una Especialidad.\nSi no hay debe crear una", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
