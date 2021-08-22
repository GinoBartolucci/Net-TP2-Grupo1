namespace Business.Entities
{
    public class Modulo : BusinessEntity
    {
        private string _Descripcion, _Ejecuta;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string Ejecuta
        //Ejecuta
        // nombre del modulo que se ejecuta
        {
            get { return _Ejecuta; }
            set { _Ejecuta = value; }
        }
    }
}
