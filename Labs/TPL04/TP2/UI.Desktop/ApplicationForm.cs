﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ApplicationForm : Form
    {
        public enum ModoForm
        {
            Alta, Baja, Modificacion, Consulta
        }
        private ModoForm _Modo;
        public ModoForm Modo
        {
            get { return _Modo; }
            set { _Modo = value; }
        }
        public ApplicationForm()
        {
            InitializeComponent();
        }
        //Copia la informacion de los Usuarios en los controles del formulario (txtBox...etc (donde se
        //escribe))
        public virtual void MapearDeDatos()
        {

        }
        //Para pasar la informacion de los controles a una entidad
        public virtual void MapearADatos()
        {

        }

        public virtual void GuardarCambion()
        {

        }
        public virtual bool Validar()
        {
            return false;
        }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            Notificar(Text, mensaje, botones, icono);
        }
    }
}
