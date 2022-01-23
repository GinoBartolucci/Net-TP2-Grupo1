namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private int _id_curso, _id_materia, _id_comision, _anio_calendario, _cupo;

        private string _descComision;

        private string _descMateria;

        private string _descPlan;

        private int _anioEspecialidad;

        private string _DescEspecialidad;

        private int _IdEspecialidad;

        public int id_curso
        {
            get { return _id_curso; }
            set { _id_curso = value; }
        }
        public int id_materia
        {
            get { return _id_materia; }
            set { _id_materia = value; }
        }
        public int id_comision
        {
            get { return _id_comision; }
            set { _id_comision = value; }
        }

        public int anio_calendario
        {
            get { return _anio_calendario; }
            set { _anio_calendario = value; }
        }

        public int cupo
        {
            get { return _cupo; }
            set { _cupo = value; }
        }

        public string DescComision { get => _descComision; set => _descComision = value; }
        public string DescMateria { get => _descMateria; set => _descMateria = value; }
        public string DescPlan { get => _descPlan; set => _descPlan = value; }
        public int AnioEspecialidad { get => _anioEspecialidad; set => _anioEspecialidad = value; }
        public string DescEspecialidad { get => _DescEspecialidad; set => _DescEspecialidad = value; }
        public int IdEspecialidad { get => _IdEspecialidad; set => _IdEspecialidad = value; }
    }
}