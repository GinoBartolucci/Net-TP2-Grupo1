using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities.Tables;

namespace UI.Web
{
    public partial class Comisiones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Personas persona = (Personas)Session["current_user"];

            mostrarOpcionesABM(persona.Tipo_perona);

        }


        private void mostrarOpcionesABM(int tipoPersona)
        {
            if(tipoPersona == 3) // si es administrador
            {
                this.cancelarLinkButton.Visible = true;
                this.aceptarLinkButton.Visible = true;
                this.editarLinkButton.Visible = true;
                
            }
        }


    }
}