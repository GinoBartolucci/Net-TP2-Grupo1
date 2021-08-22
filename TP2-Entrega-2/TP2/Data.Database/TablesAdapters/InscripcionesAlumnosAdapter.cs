using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Entities.Tables;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database.TablesAdapters
{
    public class InscripcionesAlumnosAdapter : Adapter
    {
        public InscripcionesAlumnosAdapter()
        {
      //      SELECT TOP(1000) [id_inscripcion]
      //,[id_alumno]
      //,[id_curso]
      //,[condicion]
      //,[nota]
      //      FROM[tp2_net].[dbo].[alumnos_inscripciones]
        }
        public List<InscripcionesAlumnos> GetAll()
        {
            List<InscripcionesAlumnos> inscrip = new List<InscripcionesAlumnos>();
            try
            {
                OpenConnection();

                SqlCommand cmdInscrip = new SqlCommand("select * from alumnos_inscripciones", sqlConn);

                SqlDataReader drInscrip = cmdInscrip.ExecuteReader();

                while (drInscrip.Read())
                {
                    InscripcionesAlumnos inscrAl = new InscripcionesAlumnos();

                    inscrAl.ID = (int)drInscrip["id_inscripcion"];
                    inscrAl.IdAlumno = (int)drInscrip["id_alumno"];
                    inscrAl.IdCurso = (int)drInscrip["id_curso"];
                    inscrAl.Condicion = (string)drInscrip["condicion"];
                    inscrAl.Nota = (int)drInscrip["nota"];
   

                    inscrip.Add(inscrAl);
                }

                drInscrip.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de las inscripciones de alumnos.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return inscrip;

        }
        public InscripcionesAlumnos GetOne(int ID)
        {
            InscripcionesAlumnos inscripciones = new InscripcionesAlumnos();
            try
            {
                OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("SELECT * FROM alumnos_inscripciones WHERE id_inscripcion = @idInscripciones", sqlConn);
                cmdInscripciones.Parameters.Add("@idInscripciones", SqlDbType.Int).Value = ID;
                SqlDataReader drInscripciones = cmdInscripciones.ExecuteReader();

                while (drInscripciones.Read())
                {
                    inscripciones.ID = (int)drInscripciones["id_inscripcion"];
                    inscripciones.IdAlumno = (int)drInscripciones["id_alumno"];
                    inscripciones.IdCurso = (int)drInscripciones["id_curso"];
                    inscripciones.Nota = (int)drInscripciones["nota"];
                    inscripciones.Condicion = (string)drInscripciones["condicion"];

                }
                drInscripciones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la lista de inscripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            //if (drInscripciones.NombreInscripcionesAlumnos != null)
            //{
                return inscripciones;
            //}
            //else
            //{
            //    throw new Exception("El inscripcion no existe");
            //}
        }
        //Suponiendo que el nombre de inscripcion es unico
 
        public void Save(InscripcionesAlumnos inscripcion)
        {
            if (inscripcion.State == BusinessEntity.States.Deleted)
            {
                Delete(inscripcion.ID);
            }

            else if (inscripcion.State == BusinessEntity.States.New)
            {
                Insert(inscripcion);
            }
            else if (inscripcion.State == BusinessEntity.States.Modified)
            {
                Update(inscripcion);
            }
            inscripcion.State = BusinessEntity.States.Unmodified;
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones where id_inscripcion = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar lista de inscripcion", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        protected void Update(InscripcionesAlumnos inscripcion)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE alumnos_inscripciones SET id_alumno = @id_alumno, id_curso = @id_curso, " +
                    "condicion = @condicion, nota = @nota " +
                    " WHERE id_inscripcion = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = inscripcion.ID;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = inscripcion.IdCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar,50).Value = inscripcion.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = inscripcion.Nota;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = inscripcion.IdAlumno;
           
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del la inscripcion", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
        protected void Insert(InscripcionesAlumnos inscripcion)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO alumnos_inscripciones (id_curso,condicion,nota,id_alumno)" +
                    "values(@IdCurso,@condicion,@nota,@id_alumno)" +
                    "select @@identity ", sqlConn);

               
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = inscripcion.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = inscripcion.Nota;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = inscripcion.IdAlumno;
                cmdSave.Parameters.Add("@IdCurso", SqlDbType.Int).Value = inscripcion.IdCurso;

                inscripcion.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear inscripcion", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
