using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities.Tables;
using Business.Logic.TablesLogics;
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

        public int IdSelectCurso { get; set; }

        public void Listar()
        {
            try
            {
                Business.Logic.CursoLogic c1 = new CursoLogic();
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
            // ACA VAN LOS NOMBRES CORRESPONDIENTES A LOS ATRIBUTOS
            // DE LA CLASE Cursos en BUSINESS.ENTITIES 

            ID.DataPropertyName = "ID";
            IdComision.DataPropertyName = "id_comision ";
            IdMateria.DataPropertyName = "id_materia";
            AnioCalendario.DataPropertyName = "anio_calendario";
            Cupo.DataPropertyName = "cupo";
        }

        private void dgvSelectCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
           if(dgvSelectCurso.SelectedRows != null)
            {
                IdSelectCurso = ((Business.Entities.Curso)dgvSelectCurso.SelectedRows[0].DataBoundItem).ID;
                DialogResult = DialogResult.OK;
            }
            else if (dgvSelectCurso.SelectedRows == null)
            {
                MessageBox.Show("Error", "Seleccione un curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectCurso_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
