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
            if(Session["current_user"] != null)
            {
                Usuario usuario = (Usuario)Session["current_user"];
                nombreAlumno.Text = usuario.Apellido + " " + usuario.Nombre;
                especialidadAlumno.Text = "Estudiante de " + usuario.EMail;                
                planAlumno.Text = "Plan " + "2008";
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }


    
    }
}