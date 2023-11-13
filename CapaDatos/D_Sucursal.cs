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
    public class D_Sucursal
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Sucursal> ListarSucursal(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRASUCURSAL", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Provincia", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Sucursal> Listar = new List<E_Sucursal>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Sucursal
                {
                    IdSucursal = LeerFilas.GetInt32(0),
                    CODSucursal = LeerFilas.GetString(1),
                    Tipo = LeerFilas.GetString(2),
                    Limite_Vehiculos = LeerFilas.GetInt32(3),
                    Calle = LeerFilas.GetString(4),
                    Sector = LeerFilas.GetString(5),
                    Municipio = LeerFilas.GetString(6),
                    Provincia = LeerFilas.GetString(7),
                    Pais = LeerFilas.GetString(8),
                    Metro_Cubico = LeerFilas.GetInt32(9)
                    

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarSucursal(E_Sucursal Sucursal)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTASUCURSAL", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Tipo", Sucursal.Tipo);
            cmd.Parameters.AddWithValue("@Limite_Vehiculos", Sucursal.Limite_Vehiculos);
            cmd.Parameters.AddWithValue("@Calle", Sucursal.Calle);
            cmd.Parameters.AddWithValue("@Sector", Sucursal.Sector);
            cmd.Parameters.AddWithValue("@Municipio", Sucursal.Municipio);
            cmd.Parameters.AddWithValue("@Provincia", Sucursal.Provincia);
            cmd.Parameters.AddWithValue("@Pais", Sucursal.Pais);
            cmd.Parameters.AddWithValue("@Metro_cubico", Sucursal.Metro_Cubico);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarSucursal(E_Sucursal Sucursal)
        {
            SqlCommand cmd = new SqlCommand("SPEDITASUCURSAL", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODSucursal", Sucursal.CODSucursal);
            cmd.Parameters.AddWithValue("@Tipo", Sucursal.Tipo);
            cmd.Parameters.AddWithValue("@Limite_Vehiculos", Sucursal.Limite_Vehiculos);
            cmd.Parameters.AddWithValue("@Calle", Sucursal.Calle);
            cmd.Parameters.AddWithValue("@Sector", Sucursal.Sector);
            cmd.Parameters.AddWithValue("@Municipio", Sucursal.Municipio);
            cmd.Parameters.AddWithValue("@Provincia", Sucursal.Provincia);
            cmd.Parameters.AddWithValue("@Pais", Sucursal.Pais);
            cmd.Parameters.AddWithValue("@Metro_cubico", Sucursal.Metro_Cubico);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarSucursal(E_Sucursal Sucursal)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINASUCURSAL", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODSucursal", Sucursal.CODSucursal);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
