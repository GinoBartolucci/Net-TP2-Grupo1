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
        public Usuarios()
        {
            UsuarioNegocio = new UsuarioLogic();
        }
        private UsuarioLogic UsuarioNegocio;

        public void Menu()
        {
            int opciones()
            {
                Console.Clear();
                Console.WriteLine("1-Listado General");
                Console.WriteLine("2-Consulta");
                Console.WriteLine("3-Agregar");
                Console.WriteLine("4-Modificar");
                Console.WriteLine("5-Eliminar");
                Console.WriteLine("6-Salir");
                return int.Parse(Console.ReadLine());
            }
            int x = opciones();
            while (x != 6)
            {
                Console.Clear();
                switch (x)
                {
                    case 1:
                        ListadoGeneral();
                        break;
                    case 2:
                        Consultar();
                        break;
                    case 3:
                        Agregar();
                        break;
                    case 4:
                        Modificar();
                        break;
                    case 5:
                        Eliminar();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Presione una tecla para volver al menu");
                Console.ReadKey();
                Console.Clear();
                x = opciones();
            }
        }
        public void ListadoGeneral()
        {
            try
            {
                foreach (Usuario u in UsuarioNegocio.GetAll())
                {
                    MostrarDatos(u);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message +"\nError Interno: " + Ex.InnerException.Message);

            }
        }
            public void Consultar()
        {
            try
            {
                Console.WriteLine("Ingrese un id: ");
                int id = int.Parse(Console.ReadLine());
                MostrarDatos(UsuarioNegocio.GetOne(id));

            }
            catch (FormatException fe)
            {
                Console.WriteLine("La id ingresada debe ser un numero entero\n" + fe);
            }catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message + "\nError Interno: " + Ex.InnerException.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
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
        public void Agregar()
        {
            Usuario usuario = new Usuario();

            Console.WriteLine("Ingrese Nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese NombreUsuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese Clave: ");
            usuario.Clave = Console.ReadLine();
            Console.WriteLine("Ingrese EMail: ");
            usuario.EMail = Console.ReadLine();
            Console.WriteLine("Ingrese Habilitacion de Usuario 1-Si / 2-No: ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine("Id: {0}", usuario.ID);

        }
        public void Modificar()
        {
            try 
            { 
                Console.WriteLine("Ingrese un id: ");
                int id = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(id);
            
                Console.WriteLine("Ingrese Nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese NombreUsuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese Clave: ");
                usuario.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese EMail: ");
                usuario.EMail = Console.ReadLine();
                Console.WriteLine("Ingrese Habilitacion de Usuario 1-Si / 2-No: ");
                usuario.Habilitado = (Console.ReadLine()=="1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("La id ingresada debe ser un numero entero\n" + fe);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
        public void Eliminar()
        {
            try
            { 
                Console.WriteLine("Ingrese un id: ");
                int id = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(id);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("La id ingresada debe ser un numero entero\n" + fe);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
        
    }
}
