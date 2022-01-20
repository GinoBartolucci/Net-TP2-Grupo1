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
        }
        private static PlanesLogic singleton;
        public static PlanesLogic GetInstance()
        {
            if (singleton == null)
            {
                singleton = new PlanesLogic();
            }
            return singleton;
        }

        public  Planes GetOne(int id)
        {
            return PlanesAdapter.GetInstance().GetOne(id);
        }

        public List<Planes> GetAll()
        {
            return PlanesAdapter.GetInstance().GetAll();
        }

        public void Save( Planes p)
        {
            PlanesAdapter.GetInstance().Save(p);
        }
        public void Delete(int id)
        {
            PlanesAdapter.GetInstance().Delete(id);
        }
    }
}
