using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Cursos
    {
        public Cursos()
        {
            CursoNegocio = new CursoLogic();
        }
        private CursoLogic CursoNegocio;
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
                foreach (Curso c in CursoNegocio.GetAll())
                {
                    MostrarDatos(c);
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
                MostrarDatos(CursoNegocio.GetOne(id));

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
        public void MostrarDatos(Curso c)
        {
            Console.WriteLine("id_curso: {0}", c.id_curso);
            Console.WriteLine("\tid_materia: {0}", c.id_materia);
            Console.WriteLine("\tid_comision: {0}", c.id_comision);
            Console.WriteLine("\tanio_calendario: {0}", c.anio_calendario);
            Console.WriteLine("\tcupo: {0}", c.cupo);
        }
        public void Agregar()
        {
            Curso curso = new Curso();

            Console.WriteLine("Ingrese ID del curso: ");
            curso.id_curso = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese ID de la materia: ");
            curso.id_materia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese ID de la comision: ");
            curso.id_comision = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año del calendario: ");
            curso.anio_calendario = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cupo: ");
            curso.cupo = int.Parse(Console.ReadLine());
            curso.State = BusinessEntity.States.New;
            try
            {
                CursoNegocio.Save(curso);
                Console.WriteLine("id_curso: {0}", curso.id_curso);
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
                Curso curso = CursoNegocio.GetOne(id);

                Console.WriteLine("Ingrese ID del curso: ");
                curso.id_curso = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese ID de la materia: ");
                curso.id_materia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese ID de la comision: ");
                curso.id_comision = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el año del calendario: ");
                curso.anio_calendario = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el cupo: ");
                curso.cupo = int.Parse(Console.ReadLine());
                curso.State = BusinessEntity.States.Modified;
                CursoNegocio.Save(curso);
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
                CursoNegocio.Delete(id);
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
