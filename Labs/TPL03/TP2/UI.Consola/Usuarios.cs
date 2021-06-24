using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        public Business.Logic.UsuarioLogic UsuarioNegocio;

        public Usuarios() {
            UsuarioNegocio = new UsuarioLogic();
        }
        public void ListadoGeneral()
        {
            Console.Clear();
            foreach(Usuario u in UsuarioNegocio.GetAll())
            {
                MostrarDatos(u);
            }
        }        
        public void MostrarDatos(Usuario u)
        {
            Console.WriteLine("Usuario: {0}", u.ID);
            Console.WriteLine("\tUsuario: {0}", u.Nombre);
            Console.WriteLine("\tUsuario: {0}", u.Apellido);
            Console.WriteLine("\tUsuario: {0}", u.NombreUsuario);
            Console.WriteLine("\tUsuario: {0}", u.Clave);
            Console.WriteLine("\tUsuario: {0}", u.EMail);
            Console.WriteLine("\tUsuario: {0}", u.Habilitado);
        }
        public void Consultar()
        {

        }
        public void Agregar()
        {

        }
        public void Modificar()
        {

        }
        public void Eliminar()
        {

        }
        public void Menu()
        {
            int x=0;
            while (x != 6)
            {
                Console.Clear();
                Console.Write("1-Listado General" +
                    "2-Consulta" +
                    "3-Agregar" +
                    "4-Modificar" +
                    "5-Eliminar" +
                    "6-Salir");
                x = Console.Read();
                switch (x)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            }
        }
    }
}
