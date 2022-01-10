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
    public partial class Site : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            nav_administrador.Visible = false;
            nav_alumno.Visible = false;

            if (Session["current_user"] != null )
            {
                Usuario usr = (Usuario)Session["current_user"];
 
                ocultarOpcionesMenu(usr.IdPersona);
   
    
            }
            else
            {

                Response.Redirect("Login.aspx");
            }
           
        }

        private void ocultarOpcionesMenu(int tipoPersona)
        {
            switch (tipoPersona)
            {
                case 1: // alumno
                   
                    nav_alumno.Visible = true;
                    break;
                case 2: // docente
                    Menu1.Visible = true;
                    break;
                case 3: // administrador
                    nav_administrador.Visible = true;
                    break;
                default:
                    break;
            }
        }




    }
}