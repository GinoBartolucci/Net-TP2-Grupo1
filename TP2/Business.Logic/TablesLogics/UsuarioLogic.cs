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
        private static UsuarioLogic singleton;
        public static UsuarioLogic GetInstance()
        {
            if (singleton == null)
            {
                singleton = new UsuarioLogic();
            }
            return singleton;
        }
        public UsuarioLogic()
        {            
        }
        public Business.Entities.Usuario GetOneUsuario(string nombreUsuario)
        {                
            return UsuarioAdapter.GetInstance().GetOneUsuario(nombreUsuario);           
        }

        public Business.Entities.Usuario GetOneId(int id)
        {            
            return UsuarioAdapter.GetInstance().GetOneId(id);                     
        }
        public Business.Entities.Usuario LoginUsuario(string nombreUsuario, string clave)
        {            
            return UsuarioAdapter.GetInstance().LoginUsuario(nombreUsuario, clave);           
        }
        public List<Usuario> GetAll()
        {            
            return UsuarioAdapter.GetInstance().GetAll();            
        }
        public void Save(Business.Entities.Usuario u)
        {
            UsuarioAdapter.GetInstance().Save(u);                       
        }
        public void Delete(int id)
        {
            UsuarioAdapter.GetInstance().Delete(id);                      
        }
    }
}
