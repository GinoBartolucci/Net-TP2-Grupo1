using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

using Data.Database;

namespace Business.Logic
{
    public class Docentes_cursosLogic : BusinessLogic
    {        
        public Business.Entities.Docentes_cursos GetOneIdDictado(int id_dictado)
        {
            return Docentes_cursosAdapter.GetInstance().GetOneId(id_dictado);
        }
        public List<Docentes_cursos> GetAll()
        {
            return Docentes_cursosAdapter.GetInstance().GetAll(); 
        }
        public void Save(Business.Entities.Docentes_cursos docentes_cursos)
        {
            Docentes_cursosAdapter.GetInstance().Save(docentes_cursos);
        }
        public void Delete(int id)
        {
            Docentes_cursosAdapter.GetInstance().Delete(id);
        }

    }
}
