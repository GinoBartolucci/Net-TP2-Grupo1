using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //Aca agregar el metodo para el login (se habre apenas carga la aplicacion)
            Login lg = new Login();
            DialogResult loginRes = lg.ShowDialog();
            if(loginRes != DialogResult.OK)
            {
                Close();
            }
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.ShowDialog();
        }
        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades es = new Especialidades();
            es.ShowDialog();
        }
        private void btnModulos_Click(object sender, EventArgs e)
        {
            Modulos mo = new Modulos();
            mo.ShowDialog();
        }
        private void btnComisiones_Click(object sender, EventArgs e)
        {
            Comisiones co = new Comisiones();
            co.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            Planes pl = new Planes();
            pl.ShowDialog();
        }
    }
}
