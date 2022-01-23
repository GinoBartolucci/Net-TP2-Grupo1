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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
            Modo = ModoForm.ABM;
        }
        public Usuarios(ModoForm modo) 
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
            Modo = modo;
        }
        public int IdDocente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private static Usuarios singleton;
        public static Usuarios GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Usuarios();
            }
            return singleton;
        }
        public enum ModoForm
        {
            Docente, ABM
        }
        private ModoForm _Modo;
        public ModoForm Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }
        public void Listar()
        {
            try
            {
                if (Modo == ModoForm.Docente)
                {
                    List<Usuario> listUruarios= UsuarioLogic.GetInstance().GetAll();
                    listUruarios.RemoveAll(item => item.TipoPersona != 2);
                    dgvUsuarios.DataSource = listUruarios;
                    tsUsuarios.Visible = false;
                    btnActualizar.Visible = false;
                    id.DataPropertyName = "ID";
                    TipoPersona.Visible = false;
                    usuario.DataPropertyName = "NombreUsuario";
                    legajo.Visible = false;
                    nombre.DataPropertyName = "Nombre";
                    email.DataPropertyName = "Email";
                    Especialidad.DataPropertyName = "DescEspecialidad";
                    DescPlan.DataPropertyName = "DescPlan";
                    email.DataPropertyName = "Email";
                    habilitado.DataPropertyName = "Habilitado";
                }
                else
                {
                    dgvUsuarios.DataSource = UsuarioLogic.GetInstance().GetAll();
                    id.DataPropertyName = "ID";
                    TipoPersona.DataPropertyName = "TipoPersona";
                    usuario.DataPropertyName = "NombreUsuario";
                    legajo.DataPropertyName = "Legajo";
                    nombre.DataPropertyName = "Nombre";
                    email.DataPropertyName = "Email";
                    Especialidad.DataPropertyName = "DescEspecialidad";
                    DescPlan.DataPropertyName = "DescPlan";
                    email.DataPropertyName = "EMail";
                    habilitado.DataPropertyName = "Habilitado";
                }
            }
            catch (Exception Error)
            {
                NotificarError(Error);
            }

            
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
        {//agregar inputs para persona agregar en adapter apra guardar la persona tambien
            try
            {
                UsuarioDesktop ud = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
                ud.ShowDialog();
            }
            catch (Exception Error)
            {
                NotificarError(Error);
            }
            finally
            {
                Listar();
            }
        }
        private void tsbEdiar_Click(object sender, EventArgs e)
        {//agregar inputs para persona agregar en adapter para guardar la persona tambien
            if (dgvUsuarios.SelectedRows != null)
            {
                int id = ((Business.Entities.Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    UsuarioDesktop ud = new UsuarioDesktop(ApplicationForm.ModoForm.Modificacion, id);
                    ud.ShowDialog();
                }
                catch (Exception Error)
                {
                    NotificarError(Error);
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
        {//agregar inputs para persona agregar en adapter para guardar la persona tambien solo deshabilita
            if (dgvUsuarios.SelectedRows != null)
            {
                int id = ((Business.Entities.Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    UsuarioDesktop ud = new UsuarioDesktop(ApplicationForm.ModoForm.Baja, id);
                    ud.ShowDialog();
                }
                catch (Exception Error)
                {
                    NotificarError(Error);
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count != 0)
            {
                IdDocente = ((Business.Entities.Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).IdPersona; // selecciona toda la linea y solo asigna id_curso
                Nombre = ((Business.Entities.Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).Nombre;
                Apellido = ((Business.Entities.Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).Apellido;
                DialogResult = DialogResult.OK;
                Close();

            }
            else if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error", "Seleccione un Curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
