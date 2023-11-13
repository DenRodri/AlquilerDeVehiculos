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
    public class D_Facturas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Facturas> ListarFacturas(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRAFACTURAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@RNC", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Facturas> Listar = new List<E_Facturas>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Facturas
                {
                    IdFactura = LeerFilas.GetInt32(0),
                    CODFactura = LeerFilas.GetString(1),
                    IdCita = LeerFilas.GetInt32(2),
                    Nombre_Agencia = LeerFilas.GetString(3),
                    RNC = LeerFilas.GetString(4),
                    Fecha = LeerFilas.GetDateTime(5),
                    ITEBIS = LeerFilas.GetInt32(6),
                    Descuento = LeerFilas.GetInt32(7),
                    Total_General = LeerFilas.GetInt32(8),

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarFactura(E_Facturas Factura)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTAFACTURAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCita", Factura.IdCita);
            cmd.Parameters.AddWithValue("@Nombre_Agencia", Factura.Nombre_Agencia);
            cmd.Parameters.AddWithValue("@RNC", Factura.RNC);
            cmd.Parameters.AddWithValue("@Fecha", Factura.Fecha);
            cmd.Parameters.AddWithValue("@Total_Bruto", Factura.Total_Bruto);
            cmd.Parameters.AddWithValue("@ITEBIS", Factura.ITEBIS);
            cmd.Parameters.AddWithValue("@Descuento", Factura.Descuento);
            cmd.Parameters.AddWithValue("@Total_General", Factura.Total_General);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarFactura(E_Facturas Factura)
        {
            SqlCommand cmd = new SqlCommand("SPEDITAFACTURAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODFactura", Factura.CODFactura);
            cmd.Parameters.AddWithValue("@IdCita", Factura.IdCita);
            cmd.Parameters.AddWithValue("@Nombre_Agencia", Factura.Nombre_Agencia);
            cmd.Parameters.AddWithValue("@RNC", Factura.RNC);
            cmd.Parameters.AddWithValue("@Fecha", Factura.Fecha);
            cmd.Parameters.AddWithValue("@Total_Bruto", Factura.Total_Bruto);
            cmd.Parameters.AddWithValue("@ITEBIS", Factura.ITEBIS);
            cmd.Parameters.AddWithValue("@Descuento", Factura.Descuento);
            cmd.Parameters.AddWithValue("@Total_General", Factura.Total_General);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarFactura(E_Facturas Factura)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINAFACTURA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODFactura", Factura.CODFactura);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
