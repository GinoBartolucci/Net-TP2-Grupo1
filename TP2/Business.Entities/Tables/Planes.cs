using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
 
        public class Planes : BusinessEntity
        {
            private string _desc_plan;
            private int _id_especialidad;
        private string _desc_especialidad;

            public string DescPlan
            {
                get { return _desc_plan; }
                set { _desc_plan = value; }
            }
            public int IdEspecialidad
            {
                get { return _id_especialidad; }
                set { _id_especialidad = value; }
            }

        public string DescEspecialidad { get => _desc_especialidad; set => _desc_especialidad = value; }
    }
    }
 
