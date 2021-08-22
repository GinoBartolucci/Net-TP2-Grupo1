using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Docentes_CursosAdapter : Adapter
    {
        public Docentes_CursosAdapter()
        {

        }
        public List<Docentes_Cursos> GetAll()
        {
            List<Docentes_Cursos> docentes_cursos = new List<Docentes_Cursos>();
            try
            {
                OpenConnection();

                SqlCommand cmdDocentes_Cursos = new SqlCommand("select * from docentes_cursos", sqlConn);

                SqlDataReader drDocentes_Cursos = cmdDocentes_Cursos.ExecuteReader();

                while (drDocentes_Cursos.Read())
                {
                    Docentes_Cursos dc = new Docentes_Cursos();

                    dc.id_dictado = (int)drDocentes_Cursos["id_dictado"];
                    dc.id_curso = (int)drDocentes_Cursos["id_curso"];
                    dc.id_docente = (int)drDocentes_Cursos["id_docente"];
                    dc.cargo = (int)drDocentes_Cursos["cargo"];

                    docentes_cursos.Add(dc);
                }

                drDocentes_Cursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Docentes_Cursos.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return docentes_cursos;

        }
        public Business.Entities.Docentes_Cursos GetOneId(int id_dictado)
        {
            Docentes_Cursos dc = new Docentes_Cursos();
            try
            {
                OpenConnection();
                SqlCommand cmdDocentes_Cursos = new SqlCommand("SELECT * FROM docentes_cursos WHERE id_dictado = @id_dictado", sqlConn);
                cmdDocentes_Cursos.Parameters.Add("@id_dictado", SqlDbType.Int).Value = id_dictado;
                SqlDataReader drDocentes_Cursos = cmdDocentes_Cursos.ExecuteReader();
                while (drDocentes_Cursos.Read())
                {
                    dc.id_dictado = (int)drDocentes_Cursos["id_dictado"];
                    dc.id_curso = (int)drDocentes_Cursos["id_curso"];
                    dc.id_docente = (int)drDocentes_Cursos["id_docente"];
                    dc.cargo = (int)drDocentes_Cursos["cargo"];
                }
                drDocentes_Cursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de docentes_cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (dc.id_dictado != 0)
            {
                return dc;
            }
            else
            {
                throw new Exception("El curso no existe para ese docente");
            }
        }
  
        public Business.Entities.Docentes_Cursos GetOneDictado(int id_dictado)
        {
            Docentes_Cursos dc = new Docentes_Cursos();
            try
            {
                OpenConnection();
                SqlCommand cmdDocentes_Cursos = new SqlCommand("SELECT * FROM docentes_cursos WHERE id_dictado = @id_dictado", sqlConn);
                cmdDocentes_Cursos.Parameters.Add("@id_dictado", SqlDbType.Int).Value = id_dictado;
                SqlDataReader drDocentes_Cursos = cmdDocentes_Cursos.ExecuteReader();
                while (drDocentes_Cursos.Read())
                {
                    dc.id_dictado = (int)drDocentes_Cursos["id_dictado"];
                    dc.id_curso = (int)drDocentes_Cursos["id_curso"];
                    dc.id_docente = (int)drDocentes_Cursos["id_docente"];
                    dc.cargo = (int)drDocentes_Cursos["cargo"];
                }
                drDocentes_Cursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de Docentes_Cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (dc.id_dictado != 0)
            {
                return dc;
            }
            else
            {
                throw new Exception("El curso no existe para ese docente");
            }
        }
        public void Save(Docentes_Cursos docentes_cursos)
        {
            if (docentes_cursos.State == BusinessEntity.States.Deleted)
            {
                Delete(docentes_cursos.id_dictado);
            }

            else if (docentes_cursos.State == BusinessEntity.States.New) 
            {
                Insert(docentes_cursos);
            }
            else if (docentes_cursos.State == BusinessEntity.States.Modified)
            {
                Update(docentes_cursos); 
            }
            docentes_cursos.State = BusinessEntity.States.Unmodified;
        }
        public void Delete(int id_dictado)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete docentes_cursos where id_dictado = @id_dictado", sqlConn);
                cmdDelete.Parameters.Add("@id_dictado", SqlDbType.Int).Value = id_dictado;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar docentes_cursos", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        protected void Update(Docentes_Cursos docentes_cursos)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE docentes_cursos SET id_docente = @id_docente, cargo = @cargo, " +
                    "id_curso = @id_curso" +
                    "WHERE id_dictado = @id_dictado ", sqlConn);

                cmdSave.Parameters.Add("@id_dictado", SqlDbType.Int).Value = docentes_cursos.id_dictado;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = docentes_cursos.id_curso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = docentes_cursos.id_docente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = docentes_cursos.cargo;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del docentes_cursos", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
        protected void Insert(Docentes_Cursos docentes_cursos)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO  (id_dictado,id_docente,id_curso,cargo)" +
                    "values(@id_dictado,@id_docente,@id_curso,@cargo)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@id_dictado", SqlDbType.Int).Value = docentes_cursos.id_dictado;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = docentes_cursos.id_curso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = docentes_cursos.id_docente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = docentes_cursos.cargo;

                docentes_cursos.id_dictado= Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Erro al crear docente_cursos", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
