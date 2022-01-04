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
    public class MateriasAdapter : Adapter
    {


        public List<Materias> GetAll()
        {
            List<Materias> materia = new List<Materias>();

            try
            {
                OpenConnection();

                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materias", sqlConn);
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                while (drMaterias.Read())
                {
                    Materias mat = new Materias();

                    mat.ID = (int)drMaterias["id_materia"];
                    mat.DescMateria = (string)drMaterias["desc_materia"];
                    mat.HorasSemanales = (int)drMaterias["hs_semanales"];
                    mat.HorasTotales = (int)drMaterias["hs_totales"];
                    mat.IdPlan = (int)drMaterias["id_plan"];

                    materia.Add(mat);

                }

                drMaterias.Close();


            }
            catch (Exception e)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de materias.", e);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return materia;
        }
        public Materias GetOne(int ID)
        {
            Materias mat = new Materias();
            try
            {
                OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materias WHERE id_materia = @ID", sqlConn);
                cmdMaterias.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                while (drMaterias.Read())
                {
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.DescMateria = (string)drMaterias["desc_materia"];
                    mat.HorasSemanales = (int)drMaterias["hs_semanales"];
                    mat.HorasTotales = (int)drMaterias["hs_totales"];
                    mat.IdPlan = (int)drMaterias["id_plan"];

                }
                drMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (mat.DescMateria != null)
            {
                return mat;
            }
            else
            {
                throw new Exception("La materia no existe");
            }
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete materias where id_materia = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar la materia", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Materias materia)
        {
            if (materia.State == BusinessEntity.States.Deleted)
            {
                Delete(materia.ID);
            }

            else if (materia.State == BusinessEntity.States.New)
            {
                Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Materias materia)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE materias SET desc_materia = @descMat, " +
                    "hs_semanales = @HSSem,hs_totales = @HSTot, id_plan = @IdPlan " +
                    "WHERE id_materia = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmdSave.Parameters.Add("@descMat", SqlDbType.VarChar, 50).Value = materia.DescMateria;
                cmdSave.Parameters.Add("@HSSem", SqlDbType.Int).Value = materia.HorasSemanales;
                cmdSave.Parameters.Add("@HSTot", SqlDbType.Int).Value = materia.HorasTotales;
                cmdSave.Parameters.Add("@IdPlan", SqlDbType.Int).Value = materia.IdPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la materia", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }

        protected void Insert(Materias materia)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO materias (desc_materia,hs_semanales,hs_totales,id_plan) " +
                    "values(@descMat,@HSSem,@HSTot,@IdPlan) " +
                    "select @@identity ", sqlConn);


                cmdSave.Parameters.Add("@descMat", SqlDbType.VarChar, 50).Value = materia.DescMateria;
                cmdSave.Parameters.Add("@HSSem", SqlDbType.Int).Value = materia.HorasSemanales;
                cmdSave.Parameters.Add("@HSTot", SqlDbType.Int).Value = materia.HorasTotales;
                cmdSave.Parameters.Add("@IdPlan", SqlDbType.Int).Value = materia.IdPlan;

                materia.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear nueva materia", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }




        }
    }
}
