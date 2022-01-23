﻿using System;
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
        public List<Personas> GetAlumnsByCourse(int idCurso)
        {
            return PersonasData.GetAlumnsByCourse(idCurso);
        }
        
        public void Save(Personas p)
        {
            PersonasData.Save(p);
        }
        public void Delete(int id)
        {
            PersonasData.Delete(id);
        }

        public List<Personas> GetAllAlumnos()
        {
            return PersonasData.GetAllAlumnos(); 
        }
        public List<Personas> GetAllDocentes()
        {
            return PersonasData.GetAllDocentes(); 
        }
    }
}
