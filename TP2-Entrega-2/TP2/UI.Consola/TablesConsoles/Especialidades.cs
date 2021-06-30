using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Especialidades
    {
        public Especialidades()
        {
            EspecialidadesNegocio = new EspecialidadesLogic();
        }
        private EspecialidadesLogic EspecialidadesNegocio;
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
                foreach (Business.Entities.Especialidades u in EspecialidadesNegocio.GetAll())
                {
                    MostrarDatos(u);
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
                int id = int.Parse(Console.ReadLine());
                MostrarDatos(EspecialidadesNegocio.GetOne(id));

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
        public void MostrarDatos(Business.Entities.Especialidades u)
        {
            Console.WriteLine("Id: {0}", u.ID);
            Console.WriteLine("\tDesc_Especialidades: {0}", u.desc_especialidad);
        }
        public void Agregar()
        {
            Business.Entities.Especialidades especialidades = new Business.Entities.Especialidades();

            Console.WriteLine("Ingrese Descripcion: ");
            especialidades.desc_especialidad = Console.ReadLine();
            especialidades.State = BusinessEntity.States.New;
            try
            {
                EspecialidadesNegocio.Save(especialidades);
                Console.WriteLine("Id: {0}", especialidades.ID);
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
                int id = int.Parse(Console.ReadLine());
                Business.Entities.Especialidades especialidades= EspecialidadesNegocio.GetOne(id);

                Console.WriteLine("Ingrese descripcion: ");
                especialidades.desc_especialidad = Console.ReadLine();
                especialidades.State = BusinessEntity.States.Modified;
                EspecialidadesNegocio.Save(especialidades);
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
                EspecialidadesNegocio.Delete(id);
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
