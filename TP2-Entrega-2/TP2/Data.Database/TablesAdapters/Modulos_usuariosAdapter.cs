using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database.TablesAdapters
{
    public class Modulos_usuariosAdapter
    {
        public Business.Entities.Modulos_usuarios GetOne(int id)
        {
            Modulos_usuarios moduloUsuario = new Modulos_usuarios();
            return moduloUsuario;
        }
        public List<Modulos_usuarios> GetAll()
        {
            List<Modulos_usuarios> modulosUsuarios = new List<Modulos_usuarios>();
            return modulosUsuarios;
        }
        public void Save(Modulos_usuarios mu)
        {
            
        }
        public void Delete(int id)
        {           
            
        }
    }

}
