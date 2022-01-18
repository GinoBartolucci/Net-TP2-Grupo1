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
            try
            {
                {
                    if (txtUsuario.Text != "" && txtContraseña.Text != "")
                    {
                        //Business.Entities.Usuario usr = Business.Logic.UsuarioLogic.GetInstance().LoginUsuario("gino00", "123456");
                        Business.Entities.Usuario usr = Business.Logic.UsuarioLogic.GetInstance().LoginUsuario(txtUsuario.Text, txtContraseña.Text);
                        if (usr != null)
                        {
                            if (usr.Habilitado != false)
                            {
                                DialogResult = DialogResult.OK;
                                Business.Entities.Session.currentUser = usr;

                            }
                            else
                            {
                                NotificarError("Usuario no Habilitado");
                            }

                        }
                        else
                        {
                            NotificarError("Usuario o Contraseña incorrectos");
                        }
                    }
                    else
                    {
                        NotificarError("Llene todos los campos");
                    }
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
