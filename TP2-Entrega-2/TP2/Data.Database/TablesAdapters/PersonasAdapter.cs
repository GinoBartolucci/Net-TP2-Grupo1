using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities.Tables;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database.TablesAdapters
{
    public class PersonasAdapter:Adapter
    {
        public PersonasAdapter()
        {

        }
        public List<Personas> GetAll()
        {
            List<Personas> personas = new List<Personas>();
            try
            {
                OpenConnection();

                SqlCommand cmdPersonas = new SqlCommand("select * from personas", sqlConn);

                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                while (drPersonas.Read())
                {
                    Personas per = new Personas();

                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.Tipo_perona = (int)drPersonas["tipo_persona"];
                    per.Fecha_nac = (DateTime)drPersonas["fecha_nac"];

                    personas.Add(per);
                }

                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de personas.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return personas;

        }
        public Personas GetOne(int ID)
        {
            Personas per = new Personas();
            try
            {
                OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT * FROM personas WHERE id_persona = @id_persona", sqlConn);
                cmdPersonas.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.Tipo_perona = (int)drPersonas["tipo_persona"];
                    per.Fecha_nac = (DateTime)drPersonas["fecha_nac"];
                }
                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (per.Nombre != null)
            {
                return per;
            }
            else
            {
                throw new Exception("La persona no existe");
            }
        }
        public void Save(Personas persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                Delete(persona.ID);
            }

            else if (persona.State == BusinessEntity.States.New)
            {
                Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar a la persona", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        protected void Update(Personas persona)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE personas SET nombre = @nombre, apellido = @apellido, " +
                    "direccion = @direccion, email = @email, telefono = @telefono, legajo = @legajo, tipo_persona= @tipo_persona," +
                    "fecha_nac = @fecha_nac WHERE id = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.Tipo_perona;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.Tipo_perona;
                cmdSave.ExecuteNonQuery();
                //fijarse que exista la clave foranea de plan

            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la persona", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
        protected void Insert(Personas persona)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO personas (nombre,apellido,direccion,email,telefono,legajo,tipo_persona,fecha_nac)" +
                    "values(@nombre,@apellido,@direccion,@email,@telefono,@legajo,@tipo_persona,@fecha_nac)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.Tipo_perona;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.Fecha_nac;

                persona.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

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
