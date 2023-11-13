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
    public class D_Usuarios
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Usuarios> ListarUsuarios(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRAUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Usuarios> Listar = new List<E_Usuarios>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Usuarios
                {
                    IdUsuario = LeerFilas.GetInt32(0),
                    IdRol = LeerFilas.GetInt32(1),
                    CODUsuario = LeerFilas.GetString(2),
                    Nombre = LeerFilas.GetString(3),
                    Fecha_Creacion_Cuenta = LeerFilas.GetDateTime(4),
                    Password = LeerFilas.GetString(5),
                    Email = LeerFilas.GetString(6),
                    Ultima_vez_ingresada = LeerFilas.GetDateTime(7),
                    Online = LeerFilas.GetBoolean(8),
                    Habilitado = LeerFilas.GetBoolean(9)

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarUsuario(E_Usuarios Usuario)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTAUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdRol", Usuario.IdRol);
            cmd.Parameters.AddWithValue("@Nombre", Usuario.Nombre);
            cmd.Parameters.AddWithValue("@Fecha_Creacion_Cuenta", Usuario.Fecha_Creacion_Cuenta);
            cmd.Parameters.AddWithValue("@Contraseña", Usuario.Password);
            cmd.Parameters.AddWithValue("@Email", Usuario.Email);
            cmd.Parameters.AddWithValue("@Ultima_vez_ingresada", Usuario.Ultima_vez_ingresada);
            cmd.Parameters.AddWithValue("@On_line", Usuario.Online);
            cmd.Parameters.AddWithValue("@Habilitado", Usuario.Habilitado);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarUsuario(E_Usuarios Usuario)
        {
            SqlCommand cmd = new SqlCommand("SPEDITAUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODUsuario", Usuario.CODUsuario);
            cmd.Parameters.AddWithValue("@IdRol", Usuario.IdRol);
            cmd.Parameters.AddWithValue("@Nombre", Usuario.Nombre);
            cmd.Parameters.AddWithValue("@Fecha_Creacion_Cuenta", Usuario.Fecha_Creacion_Cuenta);
            cmd.Parameters.AddWithValue("@Contraseña", Usuario.Password);
            cmd.Parameters.AddWithValue("@Email", Usuario.Email);
            cmd.Parameters.AddWithValue("@Ultima_vez_ingresada", Usuario.Ultima_vez_ingresada);
            cmd.Parameters.AddWithValue("@On_line", Usuario.Online);
            cmd.Parameters.AddWithValue("@Habilitado", Usuario.Habilitado);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarUsuario(E_Usuarios Usuario)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINAUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODUsuario", Usuario.CODUsuario);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
