using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
using System.Data.SqlClient;
using System;

namespace Business.Logic
{
    public class ComisionesLogic:BusinessLogic
    {

        private ComisionesAdapter ComisionesData;

        public ComisionesLogic()
        {
            ComisionesData = new ComisionesAdapter();
        }
       

        public Comisiones GetOne(int id)
        {
            try
            {
                return ComisionesData.GetOne(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public List<Comisiones> GetAll()
        {
            //return ComisionData.GetAll();

            try
            {
                return ComisionesData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void Save(Business.Entities.Comisiones c)
        {
            try
            {
                ComisionesData.Save(c);
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
                ComisionesData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}

