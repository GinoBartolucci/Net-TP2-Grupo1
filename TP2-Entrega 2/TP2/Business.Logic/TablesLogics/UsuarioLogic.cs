﻿using System;
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
            try
            {
                return UsuarioData.GetOneId(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }            
        }
        public Business.Entities.Usuario GetOneUsuario(string nombreUsuario)
        {
            try
            {
                return UsuarioData.GetOneUsuaio(nombreUsuario);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public List<Usuario> GetAll()
        {
            //return UsuarioData.GetAll();
            
            try
            {
                return UsuarioData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void Save(Business.Entities.Usuario u)
        {
            try
            {
                UsuarioData.Save(u);
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
                UsuarioData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }            
        }
    }
}