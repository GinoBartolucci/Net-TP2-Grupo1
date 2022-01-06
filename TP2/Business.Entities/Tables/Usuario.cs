using System;
namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private string _NombreUsuario, _Clave, _Nombre, _Apellido, _Email;
        private bool _Habilitado;

        private int _IdPersona, _TipoPersona, _Legajo;
        private string _Direccion, _Telefono;
        private DateTime _FechaNac;

        private int _IdPlan, _IdEspecialidad;
        private string _DescPlan;

        private string _DescEspecialidad;

        private string _DescPers;

        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Email { get => _Email; set => _Email = value; }
        public bool Habilitado { get => _Habilitado; set => _Habilitado = value; }

        public int IdPersona { get => _IdPersona; set => _IdPersona = value; }
        public int TipoPersona { get => _TipoPersona; set => _TipoPersona = value; }
        public int Legajo { get => _Legajo; set => _Legajo = value; }        
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public DateTime FechaNac { get => _FechaNac; set => _FechaNac = value; }

        public int IdPlan { get => _IdPlan; set => _IdPlan = value; }
        public int IdEspecialidad { get => _IdEspecialidad; set => _IdEspecialidad = value; }
        public string DescPlan { get => _DescPlan; set => _DescPlan = value; }
       
        public string DescEspecialidad { get => _DescEspecialidad; set => _DescEspecialidad = value; }

        public string DescTipoPersona { get => _DescPers; set => _DescPers = value; }
    
        public string NombreCompleto
        {
            get { return Nombre + Apellido; }
        }
    }
}
