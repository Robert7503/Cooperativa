using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cooperativa.Modelos.Entidades;

namespace Cooperativa.Modelos.DAO_BD
{
    public class UsuarioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool ValidarUsuario(Usuario user)
        {
            bool valido = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Select 1 from USUARIO where EMAIL=@EMAIL AND CLAVE=@Clave;");                
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Email",SqlDbType.NVarChar,50).Value = user.Email;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 80).Value = user.Clave;
                valido =Convert.ToBoolean(comando.ExecuteScalar());
                MiConexion.Close();
                
            }
            catch (Exception ex)
            {

               
            }
            return valido;
        }

        public bool InsertarNuevoUsuario(Usuario user)
        {
            try
            {
               
                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into usuario");
                sql.Append("Values(@Nombre,@Email,@Clave,@EsAdministrador);");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 80).Value = user.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 80).Value = user.Clave;
                comando.Parameters.Add("@EsAdminstrador", SqlDbType.Bit).Value = user.EsAdministrador;
                //comando.ExecuteNonQuery();
                MiConexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
            
        }

        public DataTable GetUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Select * from USUARIO");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }

            return dt;
            
        }

        public bool ActualizarUsuario(Usuario user)
        {
            bool modifico = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE usuario");
                sql.Append(" SET NOMBRE=@Nombre,EMAIL=@Email,CLAVE=@Clave,ESADMINISTRADOR=@EsAdministrador");
                sql.Append(" where ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 80).Value = user.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 80).Value = user.Clave;
                comando.Parameters.Add("@EsAdminstrador", SqlDbType.Bit).Value = user.EsAdministrador;
                //comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();
                

            }
            catch (Exception ex)
            {
                return modifico;

            }
            return modifico;
        }

        public bool EliminarUsuario(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Delete from USUARIO ");
                sql.Append("Where ID=@Id");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.NVarChar, 80).Value = id;

                //comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                return modifico;
            }

            return modifico;


        }

    }

}
