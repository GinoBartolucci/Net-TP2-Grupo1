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

namespace UI.Desktop
{
    public partial class ModulosDesktop : ApplicationForm
    {
        public ModulosDesktop()
        {
            InitializeComponent();
        }
        public ModulosDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            ModulosActual = new Business.Entities.Modulo();
        }

        private Business.Entities.Modulo _ModulosActual;
        public Business.Entities.Modulo ModulosActual
        {
            get { return _ModulosActual; }
            set { _ModulosActual = value; }
        }
        public ModulosDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtDescripcion.ReadOnly = true;
                txtEjecuta.ReadOnly = true;
            }
            Modo = modo; ;
            Business.Logic.ModulosLogic ml = new Business.Logic.ModulosLogic();            
            ModulosActual = ml.GetOneId(ID);
            MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            txtID.Text = ModulosActual.ID.ToString();
            txtDescripcion.Text = ModulosActual.Descripcion;
            txtEjecuta.Text = ModulosActual.Ejecuta;            
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
                ModulosActual.State = Business.Entities.BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    ModulosActual = new Business.Entities.Modulo();
                    ModulosActual.State = Business.Entities.BusinessEntity.States.New;
                }
                ModulosActual.Descripcion = txtDescripcion.Text;
                ModulosActual.Ejecuta = txtEjecuta.Text;
            }
            if (Modo == ModoForm.Baja)
            {
                ModulosActual.State = Business.Entities.BusinessEntity.States.Deleted;
            }
        }
        public override bool Validar()
        {
            String[] controles = { txtDescripcion.Text, txtEjecuta.Text};
            foreach (string valor in controles)
            {
                if (String.IsNullOrWhiteSpace(valor))
                {
                    Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            Business.Logic.ModulosLogic ul = new Business.Logic.ModulosLogic();            
            ul.Save(ModulosActual);            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
