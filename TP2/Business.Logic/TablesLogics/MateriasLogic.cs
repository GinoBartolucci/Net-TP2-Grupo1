using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database.TablesAdapters;
using Data.Database;
namespace Business.Logic.TablesLogics
{
   public class MateriasLogic
    {
        public MateriasLogic()
        {
            MateriaData = new MateriasAdapter();
        }
        private MateriasAdapter MateriaData;

        public Materias GetOne(int id)
        {
            return MateriaData.GetOne(id);
        }

        public List<Materias> GetAll()
        {
            return MateriaData.GetAll();
        }

        public void Save(Materias p)
        {
            MateriaData.Save(p);
        }
        public void Delete(int id)
        {
            MateriaData.Delete(id);
        }
    }
}
