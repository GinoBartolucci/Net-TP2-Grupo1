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
    public partial class UsuarioDesktop:ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        //Constructor para las altas
        public UsuarioDesktop(ModoForm modo):this()
        {
            Text = modo.ToString();
            Modo = modo;
            UsuarioActual = new Business.Entities.Usuario();
        }
        private Business.Entities.Usuario _UsuarioActual;
        public Business.Entities.Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
            set { _UsuarioActual = value; }
        }
        public UsuarioDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtNombre.ReadOnly = true;
                txtEMail.ReadOnly = true;
                txtClave.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtUsuario.ReadOnly = true;
                txtConfirmarClave.ReadOnly = true;
                chkHabilitado.Enabled = false;
            }
            Modo = modo;;
            Business.Logic.UsuarioLogic ul = new Business.Logic.UsuarioLogic();
            try
            {
                UsuarioActual = ul.GetOne(ID);
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
            txtID.Text = UsuarioActual.ID.ToString();
            txtNombre.Text = UsuarioActual.Nombre;
            txtEMail.Text = UsuarioActual.EMail;
            txtClave.Text = UsuarioActual.Clave;
            txtApellido.Text = UsuarioActual.Apellido;
            txtUsuario.Text = UsuarioActual.NombreUsuario;
            txtConfirmarClave.Text = UsuarioActual.Clave;
            chkHabilitado.Checked = UsuarioActual.Habilitado;
            
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
            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                UsuarioActual.State = Business.Entities.BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    UsuarioActual = new Business.Entities.Usuario();
                    UsuarioActual.State = Business.Entities.BusinessEntity.States.New;
                }
                UsuarioActual.Nombre = txtNombre.Text;
                UsuarioActual.EMail = txtEMail.Text;
                UsuarioActual.Clave = txtClave.Text;
                UsuarioActual.Apellido = txtApellido.Text;
                UsuarioActual.NombreUsuario = txtUsuario.Text;
                UsuarioActual.Clave = txtClave.Text;
                UsuarioActual.Habilitado = chkHabilitado.Checked;
            }
            if (Modo == ModoForm.Baja)
            {
                UsuarioActual.State = Business.Entities.BusinessEntity.States.Deleted;
            }
        }
        public override bool Validar()
        {
            String[] controles = { txtNombre.Text, txtEMail.Text, txtClave.Text, txtApellido.Text, txtUsuario.Text, txtConfirmarClave.Text };
            foreach (string valor in controles)
            {
                if (String.IsNullOrWhiteSpace(valor))
                {
                    Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (txtClave.Text.Length <8 || txtClave.Text != txtConfirmarClave.Text)
            {
                Notificar("Contraseña Invalida", "Las contaseñas no coinciden\n(debe ser mayor a 8 caracteres)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!email_bien_escrito(txtEMail.Text))
            {
                Notificar("Email Invalido", "El Email ingresado es invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
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
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            Business.Logic.UsuarioLogic ul = new Business.Logic.UsuarioLogic();
            try
            {
                ul.Save(UsuarioActual);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void tlUsuarioDesktop_Paint(object sender, PaintEventArgs e)
        {

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
