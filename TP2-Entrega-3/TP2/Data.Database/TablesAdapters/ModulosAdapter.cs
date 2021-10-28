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
        public List<Modulos> GetAll()
        {
            List<Modulos> modulos = new List<Modulos>();
            try
            {
                OpenConnection();

                SqlCommand cmdModulos = new SqlCommand("select * from modulos", sqlConn);

                SqlDataReader drModulos = cmdModulos.ExecuteReader();

                while (drModulos.Read())
                {
                    Modulos mdl = new Modulos();

                    mdl.ID = (int)drModulos["id_modulo"];
                    mdl.desc_modulo = (string)drModulos["desc_modulo"];
                    mdl.ejecuta = (string)drModulos["ejecuta"];

                    modulos.Add(mdl);
                }

                drModulos.Close();
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
        public Business.Entities.Modulos GetOneId(int id_modulo)
        {
            Modulos mdl = new Modulos();
            try
            {
                OpenConnection();
                SqlCommand cmdModulos = new SqlCommand("SELECT * FROM modulos WHERE id_modulo = @id_modulo", sqlConn);
                cmdModulos.Parameters.Add("@id_modulo", SqlDbType.Int).Value = id_modulo;
                SqlDataReader drModulos = cmdModulos.ExecuteReader();
                while (drModulos.Read())
                {
                    mdl.ID = (int)drModulos["id_modulo"];
                    mdl.desc_modulo = (string)drModulos["desc_modulo"];
                    mdl.ejecuta = (string)drModulos["ejecuta"];
                }
                drModulos.Close();
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
            if (mdl.desc_modulo != null)
            {
                return mdl;
            }
            else
            {
                throw new Exception("El modulo no existe");
            }
        }
        public Business.Entities.Modulos GetOneModulos(string desc_modulo)
        {
            Modulos mdl = new Modulos();
            try
            {
                OpenConnection();
                SqlCommand cmdModulos = new SqlCommand("SELECT * FROM modulos WHERE desc_modulo = @desc_modulo", sqlConn);
                cmdModulos.Parameters.Add("@desc_modulo", SqlDbType.VarChar).Value = desc_modulo;
                SqlDataReader drModulos = cmdModulos.ExecuteReader();
                while (drModulos.Read())
                {
                    mdl.ID = (int)drModulos["id_modulo"];
                    mdl.desc_modulo = (string)drModulos["desc_modulo"];
                    mdl.ejecuta = (string)drModulos["ejecuta"];

                    drModulos.Close();
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
            if (mdl.desc_modulo != null)
            {
                return mdl;
            }
            else
            {
                throw new Exception("El modulo no existe");
            }
        }
        public void Save(Modulos modulos)
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
        protected void Update(Modulos modulos)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE modulos SET desc_modulo = @desc_modulo, ejecuta = @ejecuta " +
                    "WHERE id_modulo = @id_modulo ", sqlConn);

                cmdSave.Parameters.Add("@id_modulo", SqlDbType.Int).Value = modulos.ID;
                cmdSave.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulos.desc_modulo;
                cmdSave.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = modulos.ejecuta;
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
        protected void Insert(Modulos modulos)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO modulos (desc_modulo,ejecuta)" +
                    "values(@desc_modulo,@ejecuta)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulos.desc_modulo;
                cmdSave.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = modulos.ejecuta;
                

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
