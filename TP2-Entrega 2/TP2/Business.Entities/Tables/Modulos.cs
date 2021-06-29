using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Modulos: BusinessEntity
    { 
        string _desc_modulo;
        string _ejecuta;

        
        public string desc_modulo
        {
            get { return _desc_modulo; }
            set { _desc_modulo = value; }
        }
        public string ejecuta
        {
            get { return _ejecuta; }
            set { _ejecuta = value; }
        }

    }
}
