using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Entities.Tables;
using Data.Database;
using Data.Database.TablesAdapters;

namespace Business.Logic.TablesLogics
{
    public class InscripcionesAlumnosLogic : BusinessLogic
    {
        public InscripcionesAlumnosLogic()
        {
            InscripcionData = new InscripcionesAlumnosAdapter();
        }
        InscripcionesAlumnosAdapter InscripcionData;

        public InscripcionesAlumnos GetOne(int id)
        {
            return InscripcionData.GetOne(id);
        }

        public List<InscripcionesAlumnos> GetAll()
        {
            return InscripcionData.GetAll();
        }

        public void Save(InscripcionesAlumnos p)
        {
            InscripcionData.Save(p);
        }
        public void Delete(int id)
        {
            InscripcionData.Delete(id);
        }
    }
}
