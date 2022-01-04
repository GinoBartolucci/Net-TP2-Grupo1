using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Materias:BusinessEntity
    {
        private int _HorasSemanales, _HorasTotales, _IdPlan;
        private string _DescMateria;

        public int HorasSemanales
        {
            get { return _HorasSemanales; }
            set { _HorasSemanales = value;  }
        }
        public int HorasTotales
        {
            get { return _HorasTotales; }
            set { _HorasTotales = value; }
        }
        public int IdPlan
        {
            get { return _IdPlan; }
            set { _IdPlan = value; }
        } 
        public string DescMateria
        {
            get { return _DescMateria; }
            set { _DescMateria = value; }
        }
    }
}
