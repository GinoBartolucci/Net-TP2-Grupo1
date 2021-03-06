using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        private static CursoAdapter singleton;
        public static CursoAdapter GetInstance()
        {

            if (singleton == null)
            {
                singleton = new CursoAdapter();
            }

            return singleton;

        }
        public CursoAdapter()
        {

        }
        public List<Curso> GetAllYearPlan(int year, int idPlan)
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                OpenConnection();

                SqlCommand cmdCursos = new SqlCommand("select * from cursos c " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join planes p on p.id_plan = com.id_plan " +
                    "inner join especialidades e on e.id_especialidad = p.id_especialidad " +
                    "where c.anio_calendario = @year " +
                    "and m.id_plan = @id_plan", sqlConn);
                cmdCursos.Parameters.Add("@year", SqlDbType.Int).Value = year;
                cmdCursos.Parameters.Add("@id_plan", SqlDbType.Int).Value = idPlan;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso cur = new Curso();

                    cur.ID = (int)drCursos["id_curso"];
                    cur.id_curso = (int)drCursos["id_curso"];
                    cur.id_materia = (int)drCursos["id_materia"];
                    cur.id_comision = (int)drCursos["id_comision"];
                    cur.anio_calendario = (int)drCursos["anio_calendario"];
                    cur.cupo = (int)drCursos["cupo"];

                    cur.DescComision = (string)drCursos["desc_comision"];
                    cur.DescMateria = (string)drCursos["desc_materia"];
                    cur.DescPlan = (string)drCursos["desc_plan"];

                    cur.AnioEspecialidad = (int)drCursos["anio_especialidad"];

                    cur.DescEspecialidad = (string)drCursos["desc_especialidad"];
                    cur.IdEspecialidad = (int)drCursos["id_especialidad"];

                    cur.IdPlan = (int)drCursos["id_plan"];

                    cursos.Add(cur);
                }

                drCursos.Close();
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

            return cursos;

        }

        public List<Curso> GetAllYearAlum(int idAlumno, int year)
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                OpenConnection();

                SqlCommand cmdCursos = new SqlCommand("select * from cursos c " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join alumnos_inscripciones ai on c.id_curso = ai.id_curso " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join planes p on p.id_plan = com.id_plan " +
                    "inner join especialidades e on e.id_especialidad = p.id_especialidad " +
                    "where ai.id_alumno = @id_alumno " +
                    "and c.anio_calendario = @year ", sqlConn);
                cmdCursos.Parameters.Add("@id_alumno", SqlDbType.Int).Value = idAlumno;
                cmdCursos.Parameters.Add("@year", SqlDbType.Int).Value = year;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso cur = new Curso();

                    cur.ID = (int)drCursos["id_curso"];
                    cur.id_curso = (int)drCursos["id_curso"];
                    cur.id_materia = (int)drCursos["id_materia"];
                    cur.id_comision = (int)drCursos["id_comision"];
                    cur.anio_calendario = (int)drCursos["anio_calendario"];
                    cur.cupo = (int)drCursos["cupo"];

                    cur.DescComision = (string)drCursos["desc_comision"];
                    cur.DescMateria = (string)drCursos["desc_materia"];
                    cur.DescPlan = (string)drCursos["desc_plan"];

                    cur.AnioEspecialidad = (int)drCursos["anio_especialidad"];

                    cur.DescEspecialidad = (string)drCursos["desc_especialidad"];
                    cur.IdEspecialidad = (int)drCursos["id_especialidad"];

                    cur.IdPlan = (int)drCursos["id_plan"];

                    cursos.Add(cur);
                }

                drCursos.Close();
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

            return cursos;

        }

        public List<Curso> GetAllForAlum(int idAlumno)
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                OpenConnection();

                SqlCommand cmdCursos = new SqlCommand("select * from cursos c " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join personas per on per.id_plan = m.id_plan  " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join planes p on p.id_plan = com.id_plan  " +
                    "where per.id_persona = @id_alumno " +
                    "AND m.id_materia NOT IN" +
                    " ( " +
                    " SELECT curs.id_materia FROM alumnos_inscripciones  ai " +
                    " INNER JOIN cursos curs ON curs.id_curso = ai.id_curso	 " +
                    " WHERE  ai.id_alumno  = @id_alumno " +
                    " ) ", sqlConn);
                cmdCursos.Parameters.Add("@id_alumno", SqlDbType.Int).Value = idAlumno;

                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso cur = new Curso();

                    cur.ID = (int)drCursos["id_curso"];
                    cur.id_curso = (int)drCursos["id_curso"];
                    cur.id_materia = (int)drCursos["id_materia"];
                    cur.id_comision = (int)drCursos["id_comision"];
                    cur.anio_calendario = (int)drCursos["anio_calendario"];
                    cur.cupo = (int)drCursos["cupo"];
                    cur.DescComision = (string)drCursos["desc_comision"];
                    cur.DescMateria = (string)drCursos["desc_materia"];
                    cur.DescPlan = (string)drCursos["desc_plan"];

                    cur.AnioEspecialidad = (int)drCursos["anio_especialidad"];

                    cur.IdPlan = (int)drCursos["id_plan"];

                    cursos.Add(cur);
                }

                drCursos.Close();
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

            return cursos;

        }

        public List<Curso> GetAllDoc(int id_doc)
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                OpenConnection();

                SqlCommand cmdCursos = new SqlCommand("select * from cursos c " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join docentes_cursos dc on c.id_curso = dc.id_curso " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join planes p on p.id_plan = com.id_plan " +
                    "inner join especialidades e on e.id_especialidad = p.id_especialidad " +
                    "where dc.id_docente = @id_doc ", sqlConn);
                cmdCursos.Parameters.Add("@id_doc", SqlDbType.Int).Value = id_doc;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso cur = new Curso();

                    cur.ID = (int)drCursos["id_curso"];
                    cur.id_curso = (int)drCursos["id_curso"];
                    cur.id_materia = (int)drCursos["id_materia"];
                    cur.id_comision = (int)drCursos["id_comision"];
                    cur.anio_calendario = (int)drCursos["anio_calendario"];
                    cur.cupo = (int)drCursos["cupo"];

                    cur.DescComision = (string)drCursos["desc_comision"];
                    cur.DescMateria = (string)drCursos["desc_materia"];
                    cur.DescPlan = (string)drCursos["desc_plan"];

                    cur.AnioEspecialidad = (int)drCursos["anio_especialidad"];
                    cur.DescEspecialidad = (string)drCursos["desc_especialidad"];
                    cur.IdEspecialidad = (int)drCursos["id_especialidad"];


                    cursos.Add(cur);
                }

                drCursos.Close();
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

            return cursos;

        }

        public List<Curso> GetAllForDoc(int id_doc)
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                OpenConnection();
 
                SqlCommand cmdCursos = new SqlCommand(" SELECT * FROM personas p  " +
                    " INNER JOIN materias m ON m.id_plan = p.id_plan " +
                    " INNER JOIN cursos c ON c.id_materia = m.id_materia  " +
                    " INNER JOIN comisiones com ON  c.id_comision = com.id_comision " +
                    " INNER JOIN planes pl ON pl.id_plan = p.id_plan " +
                    " INNER JOIN especialidades e on e.id_especialidad = pl.id_especialidad " +
                    " WHERE p.id_persona = @id_doc " +
                    " AND  c.id_curso NOT IN   " +
                    " (SELECT dc.id_curso FROM docentes_cursos dc" +
                    " WHERE dc.id_docente = @id_doc )", sqlConn);
                cmdCursos.Parameters.Add("@id_doc", SqlDbType.Int).Value = id_doc;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso cur = new Curso();

                    cur.ID = (int)drCursos["id_curso"];
                    cur.id_curso = (int)drCursos["id_curso"];
                    cur.id_materia = (int)drCursos["id_materia"];
                    cur.id_comision = (int)drCursos["id_comision"];
                    cur.anio_calendario = (int)drCursos["anio_calendario"];
                    cur.cupo = (int)drCursos["cupo"];

                    cur.DescComision = (string)drCursos["desc_comision"];
                    cur.DescMateria = (string)drCursos["desc_materia"];
                    cur.DescPlan = (string)drCursos["desc_plan"];

                    cur.AnioEspecialidad = (int)drCursos["anio_especialidad"];
                    cur.DescEspecialidad = (string)drCursos["desc_especialidad"];
                    cur.IdEspecialidad = (int)drCursos["id_especialidad"];


                    cursos.Add(cur);
                }

                drCursos.Close();
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

            return cursos;

        }

        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                OpenConnection();

                SqlCommand cmdCursos = new SqlCommand("select * from cursos c " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join planes p on p.id_plan = com.id_plan " +
                    "inner join especialidades e on e.id_especialidad = p.id_especialidad ", sqlConn);

                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso cur = new Curso();

                    cur.ID = (int)drCursos["id_curso"];
                    cur.id_curso = (int)drCursos["id_curso"];
                    cur.id_materia = (int)drCursos["id_materia"];
                    cur.id_comision = (int)drCursos["id_comision"];
                    cur.anio_calendario = (int)drCursos["anio_calendario"];
                    cur.cupo = (int)drCursos["cupo"];

                    cur.DescComision = (string)drCursos["desc_comision"];
                    cur.DescMateria = (string)drCursos["desc_materia"];
                    cur.DescPlan = (string)drCursos["desc_plan"];

                    cur.AnioEspecialidad = (int)drCursos["anio_especialidad"];
                    cur.DescEspecialidad = (string)drCursos["desc_especialidad"];
                    cur.IdEspecialidad = (int)drCursos["id_especialidad"];

                    cur.IdPlan = (int)drCursos["id_plan"];


                    cursos.Add(cur);
                }

                drCursos.Close();
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

            return cursos;

        }

        public Business.Entities.Curso GetOne(int id_curso)
        {
            Curso cur = new Curso();
            try
            {

                OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM cursos c " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join planes p on p.id_plan = com.id_plan " +
                    "inner join especialidades e on e.id_especialidad = p.id_especialidad " +
                    " WHERE c.id_curso = @id_curso", sqlConn);
                cmdCursos.Parameters.Add("@id_curso", SqlDbType.Int).Value = id_curso;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    cur.id_curso = (int)drCursos["id_curso"];
                    cur.id_materia = (int)drCursos["id_materia"];
                    cur.id_comision = (int)drCursos["id_comision"];
                    cur.anio_calendario = (int)drCursos["anio_calendario"];
                    cur.cupo = (int)drCursos["cupo"];
                    cur.IdEspecialidad = (int)drCursos["id_especialidad"];

                    cur.DescComision = (string)drCursos["desc_comision"];
                    cur.DescMateria = (string)drCursos["desc_materia"];
                    cur.DescPlan = (string)drCursos["desc_plan"];

                    cur.AnioEspecialidad = (int)drCursos["anio_especialidad"];
                    cur.DescEspecialidad = (string)drCursos["desc_especialidad"];
                    cur.IdPlan = (int)drCursos["id_plan"];


                }
                drCursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return cur;

        }

        public void Delete(int id_curso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso = @id_curso", sqlConn);
                cmdDelete.Parameters.Add("@id_curso", SqlDbType.Int).Value = id_curso;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar curso", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.Deleted)
            {
                Delete(curso.id_curso);
            }

            else if (curso.State == BusinessEntity.States.New)
            {
                Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Curso curso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE cursos SET id_materia = @id_materia, " +
                    "id_comision = @id_comision, anio_calendario = @anio_calendario, cupo = @cupo " +
                    "where id_curso=@id_curso", sqlConn);

                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = curso.id_curso;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.id_materia;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.id_comision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.anio_calendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.cupo;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del curso", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
        protected void Insert(Curso curso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO cursos (id_materia,id_comision,anio_calendario,cupo) " +
                    "values(@id_materia,@id_comision,@anio_calendario,@cupo) " +
                    "select @@identity ", sqlConn);

                //  cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = curso.id_curso;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.id_materia;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.id_comision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.anio_calendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.cupo;

                curso.id_curso = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

                //cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Erro al crear curso", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
