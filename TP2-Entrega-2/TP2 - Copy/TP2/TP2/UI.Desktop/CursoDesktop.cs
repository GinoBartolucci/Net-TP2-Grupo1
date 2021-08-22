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
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class CursoDesktop : ApplicationForm
    {
        public CursoDesktop()
        {
            InitializeComponent();
        }
        //Constructor para las altas
        public CursoDesktop(ModoForm modo) : this()
        {
            Text = modo.ToString();
            Modo = modo;
            CursoActual = new Business.Entities.Curso();
        }
        private Business.Entities.Curso _CursoActual;
        public Business.Entities.Curso CursoActual
        {
            get { return _CursoActual; }
            set { _CursoActual = value; }
        }
        public CursoDesktop(ModoForm modo, int ID) : this()
        {
            Text = modo.ToString();
            if (modo == ModoForm.Baja)
            {
                txtid_curso.ReadOnly = true;
                txtid_materia.ReadOnly = true;
                txtid_comision.ReadOnly = true;
                txtanio_calendario.ReadOnly = true;
                txtcupo.ReadOnly = true;
            }
            Modo = modo; ;
            Business.Logic.CursoLogic cl = new Business.Logic.CursoLogic();
            try
            {
                CursoActual = cl.GetOne(ID);
                MapearDeDatos();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        //Copia la informacion de los Usuarios en los controles del formulario (txtBox...etc (donde se
        //escribe))
        public override void MapearDeDatos()
        {
            txtid_curso.Text = CursoActual.id_curso.ToString();
            txtid_materia.Text = CursoActual.id_materia.ToString();
            txtid_comision.Text = CursoActual.id_comision.ToString();
            txtanio_calendario.Text = CursoActual.anio_calendario.ToString();
            txtcupo.Text = CursoActual.cupo.ToString();

            switch (Modo)
            {
                case ModoForm.Alta:
                    btnConfirmar.Text = "Guardar";
                    break;
                case ModoForm.Modificacion:
                    btnConfirmar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnConfirmar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    btnConfirmar.Text = "Aceptar";
                    break;
            }
        }
        //Para pasar la informacion de los controles a una entidad
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                CursoActual.State = Business.Entities.BusinessEntity.States.Modified;
                if (Modo == ModoForm.Alta)
                {
                    CursoActual = new Business.Entities.Curso();
                    CursoActual.State = Business.Entities.BusinessEntity.States.New;
                }
                CursoActual.id_curso = int.Parse(txtid_curso.Text);
                CursoActual.id_materia = int.Parse(txtid_materia.Text);
                CursoActual.id_comision = int.Parse(txtid_comision.Text);
                CursoActual.anio_calendario = int.Parse(txtanio_calendario.Text);
                CursoActual.cupo = int.Parse(txtcupo.Text);
            }
            if (Modo == ModoForm.Baja)
            {
                CursoActual.State = Business.Entities.BusinessEntity.States.Deleted;
            }
        }
        public override bool Validar()
        {
            String[] controles = { txtid_curso.Text, txtid_materia.Text, txtid_comision.Text, txtanio_calendario.Text, txtcupo.Text };
            foreach (string valor in controles)
            {
                if (String.IsNullOrWhiteSpace(valor))
                {
                    Notificar("Debe llenar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            /* if (txtClave.Text.Length < 8 || txtClave.Text != txtConfirmarClave.Text)
            {
                Notificar("Contraseña Invalida", "Las contaseñas no coinciden\n(debe ser mayor a 8 caracteres)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!email_bien_escrito(txtEMail.Text))
            {
                Notificar("Email Invalido", "El Email ingresado es invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } */
            return true;
        }
        /*        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        } */
        public override void GuardarCambios()
        {
            MapearADatos();
            Business.Logic.CursoLogic cl = new Business.Logic.CursoLogic();
            try
            {
                cl.Save(CursoActual);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void tlCursoDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

