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
        //Constructor para las altas
        public ComisionesDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            ComisionActual = new Business.Entities.Comisiones();
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
                txtIdPlan.ReadOnly = true;
 
            }
            Modo = modo; 
            ComisionesLogic cl= new  ComisionesLogic();
            try
            {
                ComisionActual = cl.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        //Copia la informacion de los Comisions en los controles del formulario (txtBox...etc (donde se
        //escribe))
        public override void MapearDeDatos()
        {
            txtID.Text = ComisionActual.ID.ToString();
            txtAnio.Text = ComisionActual.AnioEspecialidad.ToString();
            txtDesc.Text = ComisionActual.DescComision;
            txtIdPlan.Text = ComisionActual.IdPlan.ToString();

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
        //Para pasar la informacion de los controles a una entidad
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                ComisionActual.State = BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    ComisionActual = new Business.Entities.Comisiones();
                    ComisionActual.State = BusinessEntity.States.New;
                }
                ComisionActual.AnioEspecialidad = int.Parse(txtAnio.Text);
                ComisionActual.DescComision = txtDesc.Text;
                ComisionActual.IdPlan =int.Parse(txtIdPlan.Text);
               

               

            }
            if (Modo == ModoForm.Baja)
            {
                ComisionActual.State = BusinessEntity.States.Deleted;
            }
        }
        public override bool Validar()
        {
            string[] labels = { txtAnio.Text, txtDesc.Text, txtIdPlan.Text };

            foreach(string labelPosicionado in labels)
            {
                if (String.IsNullOrWhiteSpace(labelPosicionado))
                {
                    Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                    /* hay que crear estas tablas antes
                    USE [tp2_net]
                    GO

                    INSERT INTO [dbo].[especialidades]
                               ([desc_especialidad])
                         VALUES
                               ('especialidad especial de la bombonera')
                    GO
                    USE [tp2_net]
                    GO

                    INSERT INTO [dbo].[planes]
                               ([desc_plan]
                               ,[id_especialidad])
                         VALUES
                               ('comision futbolera esaa',
                                1)
                    GO
                    USE [tp2_net]
                    GO

                    INSERT INTO [dbo].[comisiones]
                               ([desc_comision]
                               ,[anio_especialidad]
                               ,[id_plan])
                         VALUES
                               ('comision futbolera esaaa',2000,2)
                    GO
                    */
            }
            if (txtIdPlan.Text != "3")
            {
                /* txtIdPlan debe mostrar una lista de todos los nombres de los planes y al seleccionar uno 
                 ese seleccionado lo asigna a ComisionActual.IdPlan */
                Notificar("La unica planficacion disponible es 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public override void GuardarCambios()
        {
            MapearADatos();
            Business.Logic.ComisionesLogic cl= new Business.Logic.ComisionesLogic();
            try
            {
                cl.Save(ComisionActual);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
    }
}

