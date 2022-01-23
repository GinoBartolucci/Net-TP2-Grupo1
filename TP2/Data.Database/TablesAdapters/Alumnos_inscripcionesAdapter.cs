using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database.TablesAdapters
{
    public class Alumnos_inscripcionesAdapter : Adapter
    {
        public Alumnos_inscripcionesAdapter()
        {
        }

        public List<Inscripciones> GetAll()
        {
            List<Inscripciones> inscrip = new List<Inscripciones>();
            try
            {
                OpenConnection();

                SqlCommand cmdInscrip = new SqlCommand("SELECT  * FROM alumnos_inscripciones ", sqlConn);

                SqlDataReader drInscrip = cmdInscrip.ExecuteReader();

                while (drInscrip.Read())
                {
                    Inscripciones inscrAl = new Inscripciones();

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

        public List<Inscripciones> GetEveryone()
        {
            List<Inscripciones> inscrip = new List<Inscripciones>();
            try
            {
                OpenConnection();

                SqlCommand cmdInscrip = new SqlCommand("select ai.id_inscripcion, ai.id_alumno, ai.id_curso, ai.condicion, isnull(ai.nota, -1) nota, m.desc_materia, com.desc_comision, concat(p.nombre, p.apellido) nombre, p.legajo  " +
                    "from alumnos_inscripciones ai " +
                    "inner join cursos c on c.id_curso = ai.id_curso " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join personas p on p.id_persona = ai.id_alumno " , sqlConn);

                SqlDataReader drInscrip = cmdInscrip.ExecuteReader();

                while (drInscrip.Read())
                {
                    Inscripciones inscrAl = new Inscripciones();

                    inscrAl.ID = (int)drInscrip["id_inscripcion"];
                    inscrAl.IdAlumno = (int)drInscrip["id_alumno"];
                    inscrAl.IdCurso = (int)drInscrip["id_curso"];
                    inscrAl.Condicion = (string)drInscrip["condicion"];
                    inscrAl.Nota = (int)drInscrip["nota"];

                    inscrAl.DescMateria = (string)drInscrip["desc_materia"];
                    inscrAl.DescComision = (string)drInscrip["desc_comision"];
                    inscrAl.NombreApellido = (string)drInscrip["nombre"];
                    inscrAl.Legajo = (int)drInscrip["legajo"];

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


        public List<Inscripciones> GetAllYear(int year)
        {
            List<Inscripciones> inscrip = new List<Inscripciones>();
            try
            {
                OpenConnection();

                SqlCommand cmdInscrip = new SqlCommand("select ai.id_inscripcion, ai.id_alumno, ai.id_curso, ai.condicion, isnull(ai.nota, -1) nota, m.desc_materia, com.desc_comision, concat(p.nombre, p.apellido) nombre, p.legajo  " +
                    "from alumnos_inscripciones ai " +
                    "inner join cursos c on c.id_curso = ai.id_curso " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join personas p on p.id_persona = ai.id_alumno " +
                    "where c.anio_calendario = @year ", sqlConn);
                cmdInscrip.Parameters.Add("@year", SqlDbType.Int).Value = year;
                SqlDataReader drInscrip = cmdInscrip.ExecuteReader();

                while (drInscrip.Read())
                {
                    Inscripciones inscrAl = new Inscripciones();

                    inscrAl.ID = (int)drInscrip["id_inscripcion"];
                    inscrAl.IdAlumno = (int)drInscrip["id_alumno"];
                    inscrAl.IdCurso = (int)drInscrip["id_curso"];
                    inscrAl.Condicion = (string)drInscrip["condicion"];
                    inscrAl.Nota = (int)drInscrip["nota"];

                    inscrAl.DescMateria = (string)drInscrip["desc_materia"];
                    inscrAl.DescComision = (string)drInscrip["desc_comision"];
                    inscrAl.NombreApellido = (string)drInscrip["nombre"];
                    inscrAl.Legajo = (int)drInscrip["legajo"];


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
        public List<Inscripciones> GetAllAlum(int idAlumno)
        {
            List<Inscripciones> inscrip = new List<Inscripciones>();
            try
            {
                OpenConnection();

                SqlCommand cmdInscrip = new SqlCommand("select ai.id_inscripcion, ai.id_alumno, ai.id_curso, ai.condicion, isnull(ai.nota, -1) nota, m.desc_materia, com.desc_comision, concat(p.nombre, p.apellido) nombre, p.legajo  " +
                    "from alumnos_inscripciones ai " +
                    "inner join cursos c on c.id_curso = ai.id_curso " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join personas p on p.id_persona = ai.id_alumno " +
                    "where ai.id_alumno = @id_alumno " , sqlConn);
                cmdInscrip.Parameters.Add("@id_alumno", SqlDbType.Int).Value = idAlumno;
                SqlDataReader drInscrip = cmdInscrip.ExecuteReader();

                while (drInscrip.Read())
                {
                    Inscripciones inscrAl = new Inscripciones();

                    inscrAl.ID = (int)drInscrip["id_inscripcion"];
                    inscrAl.IdAlumno = (int)drInscrip["id_alumno"];
                    inscrAl.IdCurso = (int)drInscrip["id_curso"];
                    inscrAl.Condicion = (string)drInscrip["condicion"];
                    inscrAl.Nota = (int)drInscrip["nota"];

                    inscrAl.DescMateria = (string)drInscrip["desc_materia"];
                    inscrAl.DescComision = (string)drInscrip["desc_comision"];
                    inscrAl.NombreApellido = (string)drInscrip["nombre"];
                    inscrAl.Legajo = (int)drInscrip["legajo"];

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

        public List<Inscripciones> GetAllYearAlum(int idAlumno, int year )
        {
            List<Inscripciones> inscrip = new List<Inscripciones>();
            try
            {
                OpenConnection();

                SqlCommand cmdInscrip = new SqlCommand("select ai.id_inscripcion, ai.id_alumno, ai.id_curso, ai.condicion, isnull(ai.nota, -1) nota, m.desc_materia, com.desc_comision, concat(p.nombre, p.apellido) nombre, p.legajo  " +
                    "from alumnos_inscripciones ai " +
                    "inner join cursos c on c.id_curso = ai.id_curso " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join personas p on p.id_persona = ai.id_alumno " +
                    "where ai.id_alumno=@id_alumno " +
                    "and c.anio_calendario = @year ", sqlConn);
                cmdInscrip.Parameters.Add("@id_alumno", SqlDbType.Int).Value = idAlumno;
                cmdInscrip.Parameters.Add("@year", SqlDbType.Int).Value = year;
                SqlDataReader drInscrip = cmdInscrip.ExecuteReader();

                while (drInscrip.Read())
                {
                    Inscripciones inscrAl = new Inscripciones();

                    inscrAl.ID = (int)drInscrip["id_inscripcion"];
                    inscrAl.IdAlumno = (int)drInscrip["id_alumno"];
                    inscrAl.IdCurso = (int)drInscrip["id_curso"];
                    inscrAl.Condicion = (string)drInscrip["condicion"];
                    inscrAl.Nota = (int)drInscrip["nota"];

                    inscrAl.DescMateria = (string)drInscrip["desc_materia"];
                    inscrAl.DescComision = (string)drInscrip["desc_comision"];
                    inscrAl.NombreApellido = (string)drInscrip["nombre"];
                    inscrAl.Legajo = (int)drInscrip["legajo"];

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

        public List<Inscripciones> GetAllCurso(int idCurso)
        {
            List<Inscripciones> inscrip = new List<Inscripciones>();
            try
            {
                OpenConnection();

                SqlCommand cmdInscrip = new SqlCommand("select ai.id_inscripcion, ai.id_alumno, ai.id_curso, ai.condicion, isnull(ai.nota, -1) nota, m.desc_materia, com.desc_comision, concat(p.nombre, p.apellido) nombre, p.legajo  " +
                    "from alumnos_inscripciones ai " +
                    "inner join cursos c on c.id_curso = ai.id_curso " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join personas p on p.id_persona = ai.id_alumno " +
                    "where c.id_curso = @id_curso ", sqlConn);
                cmdInscrip.Parameters.Add("@id_curso", SqlDbType.Int).Value = idCurso;
                SqlDataReader drInscrip = cmdInscrip.ExecuteReader();

                while (drInscrip.Read())
                {
                    Inscripciones inscrAl = new Inscripciones();

                    inscrAl.ID = (int)drInscrip["id_inscripcion"];
                    inscrAl.IdAlumno = (int)drInscrip["id_alumno"];
                    inscrAl.IdCurso = (int)drInscrip["id_curso"];
                    inscrAl.Condicion = (string)drInscrip["condicion"];
                    inscrAl.Nota = (int)drInscrip["nota"];

                    inscrAl.DescMateria = (string)drInscrip["desc_materia"];
                    inscrAl.DescComision = (string)drInscrip["desc_comision"];
                    inscrAl.NombreApellido = (string)drInscrip["nombre"];
                    inscrAl.Legajo = (int)drInscrip["legajo"];

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

        public Inscripciones GetOne(int ID)
        {
            Inscripciones inscripciones = new Inscripciones();
            try
            {
                OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("SELECT ai.id_inscripcion, ai.id_alumno, ai.id_curso, ai.condicion, isnull(ai.nota, -1) nota, m.desc_materia, com.desc_comision, concat(p.nombre, p.apellido) nombre, p.legajo " +
                    "FROM alumnos_inscripciones ai " +
                    "inner join cursos c on c.id_curso = ai.id_curso " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join personas p on p.id_persona = ai.id_alumno " +
                    "WHERE ai.id_inscripcion = @idInscripciones", sqlConn);
                cmdInscripciones.Parameters.Add("@idInscripciones", SqlDbType.Int).Value = ID;
                SqlDataReader drInscripciones = cmdInscripciones.ExecuteReader();

                while (drInscripciones.Read())
                {
                    inscripciones.ID = (int)drInscripciones["id_inscripcion"];
                    inscripciones.IdAlumno = (int)drInscripciones["id_alumno"];
                    inscripciones.IdCurso = (int)drInscripciones["id_curso"];
                    inscripciones.Nota = (int)drInscripciones["nota"];
                    inscripciones.Condicion = (string)drInscripciones["condicion"];

                    inscripciones.DescMateria = (string)drInscripciones["desc_materia"];
                    inscripciones.DescComision = (string)drInscripciones["desc_comision"];
                    inscripciones.NombreApellido = (string)drInscripciones["nombre"];
                    inscripciones.Legajo = (int)drInscripciones["legajo"];

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
 
        public void Save(Inscripciones inscripcion)
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
        protected void Update(Inscripciones inscripcion)
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
        protected void Insert(Inscripciones inscripcion)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO alumnos_inscripciones (id_alumno, id_curso, condicion)" +
                    "values(@id_alumno, @IdCurso,@condicion)" +
                    "select @@identity ", sqlConn);
                //El que crea la inscripcion es el alumno no hace falta nota
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = inscripcion.IdAlumno;
                cmdSave.Parameters.Add("@IdCurso", SqlDbType.Int).Value = inscripcion.IdCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = inscripcion.Condicion;
                //cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = inscripcion.Nota;                
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
