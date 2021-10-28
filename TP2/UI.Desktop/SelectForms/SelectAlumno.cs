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

namespace UI.Desktop.SelectForms
{
    public partial class SelectAlumno : Form
    {
        public SelectAlumno()
        {
            InitializeComponent();
            this.dgvSelectAlumno.AutoGenerateColumns = false;
        }

        public int id_alumno { get; set; }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvSelectAlumno.SelectedRows != null)
            {
                id_alumno = ((Business.Entities.Tables.Personas)dgvSelectAlumno.SelectedRows[0].DataBoundItem).ID;
                DialogResult = DialogResult.OK;
                Close();

            }
            else if (dgvSelectAlumno.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Listar()
        {
            try
            {
                PersonasLogic a1 = new PersonasLogic();
                dgvSelectAlumno.DataSource = a1.GetAll();

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

            ID.DataPropertyName = "id_persona";
            Nombre.DataPropertyName = "nombre";
            Apellido.DataPropertyName = "apellido";
            Direccion.DataPropertyName = "direccion";
            Email.DataPropertyName = "email";
            FechaNacimiento.DataPropertyName = "fecha_nac";
            IdPlan.DataPropertyName = "id_plan";
        }

        private void SelectAlumno_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
