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

        Personas persona;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current_user"] != null && persona == null)
            {
                Usuario usr = (Usuario)Session["current_user"];

                PersonasLogic BD = new PersonasLogic();


                persona = (usr.IdPersonas>=0)? BD.GetOne(usr.IdPersonas): null; // aca falta
                if(persona != null)
                {
                    ocultarOpcionesMenu(persona.Tipo_perona);

                    Session["current_user"] = persona;
                }
               


            }
        }

        private void ocultarOpcionesMenu(int tipoPersona)
        {
            switch (tipoPersona)
            {
                case 1: // alumno

                             
                        


                    break;
                case 2: // docente

                    break;
                case 3: // administrador

                    break;
                default:
                    break;
            }
        }




    }
}