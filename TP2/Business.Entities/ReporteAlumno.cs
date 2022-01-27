using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ReporteAlumno
    {
        public ReporteAlumno()
        {

        }
        /*
         AnioEspecialidad | DescMateria | Condicion (DescComision)(IdCurso) (Nota) | 
         
         */
        //comision
        //private string _DescComision;
        private int _AnioEspecialidad;

        //inscipcion
        //private string _Condicion;
        //private int _nota, _IdCurso;

        //materia
        private string _DescMateria;
        private int? _IdMateria;
        private string _DescPlan;

        private string _Estado;

        //public string DescComision { get => _DescComision; set => _DescComision = value; }
        public int? AnioEspecialidad { get => _AnioEspecialidad; set => _AnioEspecialidad = (int)value; }
        //public string Condicion { get => _Condicion; set => _Condicion = value; }
        //public int Nota { get => _nota; set => _nota = value; }
        //public int IdCurso { get => _IdCurso; set => _IdCurso = value; }
        public string DescMateria { get => _DescMateria; set => _DescMateria = value; }
        public int? IdMateria { get => _IdMateria; set => _IdMateria = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string DescPlan { get => _DescPlan; set => _DescPlan = value; }
    }
}
