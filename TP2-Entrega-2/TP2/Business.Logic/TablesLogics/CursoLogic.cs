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
        public CursoLogic()
        {
            CursoData = new CursoAdapter();
        }


        private Data.Database.CursoAdapter CursoData;

        public Business.Entities.Curso GetOne(int id)
        {
            try
            {
                return CursoData.GetOne(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public List<Curso> GetAll()
        {
            //return CursoData.GetAll();

            try
            {
                return CursoData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void Save(Business.Entities.Curso c)
        {
            try
            {
                CursoData.Save(c);
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
                CursoData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
