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
        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }
        private Data.Database.UsuarioAdapter UsuarioData;
        
        public Business.Entities.Usuario GetOneId(int id)
        {            
            return UsuarioData.GetOneId(id);                     
        }
        public Business.Entities.Usuario GetOneUsuario(string nombreUsuario)
        {            
            return UsuarioData.GetOneUsuaio(nombreUsuario);           
        }
        public List<Usuario> GetAll()
        {            
            return UsuarioData.GetAll();            
        }
        public void Save(Business.Entities.Usuario u)
        {            
            UsuarioData.Save(u);                       
        }
        public void Delete(int id)
        {            
            UsuarioData.Delete(id);                      
        }
    }
}
