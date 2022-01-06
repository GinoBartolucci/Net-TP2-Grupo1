using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.ABMListForms;
using Business.Entities;


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
            Login lg = new Login();   
            if(lg.ShowDialog() != DialogResult.OK) //Si no logeo correctamente cierra el form
            {
                Close();
            }
            else
            {
                switch (Session.currentUser.TipoPersona)
                {
                    case 1:
                        AdminDisplay();
                        break;
                    case 2:
                        DocentesDisplay();
                        break;
                    case 3:
                        AlumnosDisplay();
                        break;
                    default:
                        break;

                }
            }
        }
        private void AlumnosDisplay()
        {
            lblNombre.Text = "Alumno: "+ Session.currentUser.NombreCompleto;
            lblPlan.Text = Session.currentUser.DescPlan;
            lblEspecialidad.Text = Session.currentUser.DescEspecialidad;
            //muestra u oculta para alumnos
        }
        private void DocentesDisplay()
        {
            //muestra u oculta para docentes
        }
        private void AdminDisplay()
        {
            //muestra u oculta para admins
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

        private void btnInscripcionesAlumnos_Click(object sender, EventArgs e)
        {
            InscripcionesAlumnos ia1 = new InscripcionesAlumnos();
            ia1.ShowDialog();
        }
    }
}
