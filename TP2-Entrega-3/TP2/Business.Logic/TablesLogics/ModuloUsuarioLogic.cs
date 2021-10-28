using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
namespace Business.Logic
{/**
    public class ModuloUsuarioLogic : BusinessLogic
    {
        public ModuloUsuarioLogic()
        {
            ModuloUsuarioData = new UsuarioAdapter();
        }
        private Data.Database.UsuarioAdapter ModuloUsuarioData;

        public Business.Entities.ModuloUsuario GetOne(int id)
        {
            try
            {
                return ModuloUsuarioData.GetOneId(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public List<ModuloUsuario> GetAll()
        {
            //return UsuarioData.GetAll();

            try
            {
                return ModuloUsuarioData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void Save(Business.Entities.ModuloUsuario mu)
        {
            try
            {
                ModuloUsuarioData.Save(mu);
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
                ModuloUsuarioData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }**/
}