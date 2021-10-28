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
    public partial class ModuloUsuarioDesktop : ApplicationForm
    {
        public ModuloUsuarioDesktop()
        {
            InitializeComponent();
        }
        //Constructor para las altas
        public ModuloUsuarioDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            ModuloUsuarioActual = new Business.Entities.ModuloUsuario();
        }
        private Business.Entities.ModuloUsuario _ModuloUsuarioActual;
        public Business.Entities.ModuloUsuario ModuloUsuarioActual
        {
            get { return _ModuloUsuarioActual; }
            set { _ModuloUsuarioActual = value; }
        }
        public ModuloUsuarioDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtid_modulo.ReadOnly = true;
                txtid_usuario.ReadOnly = true;
                chkAlta.Enabled = false;
                chkBaja.Enabled = false;
                chkConsulta.Enabled = false;
                chkModificacion.Enabled = false;
            }
            Modo = modo; ;
            Business.Logic.ModuloUsuarioLogic mul = new Business.Logic.ModuloUsuarioLogic();
            try
            {
                ModuloUsuarioActual = mul.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        //Copia la informacion de los Usuarios en los controles del formulario (txtBox...etc (donde se
        //escribe))
        public override void MapearDeDatos()
        {
            txtid_modulo.Text = ModuloUsuarioActual.ID.ToString();
            txtid_usuario.Text = ModuloUsuarioActual.IdUsuario.ToString();
            chkAlta.Checked = ModuloUsuarioActual.PermiteAlta;
            chkBaja.Checked = ModuloUsuarioActual.PermiteBaja;
            chkConsulta.Checked = ModuloUsuarioActual.PermiteConsulta;
            chkModificacion.Checked = ModuloUsuarioActual.PermiteModificacion;

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
                ModuloUsuarioActual.State = Business.Entities.BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    ModuloUsuarioActual = new Business.Entities.ModuloUsuario();
                    ModuloUsuarioActual.State = Business.Entities.BusinessEntity.States.New;
                }
                ModuloUsuarioActual.IdModulo = int.Parse(txtid_modulo.Text);
                ModuloUsuarioActual.IdUsuario = int.Parse(txtid_usuario.Text);
                ModuloUsuarioActual.PermiteAlta = chkAlta.Checked;
                ModuloUsuarioActual.PermiteBaja = chkBaja.Checked;
                ModuloUsuarioActual.PermiteConsulta = chkConsulta.Checked;
                ModuloUsuarioActual.PermiteModificacion = chkModificacion.Checked;
            }
            if (Modo == ModoForm.Baja)
            {
                ModuloUsuarioActual.State = Business.Entities.BusinessEntity.States.Deleted;
            }
        }
        public override bool Validar()
        {
            String[] controles = { txtid_modulo.Text, txtid_usuario.Text};
            foreach (string valor in controles)
            {
                if (String.IsNullOrWhiteSpace(valor))
                {
                    Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            /* if (txtClave.Text.Length < 8 || txtClave.Text != txtConfirmarClave.Text)
            {
                Notificar("Contraseña Invalida", "Las contaseñas no coinciden\n(debe ser mayor a 8 caracteres)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!email_bien_escrito(txtEMail.Text))
            {
                Notificar("Email Invalido", "El Email ingresado es invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } */
            return true;
        }
        /*
        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        } */
        public override void GuardarCambios()
        {
            MapearADatos();
            Business.Logic.ModuloUsuarioLogic mul = new Business.Logic.ModuloUsuarioLogic();
            try
            {
                mul.Save(ModuloUsuarioActual);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

    }
}