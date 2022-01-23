using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
namespace Business.Logic
{
    public class CursoLogic : BusinessLogic
    {
        private static CursoLogic singleton;
        public static CursoLogic GetInstance()
        {
            if (singleton == null)
            {
                singleton = new CursoLogic();
            }
            return singleton;
        }

        public Business.Entities.Curso GetOne(int id)
        {
                return CursoAdapter.GetInstance().GetOne(id);            
        }
        public List<Curso> GetAll()
        {
            return CursoAdapter.GetInstance().GetAll();            
        }
        public List<Curso> GetAllYearPlan(int year, int plan)
        {
            return CursoAdapter.GetInstance().GetAllYearPlan(year, plan);            
        }
        public List<Curso> GetAllYearAlum(int idAlumno, int year)
        {            
            return CursoAdapter.GetInstance().GetAllYearAlum(idAlumno, year);            
        }

        public List<Curso> GetAllAlum(int idAlumno)
        {
            return CursoAdapter.GetInstance().GetAllAlum(idAlumno);
        }

        public List<Curso> GetAllDoc(int id_doc)
        {
            return CursoAdapter.GetInstance().GetAllDoc(id_doc);
        }
        public void Save(Business.Entities.Curso c)
        {
            CursoAdapter.GetInstance().Save(c);
        }
        public void Delete(int id)
        {
            CursoAdapter.GetInstance().Delete(id);
        }
    }
}
