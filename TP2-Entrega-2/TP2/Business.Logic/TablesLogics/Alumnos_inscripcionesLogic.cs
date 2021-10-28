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
    public class Alumnos_inscripcionesLogic : BusinessLogic
    {
        public Alumnos_inscripcionesLogic()
        {
            InscripcionData = new Alumnos_inscripcionesAdapter();
        }
        Alumnos_inscripcionesAdapter InscripcionData;

        public Alumnos_inscripciones GetOne(int id)
        {
            return InscripcionData.GetOne(id);
        }

        public List<Alumnos_inscripciones> GetAll()
        {
            return InscripcionData.GetAll();
        }

        public void Save(Alumnos_inscripciones p)
        {
            InscripcionData.Save(p);
        }
        public void Delete(int id)
        {
            InscripcionData.Delete(id);
        }
    }
}
