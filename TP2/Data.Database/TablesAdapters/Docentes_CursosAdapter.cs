using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Docentes_cursosAdapter : Adapter
    {
        public Docentes_cursosAdapter()
        {

        }
        private static Docentes_cursosAdapter singleton;
        public static Docentes_cursosAdapter GetInstance()
        {

            if (singleton == null)
            {
                singleton = new Docentes_cursosAdapter();
            }

            return singleton;

        }

        public List<Docentes_cursos> GetAll()
        {
            List<Docentes_cursos> docentes_cursos = new List<Docentes_cursos>();
            try
            {
                OpenConnection();

                SqlCommand cmdDocentes_Cursos = new SqlCommand("select * from docentes_cursos dc " +
                    "inner join cursos c on c.id_curso = dc.id_curso " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join personas p on p.id_persona = dc.id_docente ", sqlConn);

                SqlDataReader drDocentes_Cursos = cmdDocentes_Cursos.ExecuteReader();

                while (drDocentes_Cursos.Read())
                {
                    Docentes_cursos dc = new Docentes_cursos();

                    dc.id_dictado = (int)drDocentes_Cursos["id_dictado"];
                    dc.id_curso = (int)drDocentes_Cursos["id_curso"];
                    dc.id_docente = (int)drDocentes_Cursos["id_docente"];

                    dc.cargo = (int)drDocentes_Cursos["cargo"];
                    switch (dc.cargo)
                    {
                        case 0:
                            dc.DescCargo = "Jefe";
                            break;
                        case 1:
                            dc.DescCargo = "Docente";
                            break;
                        case 2:
                            dc.DescCargo = "Ayudante";
                            break;
                    }

                    dc.DescMateria = (string)drDocentes_Cursos["desc_materia"];
                    dc.DescComision = (string)drDocentes_Cursos["desc_comision"];
                    dc.Nombre = (string)drDocentes_Cursos["nombre"];
                    dc.Apellido = (string)drDocentes_Cursos["apellido"];

                    docentes_cursos.Add(dc);
                }

                drDocentes_Cursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Docentes_cursos.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return docentes_cursos;

        }

        public List<Docentes_cursos> GetAllYearDoc(int idDoc, int year)
        {
            List<Docentes_cursos> docentes_cursos = new List<Docentes_cursos>();
            try
            {
                OpenConnection();

                SqlCommand cmdDocentes_Cursos = new SqlCommand("select * from docentes_cursos dc " +
                    "inner join cursos c on c.id_curso = dc.id_curso " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join personas p on p.id_persona = dc.id_docente " +
                    "where dc.id_docente=@id_docente " +
                    "and c.anio_calendario = @year ", sqlConn);
                cmdDocentes_Cursos.Parameters.Add("@id_docente", SqlDbType.Int).Value = idDoc;
                cmdDocentes_Cursos.Parameters.Add("@year", SqlDbType.Int).Value = year;
                SqlDataReader drDocentes_Cursos = cmdDocentes_Cursos.ExecuteReader();

                while (drDocentes_Cursos.Read())
                {
                    Docentes_cursos dc = new Docentes_cursos();

                    dc.id_dictado = (int)drDocentes_Cursos["id_dictado"];
                    dc.id_curso = (int)drDocentes_Cursos["id_curso"];
                    dc.id_docente = (int)drDocentes_Cursos["id_docente"];
                    dc.cargo = (int)drDocentes_Cursos["cargo"];

                    switch (dc.cargo)
                    {
                        case 0:
                            dc.DescCargo = "Jefe";
                            break;
                        case 1:
                            dc.DescCargo = "Docente";
                            break;
                        case 2:
                            dc.DescCargo = "Ayudante";
                            break;
                    }

                    dc.DescMateria = (string)drDocentes_Cursos["desc_materia"];
                    dc.DescComision = (string)drDocentes_Cursos["desc_comision"];
                    dc.Nombre = (string)drDocentes_Cursos["nombre"];
                    dc.Apellido = (string)drDocentes_Cursos["apellido"];

                    docentes_cursos.Add(dc);
                }

                drDocentes_Cursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Docentes_cursos.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return docentes_cursos;

        }

        public Business.Entities.Docentes_cursos GetOne(int id_dictado)
        {
            Docentes_cursos dc = new Docentes_cursos();
            try
            {
                OpenConnection();
                SqlCommand cmdDocentes_Cursos = new SqlCommand("select * from docentes_cursos dc " +
                    "inner join cursos c on c.id_curso = dc.id_curso " +
                    "inner join materias m on m.id_materia = c.id_materia " +
                    "inner join comisiones com on com.id_comision = c.id_comision " +
                    "inner join personas p on p.id_persona = dc.id_docente " +
                    "WHERE dc.id_dictado = @id_dictado", sqlConn);
                cmdDocentes_Cursos.Parameters.Add("@id_dictado", SqlDbType.Int).Value = id_dictado;
                SqlDataReader drDocentes_Cursos = cmdDocentes_Cursos.ExecuteReader();
                while (drDocentes_Cursos.Read())
                {
                    dc.id_dictado = (int)drDocentes_Cursos["id_dictado"];
                    dc.id_curso = (int)drDocentes_Cursos["id_curso"];
                    dc.id_docente = (int)drDocentes_Cursos["id_docente"];
                    dc.cargo = (int)drDocentes_Cursos["cargo"];

                    switch (dc.cargo)
                    {
                        case 0:
                            dc.DescCargo = "Jefe";
                            break;
                        case 1:
                            dc.DescCargo = "Docente";
                            break;
                        case 2:
                            dc.DescCargo = "Ayudante";
                            break;
                    }
                    dc.IdPlan = (int)drDocentes_Cursos["id_plan"];

                    dc.DescMateria = (string)drDocentes_Cursos["desc_materia"];
                    dc.DescComision = (string)drDocentes_Cursos["desc_comision"];
                    dc.Nombre = (string)drDocentes_Cursos["nombre"];
                    dc.Apellido = (string)drDocentes_Cursos["apellido"];

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
        
        public void Save(Docentes_cursos docentes_cursos)
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
        protected void Update(Docentes_cursos docentes_cursos)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE docentes_cursos SET id_docente = @id_docente, cargo = @cargo, " +
                    "id_curso = @id_curso " +
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
        protected void Insert(Docentes_cursos docentes_cursos)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO docentes_cursos (id_docente,id_curso,cargo) " +
                    "values(@id_docente,@id_curso,@cargo) " +
                    "select @@identity ", sqlConn);

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
