namespace Business.Entities
{
    public class Docentes_Cursos : BusinessEntity
    {
        private int _id_dictado, _id_curso, _id_docente, _cargo;

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
    }
}
