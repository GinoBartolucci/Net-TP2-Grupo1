using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database
{
    public class ReporteAlumnoAdapter: Adapter
    {
        private static ReporteAlumnoAdapter singleton;
        public static ReporteAlumnoAdapter GetInstance()
        {

            if (singleton == null)
            {
                singleton = new ReporteAlumnoAdapter();
            }

            return singleton;

        }
        public ReporteAlumnoAdapter()
        {

        }
        public List<ReporteAlumno> GetReporteAlumno(Usuario alumno)
        {
            List<ReporteAlumno> reporteAlumno = new List<ReporteAlumno>();
            try
            {
                OpenConnection();

                SqlCommand cmdMaterias = new SqlCommand("select distinct coalesce( com.anio_especialidad, 0) anio_especialidad, m.desc_materia, m.id_materia, p.desc_plan " +
                    "from materias m " +
                    "inner join planes p on p.id_plan = m.id_plan " +
                    "left join cursos c on c.id_materia = m.id_materia " +                    
                    "left join comisiones com on com.id_comision = c.id_comision " +
                    "where m.id_plan = @IdPlan",sqlConn);                
                cmdMaterias.Parameters.Add("@IdPlan", SqlDbType.Int).Value = alumno.IdPlan;

                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                while (drMaterias.Read())
                {
                    ReporteAlumno report = new ReporteAlumno();


                    report.AnioEspecialidad = (int)drMaterias["anio_especialidad"];
                    report.DescMateria = (string)drMaterias["desc_materia"];
                    report.IdMateria = (int)drMaterias["id_materia"];
                    report.DescPlan = (string)drMaterias["desc_plan"];


                    if (report.AnioEspecialidad != 0)// si es 0 es porque la materia no tiene comision por lo tanto no tiene anio_especialidad
                    {
                        reporteAlumno.Add(report);
                    }

                }
                drMaterias.Close();

                SqlCommand cmdCursada = new SqlCommand("select com.desc_comision, m.id_materia, coalesce(ai.condicion,'') condicion, ai.nota " +
                    "from cursos c " +
                    "inner join alumnos_inscripciones ai on ai.id_curso=c.id_curso " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "where ai.id_alumno=@IdAlumno ", sqlConn);
                cmdCursada.Parameters.Add("@IdAlumno", SqlDbType.Int).Value = alumno.IdPersona;

                SqlDataReader drCursada= cmdCursada.ExecuteReader();

                while (drCursada.Read())
                {
                    ReporteAlumno report = new ReporteAlumno();

                    switch ((string)drCursada["condicion"])
                    {
                        case "":
                            report.Estado = "";
                            break;
                        case "Libre":
                            report.Estado = "Libre";
                            break;
                        case "Cursando":
                            report.Estado = "Cursa en: " + (string)drCursada["desc_comision"];                            
                            break;
                        case "Regular":
                            report.Estado = "Regular";
                            break;
                        case "Aprobado":
                            report.Estado = "Aprobado con " + ((int)drCursada["nota"]).ToString();
                            break;
                        default:
                            report.Estado = "";
                            break;
                    }

                    report.IdMateria = (int)drCursada["id_materia"];
                    //añadir a donde id_materia = id_materia
                    foreach(var r in reporteAlumno)
                    {
                        if(r.IdMateria== report.IdMateria)
                        {
                            r.Estado = report.Estado;
                            
                        }
                    }
                }
                drCursada.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de cursos GetAll()", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return reporteAlumno;

        }

        public List<ReporteAlumno> GetReportesDelAlumno(int?  idPersona)
        {
            List<ReporteAlumno> reporteAlumno = new List<ReporteAlumno>();
            try
            {
                OpenConnection();
 

                SqlCommand cmdMaterias = new SqlCommand("SELECT  ISNULL(com.anio_especialidad,0) anio_especialidad, ISNULL(com.desc_comision,' ') desc_comision, " +
                    " m.desc_materia, m.id_materia, " +
                    " ISNULL(ai.condicion,'') condicion, ISNULL(ai.nota,0) nota,  " +
                    " pl.desc_plan " +
                    " FROM materias m " +
                    " LEFT JOIN cursos c ON c.id_materia = m.id_materia " +
                    " LEFT JOIN comisiones com ON com.id_comision = c.id_comision " +
                    " LEFT JOIN alumnos_inscripciones ai ON ai.id_curso = c.id_curso " +
                    " LEFT JOIN personas p ON p.id_persona = ai.id_alumno " +
                    " LEFT JOIN planes pl ON m.id_plan = pl.id_plan " +
                    " WHERE p.id_persona = @idPersona or p.id_persona is null", sqlConn);
                
                cmdMaterias.Parameters.Add("@idPersona", SqlDbType.Int).Value = idPersona;

                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                while (drMaterias.Read())
                {
                    ReporteAlumno report = new ReporteAlumno();
 
                    report.AnioEspecialidad = (int)drMaterias["anio_especialidad"];
                    report.DescMateria = (string)drMaterias["desc_materia"];
                    report.IdMateria = (int)drMaterias["id_materia"];
                    report.DescPlan = (string)drMaterias["desc_plan"];

                    switch ((string)drMaterias["condicion"])
                    {
                        case "":
                            report.Estado = "";
                            break;
                        case "Libre":
                            report.Estado = "Libre";
                            break;
                        case "Cursando":
                            report.Estado = "Cursa en: " + (string)drMaterias["desc_comision"];
                            break;
                        case "Regular":
                            report.Estado = "Regular";
                            break;
                        case "Aprobado":
                            report.Estado = "Aprobado con " + ((int)drMaterias["nota"]).ToString();
                            break;
                    }

                   


                    reporteAlumno.Add(report);
                }
                drMaterias.Close();
 

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de cursos GetAll() " + Ex.ToString(), Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return reporteAlumno;

        }
    }
}
/*
                    report.ID = (int)drCursos["id_curso"];
                    report.id_curso = (int)drCursos["id_curso"];
                    report.id_materia = (int)drCursos["id_materia"];
                    report.id_comision = (int)drCursos["id_comision"];
                    report.anio_calendario = (int)drCursos["anio_calendario"];
                    report.cupo = (int)drCursos["cupo"];

                    report.DescComision = (string)drCursos["desc_comision"];
                    report.DescMateria = (string)drCursos["desc_materia"];
                    report.DescPlan = (string)drCursos["desc_plan"];

                    report.AnioEspecialidad = (int)drCursos["anio_especialidad"];

                    report.DescEspecialidad = (string)drCursos["desc_especialidad"];
                    report.IdEspecialidad = (int)drCursos["id_especialidad"];*/