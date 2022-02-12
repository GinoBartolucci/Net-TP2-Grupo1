using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class FormTablaPlanUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         //   ShowOrHideTable();
        }

        public string getIdSelected()
        {
            string idSeleccionado = this.tablaPlanUC.getIdSelected();

            if (idSeleccionado != string.Empty)
            {
             return idSeleccionado;
            // ShowOrHideTable();
            }
            else
            {
                return string.Empty;
            }

        }

        //protected void ShowOrHideTable()
        //{
        //    this.tablaPlan.Visible = !tablaPlan.Visible;
        //}
    }
}