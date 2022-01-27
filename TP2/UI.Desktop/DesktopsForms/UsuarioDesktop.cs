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
    public partial class UsuarioDesktop: ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }        
        public UsuarioDesktop(ModoForm modo):this()
        {
            Text = modo.ToString();
            Modo = modo;
            cbxTipoPersona.SelectedIndex = 2;
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
            btnPlan.Enabled = false;
            cbxTipoPersona.Enabled = false;

            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtLegajo.ReadOnly = true;
            dtpFechaNacimiento.Enabled = false;
            if (modo == ModoForm.Baja)
            {
                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtEMail.ReadOnly = true;
                txtUsuario.ReadOnly = true;
                txtTelefono.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                txtLegajo.ReadOnly = true;
                txtClave.ReadOnly = true;
                txtConfirmarClave.ReadOnly = true;
                dtpFechaNacimiento.Enabled = false;
                
                //chkHabilitado.Enabled = true;
            }
            Modo = modo;
            UsuarioActual = Business.Logic.UsuarioLogic.GetInstance().GetOneId(ID);
            MapearDeDatos();            
        }
        public override void MapearDeDatos()
        {
            txtID.Text = UsuarioActual.ID.ToString();
            txtNombre.Text = UsuarioActual.Nombre;
            txtEMail.Text = UsuarioActual.Email;
            txtClave.Text = UsuarioActual.Clave;
            txtApellido.Text = UsuarioActual.Apellido;
            txtUsuario.Text = UsuarioActual.NombreUsuario;
            txtConfirmarClave.Text = UsuarioActual.Clave;
            chkHabilitado.Checked = UsuarioActual.Habilitado;
            txtDireccion.Text = UsuarioActual.Direccion;
            txtTelefono.Text = UsuarioActual.Telefono;
            txtPlan.Text = UsuarioActual.DescPlan +" "+ UsuarioActual.DescEspecialidad;
            txtLegajo.Text = UsuarioActual.Legajo.ToString();
            dtpFechaNacimiento.Value = UsuarioActual.FechaNac;

            switch (UsuarioActual.TipoPersona)
            {
                case 1:
                    cbxTipoPersona.SelectedIndex = 0;
                    break;
                case 2:
                    cbxTipoPersona.SelectedIndex = 1;
                    break;
                case 3:
                    cbxTipoPersona.SelectedIndex = 2;
                    break;
                default: break;
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    btnConfirmar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    btnConfirmar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnConfirmar.Text = "Dar de Baja";
                    break;
                case ModoForm.Consulta:
                    btnConfirmar.Text = "Aceptar";
                    break;
            }
        }
        public override void MapearADatos()
        {
            UsuarioActual.State = Business.Entities.BusinessEntity.States.Modified;
            if (Modo == ModoForm.Alta)
            {
                UsuarioActual.State = Business.Entities.BusinessEntity.States.New;
            }
            switch (cbxTipoPersona.SelectedIndex)
            {
                case 0:
                    UsuarioActual.TipoPersona = 1;
                    break;
                case 1:
                    UsuarioActual.TipoPersona = 2;
                    break;
                case 2:
                    UsuarioActual.TipoPersona = 3;
                    break;
                default: break;
            }
            UsuarioActual.Nombre = txtNombre.Text;
            UsuarioActual.Email = txtEMail.Text;
            UsuarioActual.Clave = txtClave.Text;
            UsuarioActual.Apellido = txtApellido.Text;
            UsuarioActual.NombreUsuario = txtUsuario.Text;
            UsuarioActual.Clave = txtClave.Text;
            UsuarioActual.Habilitado = chkHabilitado.Checked;
            UsuarioActual.Legajo = int.Parse(txtLegajo.Text);
            UsuarioActual.FechaNac = dtpFechaNacimiento.Value;
            UsuarioActual.Direccion = txtDireccion.Text;
            UsuarioActual.Telefono = txtTelefono.Text;
            UsuarioActual.Email = txtEMail.Text;
            //UsuarioActual.State = Business.Entities.BusinessEntity.States.Deleted;
            //La baja es sacarle al habilitado
        }
        public override bool Validar()
        {   
            String[] controles = { txtNombre.Text, txtApellido.Text, txtEMail.Text, txtClave.Text, 
                txtConfirmarClave.Text, txtDireccion.Text, txtTelefono.Text, txtLegajo.Text, txtPlan.Text};
            if (!BusinessRules.ValidarCampos(controles))
            {
                Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
                       
            if (txtClave.Text.Length <8 || txtClave.Text != txtConfirmarClave.Text)
            {
                Notificar("Contraseña Invalida", "Las contaseñas no coinciden\n(debe ser mayor a 8 caracteres)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!BusinessRules.email_bien_escrito(txtEMail.Text))
            {
                Notificar("Email Invalido", "El Email ingresado es invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            Business.Logic.UsuarioLogic.GetInstance().Save(UsuarioActual);            
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

        private void btnPlan_Click(object sender, EventArgs e)
        {
            SelectPlanes selPlan = new SelectPlanes();
            selPlan.ShowDialog();
            if (selPlan.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Error al seleccionar el Plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UsuarioActual.IdPlan = selPlan.idSelectPlan;
            UsuarioActual.DescPlan = selPlan.descSelectPlan;
            txtPlan.Text = UsuarioActual.DescPlan +" "+ selPlan.descSelectEspecialidad;
        }

        private void cbxTipoPersona_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Modo == ModoForm.Alta)
            {
                switch (cbxTipoPersona.SelectedIndex)
                {
                    case 0:
                        txtLegajo.Enabled = false;
                        txtLegajo.Text = "0";
                        break;
                    case 1:
                        txtLegajo.Enabled = false;
                        txtLegajo.Text = "0";
                        break;
                    case 2:
                        txtLegajo.Enabled = true;
                        //txtLegajo.Text = UsuarioActual.Legajo.ToString();
                        break;
                    default: break;
                }
            }
        }
    }
}
