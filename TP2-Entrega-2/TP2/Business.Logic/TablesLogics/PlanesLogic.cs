using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PlanesLogic : BusinessLogic
    {
        public PlanesLogic()
        {
            PlanData = new PlanesAdapter();
        }
        private Data.Database.PlanesAdapter PlanData;

        public  Planes GetOne(int id)
        {
            return PlanData.GetOne(id);
        }

        public List<Planes> GetAll()
        {         
            return PlanData.GetAll();
        }

        public void Save( Planes p)
        {
            PlanData.Save(p);
        }
        public void Delete(int id)
        {
            PlanData.Delete(id);
        }
    }
}
