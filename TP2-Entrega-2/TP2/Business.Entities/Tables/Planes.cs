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

            public string desc_plan
            {
                get { return _desc_plan; }
                set { _desc_plan = value; }
            }
            public int id_especialidad
            {
                get { return _id_especialidad; }
                set { _id_especialidad = value; }
            }
        }
    }
 
