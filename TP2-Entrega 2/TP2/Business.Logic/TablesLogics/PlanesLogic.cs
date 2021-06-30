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
            try
            {
                return PlanData.GetOne(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<Planes> GetAll()
        {
         
            try
            {
                return PlanData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Save( Planes p)
        {
            try
            {
                PlanData.Save(p);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void Delete(int id)
        {
            try
            {
                PlanData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
