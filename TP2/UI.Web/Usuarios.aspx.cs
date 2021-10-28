﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities.Tables;
using Business.Logic.TablesLogics;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {

        UsuarioLogic _logic;

        private UsuarioLogic Logic
        {
            get { 
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
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

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
        }
    }
}