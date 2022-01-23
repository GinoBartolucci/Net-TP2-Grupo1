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
        private static UsuarioAdapter singleton;
        public static UsuarioAdapter GetInstance()
        {
            if (singleton == null)
            {
                singleton = new UsuarioAdapter();
            }
            return singleton;
        }
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                OpenConnection();

                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios usr " +
                    "inner join personas per on usr.id_persona = per.id_persona " +
                    "inner join planes pl on pl.id_plan = per.id_plan " +
                    "inner join especialidades es on es.id_especialidad = pl.id_especialidad ", sqlConn);

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
                    usr.TipoPersona = (int)drUsuarios["tipo_persona"];

                    usr.IdPersona = (int)drUsuarios["id_persona"];
                    if (usr.TipoPersona == 3)
                    {
                        usr.Legajo = (int)drUsuarios["legajo"];
                    }
                    usr.Direccion = (string)drUsuarios["direccion"];
                    usr.Telefono = (string)drUsuarios["telefono"];
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
                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios usr " +
                    " inner join personas per on usr.id_persona = per.id_persona " +
                    " inner join planes pl on pl.id_plan = per.id_plan" +
                    " inner join  especialidades es on es.id_especialidad = pl.id_especialidad" +
                    " where  usr.id_usuario = @id_usuario", sqlConn);
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
                    usr.TipoPersona = (int)drUsuarios["tipo_persona"];

                    usr.IdPersona = (int)drUsuarios["id_persona"];
                    if (usr.TipoPersona == 3)
                    {
                        usr.Legajo = (int)drUsuarios["legajo"];
                    }
                    else {
                        usr.Legajo = 0;
                    }
                    usr.Direccion = (string)drUsuarios["direccion"];
                    usr.Telefono = (string)drUsuarios["telefono"];
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
                    usr.Email = (string)drUsuarios["email"];

                    usr.TipoPersona = (int)drUsuarios["tipo_persona"];
                    usr.IdPersona = (int)drUsuarios["id_persona"];
                    if(usr.TipoPersona == 3)
                    {
                        usr.Legajo = (int)drUsuarios["legajo"];
                    }                    
                    usr.Direccion = (string)drUsuarios["direccion"];
                    usr.Telefono = (string)drUsuarios["telefono"];
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
                Update(usuario);
                //Delete(usuario.ID);
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
                SqlCommand cmdSaveUsuario = new SqlCommand("UPDATE usuarios SET " +
                    "nombre_usuario = @nombre_usuario, " +
                    "clave = @clave, " +
                    "habilitado = @habilitado, " +
                    "nombre = @nombre, " +
                    "apellido = @apellido, " +
                    "email = @email " +
                    "WHERE id_persona = @idPersona ", sqlConn);

                cmdSaveUsuario.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdSaveUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSaveUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSaveUsuario.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSaveUsuario.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSaveUsuario.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSaveUsuario.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;

                cmdSaveUsuario.Parameters.Add("@idPersona", SqlDbType.Int).Value = usuario.IdPersona;

                cmdSaveUsuario.ExecuteNonQuery();

                SqlCommand cmdSavePersona = new SqlCommand("UPDATE personas SET " +
                    "nombre = @nombre, " +
                    "apellido = @apellido, " +
                    "direccion = @direccion, " +
                    "email = @email, " +
                    "telefono = @telefono, " +
                    "legajo = @legajo, "+
                    "tipo_persona = @tipo_persona "+
                    "WHERE id_persona = @idPersona " , sqlConn);

                cmdSavePersona.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSavePersona.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSavePersona.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = usuario.Direccion;
                cmdSavePersona.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;

                cmdSavePersona.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = usuario.Telefono;
                cmdSavePersona.Parameters.Add("@legajo", SqlDbType.Int).Value = usuario.Legajo;
                cmdSavePersona.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = usuario.TipoPersona;

                cmdSavePersona.Parameters.Add("@idPersona", SqlDbType.Int).Value = usuario.IdPersona;


                cmdSavePersona.ExecuteNonQuery();
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
                SqlCommand cmdSavePersona = new SqlCommand("INSERT INTO personas " +
                    "(nombre,apellido, direccion,email, telefono, fecha_nac, legajo, tipo_persona, id_plan) " +
                    "values(@nombre,@apellido,@direccion, @email, " +
                    "@telefono, @fecha_nac, @legajo, @tipo_persona, @id_plan) " +
                    "select @@identity ", sqlConn);

                cmdSavePersona.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSavePersona.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSavePersona.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = usuario.Direccion;
                cmdSavePersona.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;

                cmdSavePersona.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = usuario.Telefono;
                cmdSavePersona.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 50).Value = usuario.FechaNac;
                cmdSavePersona.Parameters.Add("@legajo", SqlDbType.Int).Value = usuario.Legajo;
                cmdSavePersona.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = usuario.TipoPersona;
                cmdSavePersona.Parameters.Add("@id_plan", SqlDbType.Int).Value = usuario.IdPlan;

                usuario.IdPersona = Decimal.ToInt32((decimal)cmdSavePersona.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Erro al crear persona", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
            try { 
            OpenConnection();
                SqlCommand cmdSaveUsuario = new SqlCommand("INSERT INTO usuarios " +
                    "(nombre_usuario,clave,habilitado,nombre,apellido,email,id_persona)" +
                    "values(@nombre_usuario,@clave,@habilitado,@nombre,@apellido,@email, @id_persona) ", sqlConn);

                cmdSaveUsuario.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSaveUsuario.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSaveUsuario.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSaveUsuario.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSaveUsuario.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSaveUsuario.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;

                cmdSaveUsuario.Parameters.Add("@id_persona", SqlDbType.Int).Value = usuario.IdPersona;


                cmdSaveUsuario.ExecuteNonQuery();                
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
        public List<Usuario> GetAllAlumnos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                OpenConnection();

                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios" +
                    "inner join personas per on usr.id_persona = per.id_persona " +
                    "inner join planes pl on pl.id_plan = per.id_plan" +
                    "inner join  especialidades es on es.id_especialidad = pl.id_especialidad" +
                    "WHERE per.id_persona = 1", sqlConn);

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
    }
}
