using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ModulosAdapter : Adapter
    {
        public ModulosAdapter()
        {

        }
        public List<Modulo> GetAll()
        {
            List<Modulo> modulos = new List<Modulo>();
            try
            {
                OpenConnection();

                SqlCommand cmdModulo = new SqlCommand("select * from modulos", sqlConn);

                SqlDataReader drModulo = cmdModulo.ExecuteReader();

                while (drModulo.Read())
                {
                    Modulo mdl = new Modulo();

                    mdl.ID = (int)drModulo["id_modulo"];
                    mdl.Descripcion = (string)drModulo["Descripcion"];
                    mdl.Ejecuta = (string)drModulo["Ejecuta"];

                    modulos.Add(mdl);
                }

                drModulo.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de modulos.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return modulos;
        }
        public Business.Entities.Modulo GetOneId(int id_modulo)
        {
            Modulo mdl = new Modulo();
            try
            {
                OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("SELECT * FROM modulos WHERE id_modulo = @id_modulo", sqlConn);
                cmdModulo.Parameters.Add("@id_modulo", SqlDbType.Int).Value = id_modulo;
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                while (drModulo.Read())
                {
                    mdl.ID = (int)drModulo["id_modulo"];
                    mdl.Descripcion = (string)drModulo["Descripcion"];
                    mdl.Ejecuta = (string)drModulo["Ejecuta"];
                }
                drModulo.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del modulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (mdl.Descripcion != null)
            {
                return mdl;
            }
            else
            {
                throw new Exception("El modulo no existe");
            }
        }
        public Business.Entities.Modulo GetOneModulo(string Descripcion)
        {
            Modulo mdl = new Modulo();
            try
            {
                OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("SELECT * FROM modulos WHERE Descripcion = @Descripcion", sqlConn);
                cmdModulo.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion;
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                while (drModulo.Read())
                {
                    mdl.ID = (int)drModulo["id_modulo"];
                    mdl.Descripcion = (string)drModulo["Descripcion"];
                    mdl.Ejecuta = (string)drModulo["Ejecuta"];

                    drModulo.Close();
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de los modulos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (mdl.Descripcion != null)
            {
                return mdl;
            }
            else
            {
                throw new Exception("El modulo no existe");
            }
        }
        public void Save(Modulo modulos)
        {
            if (modulos.State == BusinessEntity.States.Deleted)
            {
                Delete(modulos.ID);
            }

            else if (modulos.State == BusinessEntity.States.New)
            {
                Insert(modulos);
            }
            else if (modulos.State == BusinessEntity.States.Modified)
            {
                Update(modulos);
            }
            modulos.State = BusinessEntity.States.Unmodified;
        }
        public void Delete(int id_modulo)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete modulos where id_modulo = @id_modulo", sqlConn);
                cmdDelete.Parameters.Add("@id_modulo", SqlDbType.Int).Value = id_modulo;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar modulo", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        protected void Update(Modulo modulos)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE modulos SET Descripcion = @Descripcion, Ejecuta = @Ejecuta " +
                    "WHERE id_modulo = @id_modulo ", sqlConn);

                cmdSave.Parameters.Add("@id_modulo", SqlDbType.Int).Value = modulos.ID;
                cmdSave.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = modulos.Descripcion;
                cmdSave.Parameters.Add("@Ejecuta", SqlDbType.VarChar, 50).Value = modulos.Ejecuta;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del modulo", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
        protected void Insert(Modulo modulos)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO modulos (Descripcion,Ejecuta)" +
                    "values(@Descripcion,@Ejecuta)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = modulos.Descripcion;
                cmdSave.Parameters.Add("@Ejecuta", SqlDbType.VarChar, 50).Value = modulos.Ejecuta;
                

                modulos.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

                //cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Erro al crear modulo", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
