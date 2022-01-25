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

namespace UI.Desktop.DesktopsForms
{
    public partial class CambiarPassword : Form
    {
        public CambiarPassword()
        {
            InitializeComponent();
            User = Session.currentUser;
        }
        private static CambiarPassword singleton;
        public static CambiarPassword GetInstance()
        {
            if (singleton == null)
            {
                singleton = new CambiarPassword();
            }
            return singleton;
        }
        private Usuario User { get; set; }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPass1.Text == txtPass2.Text && txtPass1.Text != User.Clave)
            {
                User.Clave = txtPass1.Text;
                User.State = BusinessEntity.States.Modified;
                UsuarioLogic.GetInstance().Save(User);
                Close();
            }
            else if (txtPass1.Text != txtPass2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass1.Text == User.Clave)
            {
                MessageBox.Show("Debe usar una contraseña diferente a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
