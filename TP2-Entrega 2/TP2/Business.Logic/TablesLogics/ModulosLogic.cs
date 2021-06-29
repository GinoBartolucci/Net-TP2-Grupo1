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
                try
                {
                    return ModulosData.GetOneId(id);
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
            public Business.Entities.Modulos GetOneModulos(string desc_modulo)
            {
                try
                {
                    return ModulosData.GetOneModulos(desc_modulo);
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
            public List<Modulos> GetAll()
            {
                //return UsuarioData.GetAll();

                try
                {
                    return ModulosData.GetAll();
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
            public void Save(Business.Entities.Modulos modulos)
            {
                try
                {
                    ModulosData.Save(modulos);
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
                    ModulosData.Delete(id);
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
        
    }
}

