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
    public class D_Fotos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Fotos> ListarFotos(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRAFOTOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Fotos> Listar = new List<E_Fotos>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Fotos
                {
                    IdFoto = LeerFilas.GetInt32(0),
                    CODFoto = LeerFilas.GetString(1),
                    IdVehiculo = LeerFilas.GetInt32(2),
                    Nombre = LeerFilas.GetString(3),
                    Tipo_foto = LeerFilas.GetString(4),
                    Link_Imagen = LeerFilas.GetString(5),
                    Fecha_Foto = LeerFilas.GetDateTime(6),

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarFoto(E_Fotos Foto)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTAFOTOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdVehiculo", Foto.IdVehiculo);
            cmd.Parameters.AddWithValue("@Nombre", Foto.Nombre);
            cmd.Parameters.AddWithValue("@Tipo_foto", Foto.Tipo_foto);
            cmd.Parameters.AddWithValue("@Link_Imagen", Foto.Link_Imagen);
            cmd.Parameters.AddWithValue("@Fecha_Foto", Foto.Fecha_Foto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarFoto(E_Fotos Foto)
        {
            SqlCommand cmd = new SqlCommand("SPEDITAFOTOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODFoto", Foto.CODFoto);
            cmd.Parameters.AddWithValue("@IdVehiculo", Foto.IdVehiculo);
            cmd.Parameters.AddWithValue("@Nombre", Foto.Nombre);
            cmd.Parameters.AddWithValue("@Tipo_foto", Foto.Tipo_foto);
            cmd.Parameters.AddWithValue("@Link_Imagen", Foto.Link_Imagen);
            cmd.Parameters.AddWithValue("@Fecha_Foto", Foto.Fecha_Foto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarFoto(E_Fotos Foto)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINAFOTOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODFoto", Foto.CODFoto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
