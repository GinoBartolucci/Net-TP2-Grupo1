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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void NotificarError(Exception Error)
        {
            var msError = "Error message: " + Error.Message;
            if (Error.InnerException != null)
            {
                msError = msError + "\nInner exception: " + Error.InnerException.Message;
            }
            msError = msError + "\nStack trace: " + Error.StackTrace;
            MessageBox.Show(msError, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void NotificarError(String Error)
        {            
            MessageBox.Show(Error, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public int tipoPersona { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Business.Logic.UsuarioLogic ul = new UsuarioLogic();
            Business.Entities.Usuario usr = new Usuario();
            try
            {
                usr = ul.GetOneUsuario(txtUsuario.Text);
                if (usr.Habilitado)
                {
                    if (usr.NombreUsuario == txtUsuario.Text && usr.Clave == txtContraseña.Text)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else if (usr.NombreUsuario != txtUsuario.Text || usr.Clave != txtContraseña.Text)
                    {
                        NotificarError("Usuario o Contraseña incorrectos");
                    }
                }
                else
                {
                    NotificarError("Usuario no Habilitado");
                }
            }
            catch(Exception Error)
            {
                NotificarError(Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {            
            Close();            
        }
    }
}
