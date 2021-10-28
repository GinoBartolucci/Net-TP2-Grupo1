using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database.TablesAdapters;
namespace Business.Logic
{
    public class Modulos_usuariosLogic : BusinessLogic
    {
        public Modulos_usuariosLogic()
        {
            ModuloUsuarioData = new Modulos_usuariosAdapter();
        }
        private Modulos_usuariosAdapter ModuloUsuarioData;

        public Business.Entities.Modulos_usuarios GetOne(int id)
        {
            try
            {
                return ModuloUsuarioData.GetOne(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public List<Modulos_usuarios> GetAll()
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
        public void Save(Business.Entities.Modulos_usuarios mu)
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
    }
}