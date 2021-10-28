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
            return ComisionesData.GetOne(id);            
        }
        public List<Comisiones> GetAll()
        {
            return ComisionesData.GetAll();            
        }
        public void Save(Business.Entities.Comisiones c)
        {
            ComisionesData.Save(c);            
        }
        public void Delete(int id)
        {
            ComisionesData.Delete(id);           
        }
    }
}

