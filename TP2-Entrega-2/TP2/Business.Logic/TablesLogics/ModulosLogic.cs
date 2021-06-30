using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ModulosLogic : BusinessLogic
    {
        public ModulosLogic()
        {
            ModulosData = new ModulosAdapter();
        }
        private Data.Database.ModulosAdapter ModulosData;

        public Business.Entities.Modulos GetOneId(int id)
        {
            return ModulosData.GetOneId(id);
        }
        public Business.Entities.Modulos GetOneModulos(string desc_modulo)
        {
            return ModulosData.GetOneModulos(desc_modulo);
        }
        public List<Modulos> GetAll()
        {
            return ModulosData.GetAll();
        }
        public void Save(Business.Entities.Modulos modulos)
        {
            ModulosData.Save(modulos);
        }
        public void Delete(int id)
        {
            ModulosData.Delete(id);
        }
        
    }
}

