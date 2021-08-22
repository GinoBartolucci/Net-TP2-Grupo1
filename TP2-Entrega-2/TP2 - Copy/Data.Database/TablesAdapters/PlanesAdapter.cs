using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class PlanesAdapter : Adapter
    {
        public PlanesAdapter()
        {

        }
        public List<Planes> GetAll()
        {
            List<Planes> planes = new List<Planes>();
            try
            {
                OpenConnection();

                SqlCommand cmdPlanes = new SqlCommand("SELECT * FROM planes", sqlConn);

                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                while (drPlanes.Read())
                {
                    Planes pln = new Planes();

                    pln.ID = (int)drPlanes["id_plan"];
                    pln.desc_plan = (string)drPlanes["desc_plan"];
                    pln.id_especialidad = (int)drPlanes["id_especialidad"];
                   
                    planes.Add(pln);
                }

                drPlanes.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de planes.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return planes;
        }
        public Planes GetOne(int ID)
        {
            Planes pln = new Planes();
            try
            {
                OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("SELECT * FROM planes WHERE id_plan = @ID", sqlConn);
                cmdPlanes.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
                while (drPlanes.Read())
                {
                    pln.ID = (int)drPlanes["id_plan"];
                    pln.desc_plan = (string)drPlanes["desc_plan"];
                    pln.id_especialidad = (int)drPlanes["id_especialidad"];

                }
                drPlanes.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (pln.desc_plan != null)
            {
                return pln;
            }
            else
            {
                throw new Exception("El plan no existe");
            }
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete planes where id_plan = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar la plan", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Save(Planes plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                Delete(plan.ID);
            }

            else if (plan.State == BusinessEntity.States.New)
            {
                Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Planes plan)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE planes SET desc_plan = @descPlan, " +
                     " id_especialidad = @IdEsp " +
                    "WHERE id_plan = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@descPlan", SqlDbType.VarChar, 50).Value = plan.desc_plan;
                cmdSave.Parameters.Add("@IdEsp", SqlDbType.Int).Value = plan.id_especialidad;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del plan", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
        protected void Insert(Planes plan)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO planes (desc_plan,id_especialidad) " +
                    "VALUES(@descPlan,@idEspecialidad) " +
                    "select @@identity ", sqlConn);


                cmdSave.Parameters.Add("@descPlan", SqlDbType.VarChar, 50).Value = plan.desc_plan;
                cmdSave.Parameters.Add("@idEspecialidad", SqlDbType.Int).Value = plan.id_especialidad;
                plan.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Erro al crear el plan", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
 