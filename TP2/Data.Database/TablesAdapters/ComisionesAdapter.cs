using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database
{
    public class ComisionesAdapter:Adapter
    {
        private static ComisionesAdapter singleton;
        public static ComisionesAdapter GetInstance()
        {
            if (singleton == null)
            {
                singleton = new ComisionesAdapter();
            }
            return singleton;
        }
        public ComisionesAdapter()
        {

        }
        public List<Comisiones> GetAll()
        {
            List<Comisiones> comisiones = new List<Comisiones>();
            try
            {
                OpenConnection();

                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comisiones c " +
                    "inner join planes p on p.id_plan = c.id_plan " +
                    "inner join especialidades e on e.id_especialidad= p.id_especialidad ", sqlConn);

                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();

                while (drComisiones.Read())
                {
                    Comisiones com = new Comisiones();

                    com.ID = (int)drComisiones["id_comision"];
                    com.DescComision = (string)drComisiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    com.IdPlan = (int)drComisiones["id_plan"];

                    com.DescPlan = (string)drComisiones["desc_plan"];

                    com.DescEspecialidad = (string)drComisiones["desc_especialidad"];
                    com.IdEspecialidad = (int)drComisiones["id_especialidad"];
                    comisiones.Add(com);
                }

                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de comisiones.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return comisiones;
        }

        public List<Comisiones> GetAllByMateria(int idMateria)
        {
            List<Comisiones> comisiones = new List<Comisiones>();
            try
            {
                OpenConnection();

                SqlCommand cmdComisiones = new SqlCommand("SELECT c.*, p.*, e.* FROM comisiones c " +
                    "inner join planes p on p.id_plan = c.id_plan " +
                    "inner join especialidades e on e.id_especialidad= p.id_especialidad " +
                      " inner join materias m ON m.id_plan = p.id_plan " +
                    " WHERE m.id_materia  = @idMateria", sqlConn);

                cmdComisiones.Parameters.Add("@idMateria", SqlDbType.Int).Value = idMateria;

                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();

                while (drComisiones.Read())
                {
                    Comisiones com = new Comisiones();

                    com.ID = (int)drComisiones["id_comision"];
                    com.DescComision = (string)drComisiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    com.IdPlan = (int)drComisiones["id_plan"];

                    com.DescPlan = (string)drComisiones["desc_plan"];

                    com.DescEspecialidad = (string)drComisiones["desc_especialidad"];
                    com.IdEspecialidad = (int)drComisiones["id_especialidad"];
                    comisiones.Add(com);
                }

                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de comisiones.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return comisiones;
        }

        public Comisiones GetOne(int ID)
        {
            Comisiones com = new Comisiones();
            try
            {
                OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comisiones c " +
                    "inner join planes p on p.id_plan = c.id_plan " +
                    "inner join especialidades e on e.id_especialidad= p.id_especialidad " +
                    "WHERE id_comision = @ID", sqlConn);
                cmdComisiones.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();
                while (drComisiones.Read())
                {
                    com.ID = (int)drComisiones["id_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    com.DescComision = (string)drComisiones["desc_comision"];
                    com.IdPlan = (int)drComisiones["id_plan"];

                    com.DescPlan = (string)drComisiones["desc_plan"];

                    com.DescEspecialidad = (string)drComisiones["desc_especialidad"];
                    com.IdEspecialidad = (int)drComisiones["id_especialidad"];

                }
                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (com.DescComision != null)
            {
                return com;
            }
            else
            {
                throw new Exception("La comision no existe");
            }
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete comisiones where id_comision = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar la comision", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Save(Comisiones comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                Delete(comision.ID);
            }

            else if (comision.State == BusinessEntity.States.New)
            {
                Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Comisiones comision)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE comisiones SET desc_comision = @descCom, " +
                    "anio_especialidad= @AnioEsp, id_plan = @IdPlan " +
                    "WHERE id_comision = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = comision.ID;
                cmdSave.Parameters.Add("@descCom", SqlDbType.VarChar, 50).Value = comision.DescComision;
                cmdSave.Parameters.Add("@AnioEsp", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@IdPlan", SqlDbType.Int).Value = comision.IdPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del comision", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
        protected void Insert(Comisiones comision)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO comisiones (desc_comision,anio_especialidad,id_plan) " +
                    "values(@desCom,@AnioEsp,@IdPlan) " +
                    "select @@identity ", sqlConn);


                cmdSave.Parameters.Add("@desCom", SqlDbType.VarChar, 50).Value = comision.DescComision;
                cmdSave.Parameters.Add("@AnioEsp", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@IdPlan", SqlDbType.Int).Value = comision.IdPlan;

                comision.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear comision", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
    }


}
