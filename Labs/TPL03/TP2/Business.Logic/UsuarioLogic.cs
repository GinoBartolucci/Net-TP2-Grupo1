using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
namespace Business.Logic
{
    public class UsuarioLogic: BusinessLogic
    {
        private Data.Database.UsuarioAdapter UsuarioData;
        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }
        public void GetOne(int id)
        {
            Business.Entities.Usuario.
        }
        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }
        public void Save()
        {

        }
        public void Delete()
        {

        }
    }
}
