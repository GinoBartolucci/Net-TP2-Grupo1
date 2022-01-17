namespace Business.Entities
{
    public class Docentes_cursos : BusinessEntity
    {
        private int _id_dictado, _id_curso, _id_docente, _cargo;

        private string _descMateria;
        private string _descComision;
        private string _nombreApellido;

        public int id_dictado
        {
            get { return _id_dictado; }
            set { _id_dictado = value; }
        }
        public int id_curso
        {
            get { return _id_curso; }
            set { _id_curso = value; }
        }
        public int id_docente
        {
            get { return _id_docente; }
            set { _id_docente = value; }
        }

        public int cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        public string DescMateria { get => _descMateria; set => _descMateria = value; }
        public string DescComision { get => _descComision; set => _descComision = value; }
        public string NombreApellido { get => _nombreApellido; set => _nombreApellido = value; }
    }
}
