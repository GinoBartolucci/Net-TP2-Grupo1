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
        public CursoAdapter()
        {

        }
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                OpenConnection();

                SqlCommand cmdCursos = new SqlCommand("select * from cursos", sqlConn);

                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso cur = new Curso();

                    cur.ID = (int)drCursos["id_curso"];
                    // cur.id_curso = (int)drCursos["id_curso"]; esta mal
                    cur.id_materia = (int)drCursos["id_materia"];
                    cur.id_comision = (int)drCursos["id_comision"];
                    cur.anio_calendario = (int)drCursos["anio_calendario"];
                    cur.cupo = (int)drCursos["cupo"];

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
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM cursos WHERE id_curso = @id_curso", sqlConn);
                cmdCursos.Parameters.Add("@id_curso", SqlDbType.Int).Value = id_curso;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    cur.ID = (int)drCursos["id_curso"];
                    cur.id_materia = (int)drCursos["id_materia"];
                    cur.id_comision = (int)drCursos["id_comision"];
                    cur.anio_calendario = (int)drCursos["anio_calendario"];
                    cur.cupo = (int)drCursos["cupo"];
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
            if (cur.id_curso != 0)
            {
                return cur;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("El curso no existe", Ex);
            }
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
                SqlCommand cmdSave = new SqlCommand("UPDATE cursos SET id_curso = @id_curso, id_materia = @id_materia, " +
                    "id_comision = @id_comision, anio_calendario = @anio_calendario, cupo = @cupo", sqlConn);

                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = curso.ID;
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
                SqlCommand cmdSave = new SqlCommand("INSERT INTO cursos (id_curso,id_materia,id_comision,anio_calendario,cupo)" +
                    "values(@id_curso,@id_materia,@id_comision,@anio_calendario,@cupo)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = curso.ID;
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
