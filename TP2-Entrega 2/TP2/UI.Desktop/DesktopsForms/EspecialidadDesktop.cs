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

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        private Business.Entities.Especialidades _EspecialidadActual;

        public Business.Entities.Especialidades EspecialidadActual
        {
            get { return _EspecialidadActual; }
            set { _EspecialidadActual = value; }
        }
        public EspecialidadDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            EspecialidadActual = new Business.Entities.Especialidades();
        }
        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtDescripcion.ReadOnly = true;
            }
            Modo = modo;
            Business.Logic.EspecialidadesLogic el = new Business.Logic.EspecialidadesLogic();
            try
            {
                EspecialidadActual = el.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }


        public EspecialidadDesktop()
        {
            InitializeComponent();
        }
        public override void MapearDeDatos()
        {
            txtID.Text = EspecialidadActual.ID.ToString();
            txtDescripcion.Text = EspecialidadActual.desc_especialidad;
            switch (Modo)
            {
                case ModoForm.Alta:
                    btnConfirmar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    btnConfirmar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnConfirmar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    btnConfirmar.Text = "Aceptar";
                    break;
            }
        }
        //Para pasar la informacion de los controles a una entidad
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                EspecialidadActual.State = Business.Entities.BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    EspecialidadActual = new Business.Entities.Especialidades();
                    EspecialidadActual.State = Business.Entities.BusinessEntity.States.New;
                }
                EspecialidadActual.desc_especialidad = txtDescripcion.Text;
            }
            if (Modo == ModoForm.Baja)
            {
                EspecialidadActual.State = Business.Entities.BusinessEntity.States.Deleted;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            Business.Logic.EspecialidadesLogic el = new Business.Logic.EspecialidadesLogic();
            try
            {
                el.Save(EspecialidadActual);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public override bool Validar()
        {
            String[] controles = { txtDescripcion.Text };
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

        private void btnConfirmar_Click(object sender, EventArgs e)
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
