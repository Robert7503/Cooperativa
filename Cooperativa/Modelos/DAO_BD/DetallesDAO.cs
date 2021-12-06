using Cooperativa.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperativa.Modelos.DAO_BD
{
    public class DetallesDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertDetalle(Detalles user)
        {
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into Detalles");
                sql.Append("Values(getdate(),@IdCliente,@IdCliente,@Transaccion,@Moneda);");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
               /* comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdCliente", SqlDbType.NVarChar, 80).Value = Detalles.IdCliente;
                comando.Parameters.Add("@Transaccion", SqlDbType.NVarChar, 50).Value = Detalles.iDTransaccion;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 80).Value = Detalles.TipoTransaccion;
                comando.Parameters.Add("@EsAdminstrador", SqlDbType.Bit).Value = Detalles.SaldoInicail;
                comando.Parameters.Add("@EsAdminstrador", SqlDbType.Bit).Value = Detalles.SaldoFinal;
                //comando.ExecuteNonQuery();*/
                MiConexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
        public DataTable GetDetalles()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Select * from DETALLES");

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

    }
}
