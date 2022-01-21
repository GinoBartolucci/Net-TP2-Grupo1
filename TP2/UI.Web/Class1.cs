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
    public class Class1 : System.Web.UI.Page
    {
       
          

            protected override void OnLoad(EventArgs e)

            {

                base.OnLoad(e);

            }

         void Page_Error(object sender, EventArgs e)

    {

       Server.Transfer("Error.aspx");      

    }


        
        private Business.Entities.BusinessEntity Entity { get; set; }

        Business.Logic.BusinessLogic _logic;

        private BusinessLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new BusinessLogic();
                }
                return _logic;
            }
        }


        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }


        public enum FormModes
        {
            Alta, Baja, Modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }



    }
}