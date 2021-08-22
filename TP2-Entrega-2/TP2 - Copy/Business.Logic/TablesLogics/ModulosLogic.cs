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

        public Modulo GetOneId(int id)
        {
            return ModulosData.GetOneId(id);
        }
        public Modulo GetOneModulos(string desc_modulo)
        {
            return ModulosData.GetOneModulo(desc_modulo);
        }
        public List<Modulo> GetAll()
        {
            return ModulosData.GetAll();
        }
        public void Save(Modulo Modulo)
        {
            ModulosData.Save(Modulo);
        }
        public void Delete(int id)
        {
            ModulosData.Delete(id);
        }
        
    }
}

