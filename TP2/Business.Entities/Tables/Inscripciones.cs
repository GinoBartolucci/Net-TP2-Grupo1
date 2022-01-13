using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Inscripciones: BusinessEntity
    {
        private int _IdAlumno, _IdCurso, _Nota;
        private string _Condicion ;

        private string _descMateria;
        private string _descComision;
        private string _nombreApellido;
        private int _legajo;


        public int IdAlumno
        {
            get { return _IdAlumno; }
            set { _IdAlumno = value; }
        }
        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }
        public string Condicion // varchar(50) NN
        {
            get { return _Condicion; }
            set { _Condicion = value; }
        }

        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }

        public string DescMateria { get => _descMateria; set => _descMateria = value; }
        public string DescComision { get => _descComision; set => _descComision = value; }
        public string NombreApellido { get => _nombreApellido; set => _nombreApellido = value; }
        public int Legajo { get => _legajo; set => _legajo = value; }
    }
}
