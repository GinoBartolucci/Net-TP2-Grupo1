using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public UsuarioAdapter()
        {

        }
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                OpenConnection();

                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios" +
                    "inner join personas per on usr.id_persona = per.id_persona " +
                    "inner join planes pl on pl.id_plan = per.id_plan" +
                    "inner join  especialidades es on es.id_especialidad = pl.id_especialidad", sqlConn);

                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                while (drUsuarios.Read())
                {
                    Usuario usr = new Usuario();

                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];

                    usr.IdPersona = (int)drUsuarios["id_persona"];
                    usr.Legajo = (int)drUsuarios["legajo"];
                    usr.Direccion = (string)drUsuarios["direccion"];
                    usr.Telefono = (string)drUsuarios["telefono"];
                    usr.FechaNac = (DateTime)drUsuarios["fecha_nac"];
                    usr.TipoPersona = (int)drUsuarios["tipo_persona"];

                    usr.IdPlan = (int)drUsuarios["id_plan"];
                    usr.DescPlan = (string)drUsuarios["desc_plan"];
                    usr.IdEspecialidad = (int)drUsuarios["id_especialidad"];

                    usr.DescEspecialidad = (string)drUsuarios["desc_especialidad"];

                    switch (usr.TipoPersona)
                    {
                        case 1:
                            usr.DescTipoPersona = "Administrativo";
                            break;
                        case 2:
                            usr.DescTipoPersona = "Docente";
                            break;
                        case 3:
                            usr.DescTipoPersona = "Alumnno";
                            break;
                        default:
                            break;
                    }

                    usuarios.Add(usr);
                }

                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return usuarios;

        }
        public Business.Entities.Usuario GetOneId(int ID)
        {
            Usuario usr = new Usuario();
            try
            {
                OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios" +
                    "inner join personas per on usr.id_persona = per.id_persona " +
                    "inner join planes pl on pl.id_plan = per.id_plan" +
                    "inner join  especialidades es on es.id_especialidad = pl.id_especialidad" +
                    "where  id_usuario = @id_usuario", sqlConn);
                cmdUsuarios.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Email = (string)drUsuarios["email"];

                    usr.IdPersona = (int)drUsuarios["id_persona"];
                    usr.Legajo = (int)drUsuarios["legajo"];
                    usr.Direccion = (string)drUsuarios["direccion"];
                    usr.Telefono = (string)drUsuarios["telefono"];
                    usr.FechaNac = (DateTime)drUsuarios["fecha_nac"];
                    usr.TipoPersona = (int)drUsuarios["tipo_persona"];

                    usr.IdPlan = (int)drUsuarios["id_plan"];
                    usr.DescPlan = (string)drUsuarios["desc_plan"];
                    usr.IdEspecialidad = (int)drUsuarios["id_especialidad"];

                    usr.DescEspecialidad = (string)drUsuarios["desc_especialidad"];

                    switch (usr.TipoPersona)
                    {
                        case 1:
                            usr.DescTipoPersona = "Administrativo";
                            break;
                        case 2:
                            usr.DescTipoPersona = "Docente";
                            break;
                        case 3:
                            usr.DescTipoPersona = "Alumnno";
                            break;
                        default:
                            break;
                    }
                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (usr.NombreUsuario != null)
            {
                return usr;
            }
            else
            {
                throw new Exception("El usuario no existe");
            }
        }
        public Business.Entities.Usuario LoginUsuario(string nombreUsuario, string clave)
        {
            Usuario usr = new Usuario();
            try
            {
                OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios usr " +
                    "inner join personas per on usr.id_persona = per.id_persona " +
                    "inner join planes pl on pl.id_plan = per.id_plan " +
                    "inner join especialidades es on es.id_especialidad = pl.id_especialidad " +
                    "WHERE nombre_usuario = @nombre_usuario and clave = @clave", sqlConn);
                cmdUsuarios.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = nombreUsuario;
                cmdUsuarios.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                while (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    //usr.Email = (string)drUsuarios["email"];

                    usr.TipoPersona = (int)drUsuarios["tipo_persona"];
                    usr.IdPersona = (int)drUsuarios["id_persona"];
                    if(usr.TipoPersona == 1)
                    {
                        usr.Legajo = (int)drUsuarios["legajo"];
                    }                    
                    //usr.Direccion = (string)drUsuarios["direccion"];
                    //usr.Telefono = (string)drUsuarios["telefono"];
                    usr.FechaNac = (DateTime)drUsuarios["fecha_nac"];
                    

                    usr.IdPlan = (int)drUsuarios["id_plan"];
                    usr.DescPlan = (string)drUsuarios["desc_plan"];
                    usr.IdEspecialidad = (int)drUsuarios["id_especialidad"];

                    usr.DescEspecialidad = (string)drUsuarios["desc_especialidad"];

                    switch (usr.TipoPersona)
                    {
                        case 1:
                            usr.DescTipoPersona = "Administrativo";
                            break;
                        case 2:
                            usr.DescTipoPersona = "Docente";
                            break;
                        case 3:
                            usr.DescTipoPersona = "Alumnno";
                            break;
                        default:
                            break;
                    }
                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
                throw ExcepcionManejada;
                
            }
            finally
            {
                CloseConnection();
            }
            if (usr.NombreUsuario != null)
            {
                return usr;
            }
            else return null;
                        
        }
        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.Deleted)
            {
                Delete(usuario.ID);
            }

            else if (usuario.State == BusinessEntity.States.New) 
            {
                Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                Update(usuario); 
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete usuarios where id_usuario = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar usuario", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        protected void Update(Usuario usuario)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE usuarios SET nombre_usuario = @nombre_usuario, clave = @clave, " +
                    "habilitado = @habilitado, nombre = @nombre, apellido = @apellido, email = @email " +
                    "WHERE id_usuario = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del usuario", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
        protected void Insert(Usuario usuario)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO usuarios (nombre_usuario,clave,habilitado,nombre,apellido,email)" +
                    "values(@nombre_usuario,@clave,@habilitado,@nombre,@apellido,@email)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;

                usuario.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Erro al crear usuario", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
