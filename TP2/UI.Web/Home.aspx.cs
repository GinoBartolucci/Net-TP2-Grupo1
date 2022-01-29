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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuarioActual = (Usuario)Session["current_user"];
            pantallaSegunTipoPersona(usuarioActual.DescTipoPersona);
        }


        private void pantallaSegunTipoPersona(string tipoPersona)
        {

            switch(tipoPersona)
            {
                case "Docente": pantallaDocente();  break;
                case "Alumno": pantallaAlumno(); break;
                case "Administrativo": pantallaAdminsitrador(); break;
            }
        }


        private void pantallaAlumno()
        {
            Usuario usuario = (Usuario)Session["current_user"];
            nombreAlumno.Text = usuario.Apellido + " " + usuario.Nombre;
            tipoPersonaLabel.Text = "Estudiante de " + usuario.DescEspecialidad;
            planAlumno.Text = "Plan " + usuario.DescPlan;
        }

        private void pantallaAdminsitrador()
        {
            Usuario usuario = (Usuario)Session["current_user"];
            nombreAlumno.Text = usuario.Apellido + " " + usuario.Nombre;
            tipoPersonaLabel.Text = "Administrador";
            planAlumno.Text = " " ;
        }
        private void pantallaDocente()
        {
            Usuario usuario = (Usuario)Session["current_user"];
            nombreAlumno.Text = usuario.Apellido + " " + usuario.Nombre;
            tipoPersonaLabel.Text = "Profesor";
            planAlumno.Text = " ";
        }



    }
}