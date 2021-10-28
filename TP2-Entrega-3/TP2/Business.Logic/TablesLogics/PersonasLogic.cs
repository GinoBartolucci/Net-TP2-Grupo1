using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities.Tables;
using Data.Database.TablesAdapters;

namespace Business.Logic.TablesLogics
{
    public class PersonasLogic : BusinessLogic
    {
        private PersonasAdapter PersonasData;

        public PersonasLogic(){
            PersonasData = new PersonasAdapter();
        }
        public Business.Entities.Tables.Personas GetOne(int id)
        {
            return PersonasData.GetOneId(id);
        }
        public List<Personas> GetAll()
        {
            return PersonasData.GetAll();
        }
        public void Save(Personas p)
        {
            PersonasData.Save(p);
        }
        public void Delete(int id)
        {
            PersonasData.Delete(id);
        }
    }
}
