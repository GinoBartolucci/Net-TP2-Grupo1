using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class EspecialidadesLogic : BusinessLogic
    {
        public EspecialidadesLogic()
        {
            EspecialidadData = new EspecialidadesAdapter();

        }
        private Data.Database.EspecialidadesAdapter EspecialidadData;
    
    public Business.Entities.Especialidades GetOne(int id)
    {
        try
        {
            return EspecialidadData.GetOne(id);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }

    public List<Especialidades> GetAll()
    {
        //return UsuarioData.GetAll();

        try
        {
            return EspecialidadData.GetAll();
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    public void Save(Business.Entities.Especialidades e)
    {
        try
        {
            EspecialidadData.Save(e);
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
            EspecialidadData.Delete(id);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }
    }

    
}
