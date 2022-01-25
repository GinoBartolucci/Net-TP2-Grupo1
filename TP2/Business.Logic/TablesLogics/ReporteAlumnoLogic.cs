using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ReporteAlumnoLogic:BusinessLogic
    {
        private static ReporteAlumnoLogic singleton;
        public static ReporteAlumnoLogic GetInstance()
        {
            if (singleton == null)
            {
                singleton = new ReporteAlumnoLogic();
            }
            return singleton;
        }
        public ReporteAlumnoLogic()
        {

        }
        public List<ReporteAlumno> GetReporteAlumno(Usuario alumno)
        {
            return ReporteAlumnoAdapter.GetInstance().GetReporteAlumno(alumno);

        }

    }
}
