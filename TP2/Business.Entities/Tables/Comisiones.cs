using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comisiones : BusinessEntity
    {
        private int _AnioEspecialidad, _IdPlan;
        private string _DescComision;

        private string _DescPlan;
        private string _DescEspecialidad;
        private int _IdEspecialidad;

        public int AnioEspecialidad
        {
            get { return _AnioEspecialidad; }
            set { _AnioEspecialidad = value; }
        }

        public int IdPlan
        {
            get { return _IdPlan; }
            set { _IdPlan = value; }
        }

        public string DescComision
        {
            get { return _DescComision; }
            set { _DescComision = value; }
        }

        public string DescPlan { get => _DescPlan; set => _DescPlan = value; }
        public string DescEspecialidad { get => _DescEspecialidad; set => _DescEspecialidad = value; }
        public int IdEspecialidad { get => _IdEspecialidad; set => _IdEspecialidad = value; }

        public void Prueba ()
        { 
        }


    }

}
