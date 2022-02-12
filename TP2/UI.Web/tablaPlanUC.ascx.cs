using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities; 

namespace UI.Web
{
    public partial class tablaPlanUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadPlanGrid();
        }

        private string IdSeleccionado;


        private void LoadPlanGrid()
        {
            this.planGridView.DataSource = new PlanesLogic().GetAll();
            this.planGridView.DataBind();
        }

        protected void planGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdSeleccionado = this.planGridView.SelectedValue.ToString();


        }

        public string getIdSelected()
        {
            return this.planGridView.SelectedValue != null ? 
                IdSeleccionado : string.Empty ;
        }

   

    }
}