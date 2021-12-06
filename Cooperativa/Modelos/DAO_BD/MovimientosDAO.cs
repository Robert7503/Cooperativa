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
    public class MovimientosDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevaTransaccion(Movimiento movimiento)
        {
            bool inserto = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("Insert into Tipo_Transaccion");
                sql.Append("Values(IdCliente,@Transaccion,@Moneda,@ValorTransaccion);");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = movimiento.IdCliente;
                comando.Parameters.Add("@Transaccion", SqlDbType.NVarChar, 20).Value = movimiento.Transaccion;
                comando.Parameters.Add("@Moneda", SqlDbType.NVarChar, 30).Value = movimiento.Moneda;
                comando.Parameters.Add("@ValorTransaccion", SqlDbType.Decimal).Value = movimiento.ValorTransaccion;
                //comando.ExecuteNonQuery();
                inserto =true;
                MiConexion.Close();
                
            }
            catch (Exception ex)
            {
                return inserto;

            }
            return inserto;

        }

        public DataTable GetMovimientos()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Select * from Tipo_Transaccion");

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
