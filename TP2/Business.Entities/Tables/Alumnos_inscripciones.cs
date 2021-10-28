using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities.Tables
{
    public class Alumnos_inscripciones: BusinessEntity
    {
        private int _IdAlumno, _IdCurso, _Nota;
        private string _Condicion ;
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
    }
}
