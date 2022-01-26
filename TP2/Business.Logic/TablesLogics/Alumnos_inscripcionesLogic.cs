using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
using Data.Database.TablesAdapters;

namespace Business.Logic
{
    public class Alumnos_inscripcionesLogic : BusinessLogic
    {
        public Alumnos_inscripcionesLogic()
        {
            InscripcionData = new Alumnos_inscripcionesAdapter();
        }
        Alumnos_inscripcionesAdapter InscripcionData;
        private static Alumnos_inscripcionesLogic singleton;
        public static Alumnos_inscripcionesLogic GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Alumnos_inscripcionesLogic();
            }
            return singleton;
        }

        public Inscripciones GetOne(int id)
        {
            return InscripcionData.GetOne(id);
        }       

        public List<Inscripciones> GetEveryone()
        {
            return InscripcionData.GetEveryone();
        }

        public List<Inscripciones> GetAllAlum(int idAlumno)
        {
            return InscripcionData.GetAllAlum(idAlumno);
        }
        
        public List<Inscripciones> GetAllYearAlum(int idAlumno, int year)
        {
            return InscripcionData.GetAllYearAlum(idAlumno, year);
        }

        public List<Inscripciones> GetAllCurso(int idCurso)
        {
            return InscripcionData.GetAllCurso(idCurso);
        }

        public void Save(Inscripciones p)
        {
            InscripcionData.Save(p);
        }
        public void Delete(int id)
        {
            InscripcionData.Delete(id);
        }
    }
}
