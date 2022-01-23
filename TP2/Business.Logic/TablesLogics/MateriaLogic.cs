using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database.TablesAdapters;
using Data.Database;
namespace Business.Logic
{
   public class MateriaLogic
    {
        private static MateriaLogic singleton;
        public static MateriaLogic GetInstance()
        {

            if (singleton == null)
            {
                singleton = new MateriaLogic();
            }

            return singleton;

        }
        public Materia GetOne(int id)
        {
            return MateriasAdapter.GetInstance().GetOne(id);
        }

        public List<Materia> GetAll()
        {
            return MateriasAdapter.GetInstance().GetAll();
        }

        public object GetAllByComision(int idComision)
        {
            return MateriasAdapter.GetInstance().GetAllByComision(idComision);
        }

        public List<Materia> GetAllPlan(int idPlan)
        {
            return MateriasAdapter.GetInstance().GetAllPlan(idPlan);
        }

        public void Save(Materia p)
        {
            MateriasAdapter.GetInstance().Save(p);
        }
        public void Delete(int id)
        {
            MateriasAdapter.GetInstance().Delete(id);
        }


    }
}
