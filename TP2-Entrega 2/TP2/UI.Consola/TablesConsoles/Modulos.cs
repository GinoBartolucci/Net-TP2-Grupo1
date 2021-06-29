using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;


namespace UI.Consola
{
    public class Modulos
    {
        public Modulos()
        {
            ModulosNegocio = new ModulosLogic();
        }
        private ModulosLogic ModulosNegocio;
        public void NotificarError(Exception Ex)
        {
            Console.WriteLine(Ex.Message + "\nError Interno: " + Ex.InnerException.Message);
        }
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
                foreach (Business.Entities.Modulos m in ModulosNegocio.GetAll())
                {
                   MostrarDatos(m);
                }
            }
            catch (Exception Ex)
            {
                NotificarError(Ex);
            }
        }
        public void Consultar()
        {
            try
            {
                Console.WriteLine("Ingrese un id: ");
                int id_modulos = int.Parse(Console.ReadLine());
                MostrarDatos(ModulosNegocio.GetOneId(id_modulos));

            }
            catch (FormatException fe)
            {
                Console.WriteLine("La id ingresada debe ser un numero entero\n" + fe);
            }
            catch (Exception Ex)
            {
                NotificarError(Ex);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
        public void MostrarDatos(Business.Entities.Modulos m)
        {
            Console.WriteLine("Id: {0}", m.ID);
            Console.WriteLine("\tDescripcion: {0}", m.desc_modulo);
            Console.WriteLine("\tEjecuta: {0}", m.ejecuta);
        }
        public void Agregar()
        {
            Business.Entities.Modulos modulo = new Business.Entities.Modulos();

            Console.WriteLine("Ingrese descripcion: ");
            modulo.desc_modulo = Console.ReadLine();
            Console.WriteLine("Ingrese ejecuta: ");
            modulo.ejecuta = Console.ReadLine();
            
            modulo.State = BusinessEntity.States.New;
            try
            {
                ModulosNegocio.Save(modulo);
                Console.WriteLine("Id: {0}", modulo.ID);
            }
            catch (Exception Ex)
            {
                NotificarError(Ex);
            }
        }
        public void Modificar()
        {
            try
            {
                Console.WriteLine("Ingrese un id: ");
                int id_modulos = int.Parse(Console.ReadLine());
                Business.Entities.Modulos modulos = ModulosNegocio.GetOneId(id_modulos);

                Console.WriteLine("Ingrese descripcion: ");
                modulos.desc_modulo = Console.ReadLine();
                Console.WriteLine("Ingrese ejecuta: ");
                modulos.ejecuta = Console.ReadLine();
                modulos.State = BusinessEntity.States.Modified;
                ModulosNegocio.Save(modulos);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("La id ingresada debe ser un numero entero\n" + fe);
            }
            catch (Exception Ex)
            {
                NotificarError(Ex);
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
                ModulosNegocio.Delete(id);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("La id ingresada debe ser un numero entero\n" + fe);
            }
            catch (Exception Ex)
            {
                NotificarError(Ex);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

    }
}
