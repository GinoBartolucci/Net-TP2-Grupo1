using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        public string getId()
        {
            TextBox[] textBoxes = { idIngresoTextBox };
            return methods.validarYPintarCamposVacios(textBoxes)? this.idIngresoTextBox.Text: string.Empty;
        }

        public void setId(string id)
        {
            this.idIngresoTextBox.Text = id;
        }



    }
}