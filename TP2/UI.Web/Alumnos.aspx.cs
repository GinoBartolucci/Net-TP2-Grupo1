using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;


namespace UI.Web
{
    public partial class Alumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected Business.Entities.Personas Entity = new Personas();


        PersonasLogic _logic;

        private PersonasLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new PersonasLogic();
                }
                return _logic;
            }
        }

        protected void agregarAlumnoButton_Click(object sender, EventArgs e)
        {
            Entity.Nombre = nombreTextBox.Text;
            Entity.Apellido = apellidoTextBox.Text;
            Entity.Fecha_nac = DateTime.Parse(fechaNacimientoTextBox.Text);
            Entity.Legajo = int.Parse(legajoTextBox.Text);
            Entity.Telefono = telefonoTextBox.Text;
            Entity.Tipo_perona = 1;

            Logic.Save(Entity);


        }

    }
}