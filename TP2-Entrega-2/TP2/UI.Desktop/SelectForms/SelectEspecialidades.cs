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
    public partial class SelectEspecialidades : Form
    {
        public SelectEspecialidades()
        {
            InitializeComponent();
            dgvSelectespecialidades.AutoGenerateColumns = false;
        }
        public int idSelectEspecilidad { get; set; }
        public string descSelectEspecialidad { get; set; }
        public void Listar()
        {
            try
            {
                EspecialidadesLogic el = new EspecialidadesLogic();
                dgvSelectespecialidades.DataSource = el.GetAll();
            }
            catch (Exception Error)
            {
                var msError = "Error message: " + Error.Message;
                if (Error.InnerException != null)
                {
                    msError = msError + "\nInner exception: " + Error.InnerException.Message;
                }
                msError = msError + "\nStack trace: " + Error.StackTrace; 
                MessageBox.Show(msError, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            id_especialidad.DataPropertyName = "ID";
            desc_especialidad.DataPropertyName = "desc_especialidad";
        }

        private void SelectEspecialidades_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvSelectespecialidades.SelectedRows != null)
            {
                idSelectEspecilidad = ((Business.Entities.Especialidades)dgvSelectespecialidades.SelectedRows[0].DataBoundItem).ID;
                descSelectEspecialidad = ((Business.Entities.Especialidades)dgvSelectespecialidades.SelectedRows[0].DataBoundItem).desc_especialidad;
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (dgvSelectespecialidades.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione una Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
