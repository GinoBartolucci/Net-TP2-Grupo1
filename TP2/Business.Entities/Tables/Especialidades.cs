using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Especialidades : BusinessEntity
    {
        private string _desc_especialidad;
        
        public string desc_especialidad
        {
            get { return _desc_especialidad; }
            set { _desc_especialidad = value; }
        }
    }
}
