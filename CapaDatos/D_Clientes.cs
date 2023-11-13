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
    public class D_Clientes
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Clientes> ListarClientes(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRACLIENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Clientes> Listar = new List<E_Clientes>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Clientes
                {
                    IdCliente = LeerFilas.GetInt32(0),
                    CODCliente = LeerFilas.GetString(1),
                    IdUsuario = LeerFilas.GetInt32(2),
                    IdEmpleado_Creador = LeerFilas.GetInt32(3),
                    Cedula = LeerFilas.GetString(4),
                    Documento = LeerFilas.GetString(5),
                    Documento_num = LeerFilas.GetInt32(6),
                    Tarjeta_Credito = LeerFilas.GetString(7),
                    Trato = LeerFilas.GetString(8),
                    Nombre = LeerFilas.GetString(9),
                    Apellido = LeerFilas.GetString(10),
                    Telefono = LeerFilas.GetString(11),
                    Calle = LeerFilas.GetString(12),
                    Sector = LeerFilas.GetString(13),
                    Municipio = LeerFilas.GetString(14),
                    Provincia = LeerFilas.GetString(15),
                    Pais = LeerFilas.GetString(16),
                    Fecha_nacimiento = LeerFilas.GetDateTime(17),
                    Foto_Link = LeerFilas.GetString(18),
                    Tipo_Cliente = LeerFilas.GetString(19),
                    Observacion = LeerFilas.GetString(20)
                    
            }); 
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarCliente(E_Clientes Cliente)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTACLIENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdUsuario", Cliente.IdUsuario);
            cmd.Parameters.AddWithValue("@IdEmpleado_Creador", Cliente.IdEmpleado_Creador);
            cmd.Parameters.AddWithValue("@Cedula", Cliente.Cedula);
            cmd.Parameters.AddWithValue("@Documento", Cliente.Documento);
            cmd.Parameters.AddWithValue("@Documento_Num", Cliente.Documento_num);
            cmd.Parameters.AddWithValue("@Tarjeta_Credito", Cliente.Tarjeta_Credito);
            cmd.Parameters.AddWithValue("@Trato", Cliente.Trato);
            cmd.Parameters.AddWithValue("@Nombre", Cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Cliente.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
            cmd.Parameters.AddWithValue("@Calle", Cliente.Calle);
            cmd.Parameters.AddWithValue("@Sector", Cliente.Sector);
            cmd.Parameters.AddWithValue("@Municipio", Cliente.Municipio);
            cmd.Parameters.AddWithValue("@Provincia", Cliente.Provincia);
            cmd.Parameters.AddWithValue("@Pais", Cliente.Pais);
            cmd.Parameters.AddWithValue("@Fecha_nacimiento", Cliente.Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@Foto_Link", Cliente.Foto_Link);
            cmd.Parameters.AddWithValue("@Tipo_Cliente", Cliente.Tipo_Cliente);
            cmd.Parameters.AddWithValue("@Observacion", Cliente.Observacion);
            

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarCliente(E_Clientes Cliente)
        {
            SqlCommand cmd = new SqlCommand("SPEDITACLIENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODCliente", Cliente.CODCliente);
            cmd.Parameters.AddWithValue("@IdUsuario", Cliente.IdUsuario);
            cmd.Parameters.AddWithValue("@IdEmpleado_Creador", Cliente.IdEmpleado_Creador);
            cmd.Parameters.AddWithValue("@Cedula", Cliente.Cedula);
            cmd.Parameters.AddWithValue("@Documento", Cliente.Documento);
            cmd.Parameters.AddWithValue("@Documento_Num", Cliente.Documento_num);
            cmd.Parameters.AddWithValue("@Tarjeta_Credito", Cliente.Tarjeta_Credito);
            cmd.Parameters.AddWithValue("@Trato", Cliente.Trato);
            cmd.Parameters.AddWithValue("@Nombre", Cliente.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Cliente.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
            cmd.Parameters.AddWithValue("@Calle", Cliente.Calle);
            cmd.Parameters.AddWithValue("@Sector", Cliente.Sector);
            cmd.Parameters.AddWithValue("@Municipio", Cliente.Municipio);
            cmd.Parameters.AddWithValue("@Provincia", Cliente.Provincia);
            cmd.Parameters.AddWithValue("@Pais", Cliente.Pais);
            cmd.Parameters.AddWithValue("@Fecha_nacimiento", Cliente.Fecha_nacimiento);
            cmd.Parameters.AddWithValue("@Foto_Link", Cliente.Foto_Link);
            cmd.Parameters.AddWithValue("@Tipo_Cliente", Cliente.Tipo_Cliente);
            cmd.Parameters.AddWithValue("@Observacion", Cliente.Observacion);
            

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarCliente(E_Clientes Cliente)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINACLIENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODCliente", Cliente.CODCliente);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
