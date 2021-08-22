using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

using Data.Database;

namespace Business.Logic
{
    public class Docentes_CursosLogic : BusinessLogic
    {
        public Docentes_CursosLogic()
        {
            Docentes_CursosData = new Docentes_CursosAdapter();
        }
        private Data.Database.Docentes_CursosAdapter Docentes_CursosData;

        public Business.Entities.Docentes_Cursos GetOneIdDictado(int id_dictado)
        {
            return Docentes_CursosData.GetOneId(id_dictado);
        }
        public List<Docentes_Cursos> GetAll()
        {
            return Docentes_CursosData.GetAll(); 
        }
        public void Save(Business.Entities.Docentes_Cursos docentes_cursos)
        {
            Docentes_CursosData.Save(docentes_cursos);
        }
        public void Delete(int id)
        {
            Docentes_CursosData.Delete(id);
        }

    }
}
