using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ModuloUsuarioAdapter : Adapter
    {
        public ModuloUsuarioAdapter()
        {

        }
        public List<ModuloUsuario> GetAll()
        {
            List<ModuloUsuario> modulousuarios = new List<ModuloUsuario>();
            try
            {
                OpenConnection();

                SqlCommand cmdModuloUsuarios = new SqlCommand("select * from modulo usuario", sqlConn);

                SqlDataReader drModuloUsuarios = cmdModuloUsuarios.ExecuteReader();

                while (drModuloUsuarios.Read())
                {
                    ModuloUsuario mdu = new ModuloUsuario();

                    mdu.IdModulo = (int)drModuloUsuarios["IdModulo"];
                    mdu.IdUsuario = (int)drModuloUsuarios["IdUsuario"];
                    mdu.PermiteAlta = (bool)drModuloUsuarios["PermiteAlta"];
                    mdu.PermiteBaja = (bool)drModuloUsuarios["PermiteBaja"];
                    mdu.PermiteConsulta = (bool)drModuloUsuarios["PermiteConsulta"];
                    mdu.PermiteModificacion= (bool)drModuloUsuarios["PermiteModificacion"];

                    modulousuarios.Add(mdu);
                }

                drModuloUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de modulo usuarios GetAll()", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return modulousuarios;

        }
        public Business.Entities.ModuloUsuario GetOne(int ID)
        {
            ModuloUsuario mdu = new ModuloUsuario();
            try
            {
                OpenConnection();
                SqlCommand cmdModuloUsuarios = new SqlCommand("SELECT * FROM modulo usuarios WHERE IdUsuario = @IdUsuario", sqlConn);
                cmdModuloUsuarios.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = ID;
                SqlDataReader drModuloUsuarios = cmdModuloUsuarios.ExecuteReader();
                while (drModuloUsuarios.Read())
                {
                    mdu.IdUsuario = (int)drModuloUsuarios["IdUsuario"];
                    mdu.IdModulo = (int)drModuloUsuarios["IdModulo"];
                    mdu.PermiteAlta = (bool)drModuloUsuarios["PermiteAlta"];
                    mdu.PermiteBaja = (bool)drModuloUsuarios["PermiteBaja"];
                    mdu.PermiteConsulta = (bool)drModuloUsuarios["PermiteConsulta"];
                    mdu.PermiteModificacion = (bool)drModuloUsuarios["PermiteModificacion"];
                }
                drModuloUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de modulo usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (mdu.IdUsuario != 0)
            {
                return mdu;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("El modulo usuario no existe", Ex);
            }
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete modulo usuarios where IdUsuario = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar modulo usuario", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Save(ModuloUsuario modulousuario)
        {
            if (modulousuario.State == BusinessEntity.States.Deleted)
            {
                Delete(modulousuario.ID);
            }

            else if (modulousuario.State == BusinessEntity.States.New)
            {
                Insert(modulousuario);
            }
            else if (modulousuario.State == BusinessEntity.States.Modified)
            {
                Update(modulousuario);
            }
            modulousuario.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(ModuloUsuario modulousuario)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE modulo usuarios SET IdUsuario = @IdUsuario, IdModulo = @IdModulo, " +
                    "PermiteAlta = @PermiteAlta, PermiteBaja = @PermiteBaja, PermiteConsulta = @PermiteConsulta, PermiteModificacion = @PermiteModificacion " +
                    "WHERE IdUsuario = @id ", sqlConn);

                cmdSave.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = modulousuario.IdUsuario;
                cmdSave.Parameters.Add("@IdModulo", SqlDbType.Int).Value = modulousuario.IdModulo;
                cmdSave.Parameters.Add("@PermiteAlta", SqlDbType.Bit).Value = modulousuario.PermiteAlta;
                cmdSave.Parameters.Add("@PermiteBaja", SqlDbType.Bit).Value = modulousuario.PermiteBaja;
                cmdSave.Parameters.Add("@PermiteConsulta", SqlDbType.Bit).Value = modulousuario.PermiteConsulta;
                cmdSave.Parameters.Add("@PermiteModificacion", SqlDbType.Bit).Value = modulousuario.PermiteModificacion;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del modulo usuario", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
        protected void Insert(ModuloUsuario modulousuario)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO modulo usuarios (IdModulo,IdUsuario,PermiteAlta,PermiteBaja,PermiteConsulta,PermiteModificacion)" +
                    "values(@IdModulo,@IdUsuario,@PermiteAlta,@PermiteBaja,@PermiteConsulta,@PermiteModificacion)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@IdModulo", SqlDbType.Int).Value = modulousuario.IdModulo;
                cmdSave.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = modulousuario.IdUsuario;
                cmdSave.Parameters.Add("@PermiteAlta", SqlDbType.Bit).Value = modulousuario.PermiteAlta;
                cmdSave.Parameters.Add("@PermiteBaja", SqlDbType.Bit).Value = modulousuario.PermiteBaja;
                cmdSave.Parameters.Add("@PermiteConsulta", SqlDbType.Bit).Value = modulousuario.PermiteConsulta;
                cmdSave.Parameters.Add("@PermiteModificacion", SqlDbType.Bit).Value = modulousuario.PermiteModificacion;

                modulousuario.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

                //cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Erro al crear modulo usuario", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}