using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class EspecialidadesLogic : BusinessLogic
    {
        public EspecialidadesLogic()
        {
            EspecialidadData = new EspecialidadesAdapter();
        }
        private Data.Database.EspecialidadesAdapter EspecialidadData;
    
        public Business.Entities.Especialidades GetOne(int id)
        {
            return EspecialidadData.GetOne(id);
        }

        public List<Especialidades> GetAll()
        {
            try {
                return EspecialidadData.GetAll();
            }
            catch(Exception Error)
            {
                throw Error;
            }                
        }
        public void Save(Business.Entities.Especialidades e)
        {
            EspecialidadData.Save(e);
        }
        public void Delete(int id)
        {
            EspecialidadData.Delete(id);
        }
    }

}
