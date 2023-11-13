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
    public class D_Inventarios
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Inventarios> ListarInventarios(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRAINVENTARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Marca", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Inventarios> Listar = new List<E_Inventarios>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Inventarios
                {
                    IdInventario = LeerFilas.GetInt32(0),
                    CODInventario = LeerFilas.GetString(1),
                    IdEmpleado_Creador = LeerFilas.GetInt32(2),
                    Tipo = LeerFilas.GetString(3),
                    Marca = LeerFilas.GetString(4),
                    Modelo = LeerFilas.GetString(5),
                    Version = LeerFilas.GetString(6),
                    Año = LeerFilas.GetInt32(7),
                    Cantidad = LeerFilas.GetInt32(8),
                    Costo = LeerFilas.GetInt32(9)

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarInventario(E_Inventarios Inventario)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTAINVENTARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdEmpleado_Creador", Inventario.IdEmpleado_Creador);
            cmd.Parameters.AddWithValue("@Tipo", Inventario.Tipo);
            cmd.Parameters.AddWithValue("@Marca", Inventario.Marca);
            cmd.Parameters.AddWithValue("@Modelo", Inventario.Modelo);
            cmd.Parameters.AddWithValue("@Version", Inventario.Version);
            cmd.Parameters.AddWithValue("@Año", Inventario.Año);
            cmd.Parameters.AddWithValue("@Cantidad", Inventario.Cantidad);
            cmd.Parameters.AddWithValue("@Costo", Inventario.Costo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarInventario(E_Inventarios Inventario)
        {
            SqlCommand cmd = new SqlCommand("SPEDITAINVENTARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODInventario", Inventario.CODInventario);
            cmd.Parameters.AddWithValue("@IdEmpleado_Creador", Inventario.IdEmpleado_Creador);
            cmd.Parameters.AddWithValue("@Tipo", Inventario.Tipo);
            cmd.Parameters.AddWithValue("@Marca", Inventario.Marca);
            cmd.Parameters.AddWithValue("@Modelo", Inventario.Modelo);
            cmd.Parameters.AddWithValue("@Version", Inventario.Version);
            cmd.Parameters.AddWithValue("@Año", Inventario.Año);
            cmd.Parameters.AddWithValue("@Cantidad", Inventario.Cantidad);
            cmd.Parameters.AddWithValue("@Costo", Inventario.Costo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarInventario(E_Inventarios Inventario)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINAINVENTARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODInventario", Inventario.CODInventario);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
