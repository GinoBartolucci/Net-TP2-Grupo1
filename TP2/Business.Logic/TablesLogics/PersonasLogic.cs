using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database.TablesAdapters;

namespace Business.Logic
{
    public class PersonasLogic : BusinessLogic
    {
        private PersonasAdapter PersonasData;

        public PersonasLogic(){
            PersonasData = new PersonasAdapter();
        }
        public Business.Entities.Personas GetOne(int id)
        {
            return PersonasData.GetOne(id);
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
