using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class EspecialidadesAdapter : Adapter
    {
        public EspecialidadesAdapter()
        {

        }
        public List<Especialidades> GetAll()
        {
            List<Especialidades> especialidad = new List<Especialidades>();
            try
            {
                OpenConnection();

                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades", sqlConn);

                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();

                while (drEspecialidades.Read())
                {
                    Especialidades esp = new Especialidades();
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.desc_especialidad = (string)drEspecialidades["desc_especialidad"];
                    especialidad.Add(esp);
                }

                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de especialidades.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return especialidad;
        }
        public Business.Entities.Especialidades GetOne(int ID)
        {
            Especialidades esp = new Especialidades();
            try
            {
                OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades where id_especialidad = @id", sqlConn);
                cmdEspecialidades.Parameters.Add("@id",SqlDbType.Int).Value=ID;
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                while (drEspecialidades.Read())
                {
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.desc_especialidad = (string)drEspecialidades["desc_especialidad"];
                }
                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (esp.ID != 0)
            {
                return esp;
            }
            else
            {
                throw new Exception("La especialidad no existe");
            }
        }

        public void Save(Especialidades especialidades)
        {
            if (especialidades.State == BusinessEntity.States.Deleted)
            {
                Delete(especialidades.ID);
            }

            else if (especialidades.State == BusinessEntity.States.New)
            {
                Insert(especialidades);
            }
            else if (especialidades.State == BusinessEntity.States.Modified)
            {
                Update(especialidades);
            }
            especialidades.State = BusinessEntity.States.Unmodified;
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE especialidades WHERE id_especialidad = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar especialidad", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        protected void Update(Especialidades especialidades)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE especialidades SET desc_especialidad = @desc_especialidad" +
                    " WHERE id_especialidad = @id ", sqlConn);
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidades.desc_especialidad;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = especialidades.ID;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la especialidad", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
        protected void Insert(Especialidades especialidades)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO especialidades (desc_especialidad)" +
                    "values(@desc_especialidad)" +
                    "select @@identity ", sqlConn);
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidades.desc_especialidad;
                especialidades.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Erro al crear especialidad", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
