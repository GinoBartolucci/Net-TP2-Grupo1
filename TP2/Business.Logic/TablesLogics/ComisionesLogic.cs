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
        private static ComisionesLogic singleton;
        public static ComisionesLogic GetInstance()
        {
            if (singleton == null)
            {
                singleton = new ComisionesLogic();
            }
            return singleton;
        }
        public ComisionesLogic()
        {

        }       
        public Comisiones GetOne(int id)
        {
            return ComisionesAdapter.GetInstance().GetOne(id);            
        }
        public List<Comisiones> GetAll()
        {
            return ComisionesAdapter.GetInstance().GetAll();            
        }
        public void Save(Business.Entities.Comisiones c)
        {
            ComisionesAdapter.GetInstance().Save(c);            
        }
        public void Delete(int id)
        {
            ComisionesAdapter.GetInstance().Delete(id);           
        }
    }
}

