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



    }

}
