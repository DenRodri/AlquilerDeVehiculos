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
    public class D_Vehiculos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Vehiculos> ListarVehiculos(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRAVEHICULOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@No_Chassis", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Vehiculos> Listar = new List<E_Vehiculos>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Vehiculos
                {
                    IdVehiculo = LeerFilas.GetInt32(0),
                    CODVehiculo = LeerFilas.GetString(1),
                    IdInventario = LeerFilas.GetInt32(2),
                    IdContacto = LeerFilas.GetInt32(3),
                    IdSucursal = LeerFilas.GetInt32(4),
                    IdEmpleado_Creador = LeerFilas.GetInt32(5),
                    No_Chassis = LeerFilas.GetString(6),
                    Fecha_Comprado = LeerFilas.GetDateTime(7),
                    Monto_Compra = LeerFilas.GetInt32(8),
                    Color = LeerFilas.GetString(9),
                    Motor = LeerFilas.GetString(10),
                    Millaje = LeerFilas.GetInt32(11),
                    Transmision = LeerFilas.GetString(12),
                    Traccion = LeerFilas.GetString(13),
                    Combustion = LeerFilas.GetString(14)

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarVehiculo(E_Vehiculos Vehiculo)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTAVEHICULOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdInventario", Vehiculo.IdInventario);
            cmd.Parameters.AddWithValue("@IdContacto", Vehiculo.IdContacto);
            cmd.Parameters.AddWithValue("@IdSucursal", Vehiculo.IdSucursal);
            cmd.Parameters.AddWithValue("@IdEmpleado_Creador", Vehiculo.IdEmpleado_Creador);
            cmd.Parameters.AddWithValue("@No_Chassis", Vehiculo.No_Chassis);
            cmd.Parameters.AddWithValue("@Fecha_Comprado", Vehiculo.Fecha_Comprado);
            cmd.Parameters.AddWithValue("@Monto_Compra", Vehiculo.Monto_Compra);
            cmd.Parameters.AddWithValue("@Color", Vehiculo.Color);
            cmd.Parameters.AddWithValue("@Motor", Vehiculo.Motor);
            cmd.Parameters.AddWithValue("@Millaje", Vehiculo.Millaje);
            cmd.Parameters.AddWithValue("@Transmision", Vehiculo.Transmision);
            cmd.Parameters.AddWithValue("@Traccion", Vehiculo.Traccion);
            cmd.Parameters.AddWithValue("@Combustion", Vehiculo.Combustion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarVehiculo(E_Vehiculos Vehiculo)
        {
            SqlCommand cmd = new SqlCommand("SPEDITAVEHICULOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODVehiculo", Vehiculo.CODVehiculo);
            cmd.Parameters.AddWithValue("@IdInventario", Vehiculo.IdInventario);
            cmd.Parameters.AddWithValue("@IdContacto", Vehiculo.IdContacto);
            cmd.Parameters.AddWithValue("@IdSucursal", Vehiculo.IdSucursal);
            cmd.Parameters.AddWithValue("@IdEmpleado_Creador", Vehiculo.IdEmpleado_Creador);
            cmd.Parameters.AddWithValue("@No_Chassis", Vehiculo.No_Chassis);
            cmd.Parameters.AddWithValue("@Fecha_Comprado", Vehiculo.Fecha_Comprado);
            cmd.Parameters.AddWithValue("@Monto_Compra", Vehiculo.Monto_Compra);
            cmd.Parameters.AddWithValue("@Color", Vehiculo.Color);
            cmd.Parameters.AddWithValue("@Motor", Vehiculo.Motor);
            cmd.Parameters.AddWithValue("@Millaje", Vehiculo.Millaje);
            cmd.Parameters.AddWithValue("@Transmision", Vehiculo.Transmision);
            cmd.Parameters.AddWithValue("@Traccion", Vehiculo.Traccion);
            cmd.Parameters.AddWithValue("@Combustion", Vehiculo.Combustion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarVehiculo(E_Vehiculos Vehiculo)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINAVEHICULOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODVehiculo", Vehiculo.CODVehiculo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
