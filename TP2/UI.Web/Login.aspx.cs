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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        private void NotificarError()
        {
            cartelErrorLabel.Visible = true;
            cartelErrorLabel.Text = "Eror al ingresar la contrasenia o el usuario ";
        }

        private void NotificarError(Exception e)
        {
            cartelErrorLabel.Visible = true;
            cartelErrorLabel.Text = e.ToString(); 
        }

        protected void ingresarButton_Click(object sender, EventArgs e)
        {
            UsuarioLogic BD = new UsuarioLogic();

            try
            {
                Usuario usuario = BD.GetOneUsuario(this.usuarioTextBox.Text);
                if (usuario.Clave == this.contraseniaTextBox.Text)
                {
                    Session["current_user"] = usuario;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    NotificarError();

                }

            }
            catch(Exception error)
            {

                NotificarError(error);
            }






        }
    }
}