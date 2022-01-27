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
    public static class methods 
    {



        public static bool validarYPintarCamposVacios(TextBox[] arregloTextBox)
        {
            bool bandera = true;

            foreach (TextBox uTextBox in arregloTextBox)
            {
                bandera = (uTextBox.Text == String.Empty) ? false : bandera;

                uTextBox.BorderColor = (uTextBox.Text == String.Empty) ?
                            System.Drawing.Color.Red
                            :
                            System.Drawing.Color.Empty;

            }
            return bandera;
        }


    }
}