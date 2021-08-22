using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class ComisionesDesktop : ApplicationForm
    {
        public ComisionesDesktop()
        {
            InitializeComponent();
        }
        public ComisionesDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            ComisionActual = new Business.Entities.Comisiones();
            ComisionActual.IdPlan = -1; // se pone en -1 para validar que se selecciono una FK
        }
        private Business.Entities.Comisiones _ComisionActual;
        public Business.Entities.Comisiones ComisionActual
        {
            get { return _ComisionActual; }
            set { _ComisionActual = value; }
        }
        public ComisionesDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtAnio.ReadOnly = true;
                txtDesc.ReadOnly = true;
                btnSelectPlanes.Enabled = false; 
            }
            Modo = modo; 
            ComisionesLogic cl= new  ComisionesLogic();            
            ComisionActual = cl.GetOne(ID);
            MapearDeDatos();
                        
        }
        public override void MapearDeDatos()
        {
            txtID.Text = ComisionActual.ID.ToString();
            txtAnio.Text = ComisionActual.AnioEspecialidad.ToString();
            txtDesc.Text = ComisionActual.DescComision;
            PlanesLogic pl = new PlanesLogic();
            lbNombrePlan.Text = pl.GetOne(ComisionActual.IdPlan).desc_plan;
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
                ComisionActual.State = BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    ComisionActual.State = BusinessEntity.States.New;
                }
                ComisionActual.AnioEspecialidad = int.Parse(txtAnio.Text);
                ComisionActual.DescComision = txtDesc.Text;
                //ComisionActual.IdPlan se mapea en el metodo del boton seleccionar plan               
            }
            if (Modo == ModoForm.Baja)
            {
                ComisionActual.State = BusinessEntity.States.Deleted;
            }
        }
        public override bool Validar()
        {
            string[] labels = { txtAnio.Text, txtDesc.Text};

            foreach(string labelPosicionado in labels)
            {
                if (String.IsNullOrWhiteSpace(labelPosicionado))
                {
                    Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }                    
            }
            if (ComisionActual.IdPlan < 0)
            {
                /* txtIdPlan debe mostrar una lista de todos los nombres de los planes y al seleccionar uno 
                 ese seleccionado lo asigna a ComisionActual.IdPlan */
                Notificar("Comisiones", "Debe seleccionar un Plan.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        // anios validos

        public override void GuardarCambios()
        {
            MapearADatos();
            Business.Logic.ComisionesLogic cl= new Business.Logic.ComisionesLogic();            
            cl.Save(ComisionActual);            
        }

        private void tlComisionDesktop_Paint(object sender, PaintEventArgs e)
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
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSelectPlanes_Click(object sender, EventArgs e)
        {
            SelectPlanes sp = new SelectPlanes();
            DialogResult DRsp = sp.ShowDialog();
            if (DRsp != DialogResult.Cancel)
            {
                ComisionActual.IdPlan = sp.idSelectPlan;
                lbNombrePlan.Text = sp.descSelectPlan;
            }
            else if (DRsp == DialogResult.Cancel)
            {
                Notificar("Comisiones", "Debe seleccionar un Plan.\nSi no hay debe crear uno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

