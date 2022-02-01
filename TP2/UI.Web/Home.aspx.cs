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
           this.usuario = (Usuario)Session["current_user"];
           
            pantallaSegunTipoPersona();
        }

        private Usuario usuario;

        private void pantallaSegunTipoPersona()
        {

            switch(usuario.DescTipoPersona)
            {
                case "Docente": pantallaDocente();  break;
                case "Alumno": pantallaAlumno(); break;
                case "Administrativo": pantallaAdminsitrador(); break;
            }
        }


        private void pantallaAlumno()
        {
           
            nombreAlumno.Text = usuario.Apellido + " " + usuario.Nombre;
            tipoPersonaLabel.Text = "Estudiante de " + usuario.DescEspecialidad;
            planAlumno.Text = "Plan " + usuario.DescPlan;
        }

        private void pantallaAdminsitrador()
        {
           
            nombreAlumno.Text = usuario.Apellido + " " + usuario.Nombre;
            tipoPersonaLabel.Text = "Administrador";
            planAlumno.Text = " " ;
        }
        private void pantallaDocente()
        {
          
            nombreAlumno.Text = usuario.Apellido + " " + usuario.Nombre;
            tipoPersonaLabel.Text = "Profesor de " + usuario.DescEspecialidad;
            planAlumno.Text = " ";
        }



    }
}