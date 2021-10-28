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
    public partial class SelectCurso : Form
    {
        public SelectCurso()
        {
            InitializeComponent();
            this.dgvSelectCurso.AutoGenerateColumns = false;
        }
 
        public int Id_Curso { get; set; }

        public void Listar()
        {
            try
            {
                CursoLogic c1 = new CursoLogic();
                dgvSelectCurso.DataSource = c1.GetAll();

            } catch(Exception Error)
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

            Id.DataPropertyName = "id_curso";
            IdMateria.DataPropertyName = "id_materia";
            IdComision.DataPropertyName = "id_comision";
            AnioCalendario.DataPropertyName = "anio_calendario";
            Cupo.DataPropertyName = "cupo";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvSelectCurso.SelectedRows != null)
            {
                Id_Curso = ((Business.Entities.Curso)dgvSelectCurso.SelectedRows[0].DataBoundItem).id_curso;
                DialogResult = DialogResult.OK;
                Close();

            }
            else if (dgvSelectCurso.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un Plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectCurso_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
