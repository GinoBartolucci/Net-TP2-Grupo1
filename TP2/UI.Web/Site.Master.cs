using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities.Tables;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {

        private static Personas persona;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["current_user"] != null && persona == null)
            {
                Usuario usr = (Usuario)Session["current_user"];

                PersonasLogic BD = new PersonasLogic();

                //try
                //{
                    persona = BD.GetOne(usr.IdPersonas);
                  //  persona = (usr.IdPersonas >= 0) ? BD.GetOne(usr.IdPersonas) : null; // aca falta

                    if (persona != null)
                    {
                        ocultarOpcionesMenu(persona.Tipo_perona);

                        Session["current_user"] = persona;
                    }
               // }
                //catch (Exception error)
                //{

                //    // AGERGAR MODAL QUE DIGA QUE HUBO UN ERROR

                //    Response.Redirect("Login.aspx");

                //}




            }
          
            ocultarOpcionesMenu(persona.ID);
        }

        private void ocultarOpcionesMenu(int tipoPersona)
        {
            switch (tipoPersona)
            {
                case 1: // alumno

                    MenuAlumno.Visible = true;
                    break;
                case 2: // docente
                    Menu1.Visible = true;
                    break;
                case 3: // administrador
                    MenuAdministrador.Visible = true;
                    break;
                default:
                    break;
            }
        }




    }
}