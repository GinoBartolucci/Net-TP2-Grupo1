using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Modulos : UI.Desktop.ApplicationForm
    {
        public Modulos()
        {
            InitializeComponent();
            this.dgvModulos.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            ModulosLogic ml = new ModulosLogic();
           
            try
            {
                dgvModulos.DataSource = ml.GetAll();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\nError Interno: ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            id_modulo.DataPropertyName = "ID";
            desc_modulo.DataPropertyName = "desc_modulo";
            ejecuta.DataPropertyName = "ejecuta";
        }
    
        private void Modulos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvModulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ModulosDesktop ud = new ModulosDesktop(ApplicationForm.ModoForm.Alta);
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

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvModulos.SelectedRows != null)
            {
                int id = ((Business.Entities.Modulos)dgvModulos.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    ModulosDesktop ud = new ModulosDesktop(ApplicationForm.ModoForm.Modificacion, id);
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
            else if (dgvModulos.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Usuario\n para edirar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvModulos.SelectedRows != null)
            {
                int id = ((Business.Entities.Modulos)dgvModulos.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    ModulosDesktop md = new ModulosDesktop(ApplicationForm.ModoForm.Baja, id);
                    md.ShowDialog();
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
            else if (dgvModulos.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Usuario\n para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
