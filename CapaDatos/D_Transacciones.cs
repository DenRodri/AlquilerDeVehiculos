using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class D_Transacciones
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Transacciones> ListarTransacciones(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRATRANSACCIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODTransaccion", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Transacciones> Listar = new List<E_Transacciones>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Transacciones
                {
                    IdTransaccion = LeerFilas.GetInt32(0),
                    CODTransaccion = LeerFilas.GetString(1),
                    IdFactura = LeerFilas.GetInt32(2),
                    IdCliente = LeerFilas.GetInt32(3),
                    Monto = LeerFilas.GetInt32(4),
                    Fecha = LeerFilas.GetDateTime(5),

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarTransaccione(E_Transacciones Transaccione)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTATRANSACCIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdFactura", Transaccione.IdFactura);
            cmd.Parameters.AddWithValue("@IdCliente", Transaccione.IdCliente);
            cmd.Parameters.AddWithValue("@Monto", Transaccione.Monto);
            cmd.Parameters.AddWithValue("@Fecha", Transaccione.Fecha);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarTransaccione(E_Transacciones Transaccione)
        {
            SqlCommand cmd = new SqlCommand("SPEDITATRANSACCIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODTransaccione", Transaccione.CODTransaccion);
            cmd.Parameters.AddWithValue("@IdFactura", Transaccione.IdFactura);
            cmd.Parameters.AddWithValue("@IdCliente", Transaccione.IdCliente);
            cmd.Parameters.AddWithValue("@Monto", Transaccione.Monto);
            cmd.Parameters.AddWithValue("@Fecha", Transaccione.Fecha);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarTransaccione(E_Transacciones Transaccione)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINATRANSACCIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODTransaccione", Transaccione.CODTransaccion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
