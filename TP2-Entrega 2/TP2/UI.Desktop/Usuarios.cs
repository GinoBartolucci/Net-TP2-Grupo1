﻿using System;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
        public void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();
            //dgvUsuarios.DataSource = ul.GetAll();
            try
            {
                dgvUsuarios.DataSource = ul.GetAll();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nError Interno: ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            id.DataPropertyName = "ID";
            nombre.DataPropertyName = "Nombre";
            apellido.DataPropertyName = "Apellido";
            usuario.DataPropertyName = "NombreUsuario";
            email.DataPropertyName = "EMail";
            habilitado.DataPropertyName = "Habilitado";
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tlUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDesktop ud = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
                ud.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nError Interno: " + Ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Listar();
            }
        }

        private void tsbEdiar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows != null)
            {
                int id = ((Business.Entities.Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    UsuarioDesktop ud = new UsuarioDesktop(ApplicationForm.ModoForm.Modificacion, id);
                    ud.ShowDialog();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nError Interno: " + Ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Listar();
                }
            }
            else if(dgvUsuarios.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Usuario\n para edirar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows != null)
            {
                int id = ((Business.Entities.Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    UsuarioDesktop ud = new UsuarioDesktop(ApplicationForm.ModoForm.Baja, id);
                    ud.ShowDialog();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\nError Interno: " + Ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Listar();
                }
            }
            else if (dgvUsuarios.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Usuario\n para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
