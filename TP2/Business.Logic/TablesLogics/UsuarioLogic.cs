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
            UsuarioData = new UsuarioAdapter();
        }
        
        
        public Business.Entities.Usuario GetOneId(int id)
        {            
            return UsuarioData.GetOneId(id);                     
        }
        public Business.Entities.Usuario LoginUsuario(string nombreUsuario, string clave)
        {            
            return UsuarioData.LoginUsuario(nombreUsuario, clave);           
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
