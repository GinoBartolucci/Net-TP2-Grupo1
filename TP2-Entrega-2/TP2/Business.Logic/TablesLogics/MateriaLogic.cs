using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Entities.Tables;
using Data.Database.TablesAdapters;
using Data.Database;
namespace Business.Logic.TablesLogics
{
   public class MateriaLogic
    {
        public MateriaLogic()
        {
            MateriaData = new MateriasAdapter();
        }
        private MateriasAdapter MateriaData;

        public Materia GetOne(int id)
        {
            return MateriaData.GetOne(id);
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }

        public void Save(Materia p)
        {
            MateriaData.Save(p);
        }
        public void Delete(int id)
        {
            MateriaData.Delete(id);
        }
    }
}
