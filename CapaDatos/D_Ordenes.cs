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
    public class D_Ordenes
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Ordenes> ListarOrdenes(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRAORDENES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Num_Poliza", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Ordenes> Listar = new List<E_Ordenes>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Ordenes
                {
                    IdCita = LeerFilas.GetInt32(0),
                    IdVehiculo = LeerFilas.GetInt32(1),
                    Fecha_Entrega = LeerFilas.GetDateTime(2),
                    Fecha_devolucion = LeerFilas.GetDateTime(3),
                    En_Proceso = LeerFilas.GetString(4),
                    Utilidad = LeerFilas.GetString(5),
                    MetodoPago = LeerFilas.GetString(6),
                    Tarifa = LeerFilas.GetInt32(7),
                    Total_Pag = LeerFilas.GetInt32(8),
                    Num_Poliza = LeerFilas.GetString(9),


                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarOrden(E_Ordenes Orden)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTAORDENES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCita", Orden.IdCita);
            cmd.Parameters.AddWithValue("@IdVehiculo", Orden.IdVehiculo);
            cmd.Parameters.AddWithValue("@Fecha_Entrega", Orden.Fecha_Entrega);
            cmd.Parameters.AddWithValue("@Fecha_devolucion", Orden.Fecha_devolucion);
            cmd.Parameters.AddWithValue("@En_Proceso", Orden.En_Proceso);
            cmd.Parameters.AddWithValue("@Utilidad", Orden.Utilidad);
            cmd.Parameters.AddWithValue("@MetodoPago", Orden.MetodoPago);
            cmd.Parameters.AddWithValue("@Tarifa", Orden.Tarifa);
            cmd.Parameters.AddWithValue("@Total_Pag", Orden.Total_Pag);
            cmd.Parameters.AddWithValue("@Num_Poliza", Orden.Num_Poliza);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarOrden(E_Ordenes Orden)
        {
            SqlCommand cmd = new SqlCommand("SPEDITAORDENES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCita", Orden.IdCita);
            cmd.Parameters.AddWithValue("@IdVehiculo", Orden.IdVehiculo);
            cmd.Parameters.AddWithValue("@Fecha_Entrega", Orden.Fecha_Entrega);
            cmd.Parameters.AddWithValue("@Fecha_devolucion", Orden.Fecha_devolucion);
            cmd.Parameters.AddWithValue("@En_Proceso", Orden.En_Proceso);
            cmd.Parameters.AddWithValue("@Utilidad", Orden.Utilidad);
            cmd.Parameters.AddWithValue("@MetodoPago", Orden.MetodoPago);
            cmd.Parameters.AddWithValue("@Tarifa", Orden.Tarifa);
            cmd.Parameters.AddWithValue("@Total_Pag", Orden.Total_Pag);
            cmd.Parameters.AddWithValue("@Num_Poliza", Orden.Num_Poliza);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarOrden(E_Ordenes Orden)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINAORDENES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Num_Poliza", Orden.Num_Poliza);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
