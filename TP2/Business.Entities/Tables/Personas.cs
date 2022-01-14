using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities 
{
    public class Personas : BusinessEntity
    {
        private string _Nombre, _Apellido, _Direccion, _Email, _Telefono;
        private int _Legajo, _Tipo_perona, _Id_Plan;
        private DateTime _Fecha_nac;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public int Legajo { get => _Legajo; set => _Legajo = value; }
        public int Tipo_perona { get => _Tipo_perona; set => _Tipo_perona = value; }
        public DateTime Fecha_nac { get => _Fecha_nac; set => _Fecha_nac = value; }

        public int Id_Plan { get => _Id_Plan; set => _Id_Plan = value; }
    }
}
