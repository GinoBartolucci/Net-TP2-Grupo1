﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    class Comisiones
    {
        public Comisiones()
        {
            ComisionNegocio = new ComisionesLogic();
        }
        private ComisionesLogic ComisionNegocio;
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
                foreach (Business.Entities.Comisiones u in ComisionNegocio.GetAll())
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
                MostrarDatos(ComisionNegocio.GetOne(id));

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
        public void MostrarDatos(Business.Entities.Comisiones u)
        {
            Console.WriteLine("Id: {0}", u.ID);
            Console.WriteLine("\tDesripcion Comision: {0}", u.DescComision);
            Console.WriteLine("\tAnio Especialidad: {0}", u.AnioEspecialidad);
            Console.WriteLine("\tId Plan: {0}", u.IdPlan);
       
        }
        public void Agregar()
        {
            Business.Entities.Comisiones comision = new Business.Entities.Comisiones();

            Console.WriteLine("Ingrese descripcion: ");
            comision.DescComision = Console.ReadLine();
            Console.WriteLine("Ingrese Anio especialidad: ");
            comision.AnioEspecialidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Id Plan: ");
            comision.IdPlan = int.Parse(Console.ReadLine());
            
            comision.State = BusinessEntity.States.New;
            try
            {
                ComisionNegocio.Save(comision);
                Console.WriteLine("Id: {0}", comision.ID);
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
                Business.Entities.Comisiones comision = ComisionNegocio.GetOne(id);

                Console.WriteLine("\tDesripcion Comision: {0}", comision.DescComision);
                Console.WriteLine("\tAnio Especialidad: {0}", comision.AnioEspecialidad);
                Console.WriteLine("\tId Plan: {0}", comision.IdPlan);
                ComisionNegocio.Save(comision);
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
                ComisionNegocio.Delete(id);
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

