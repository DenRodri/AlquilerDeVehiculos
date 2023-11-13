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
    public class D_Empleados
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Empleados> ListarEmpleados(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRAEMPLEADOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Empleados> Listar = new List<E_Empleados>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Empleados
                {
                    IdEmpleado = LeerFilas.GetInt32(0),
                    CODEmpleado = LeerFilas.GetString(1),
                    IdUsuario = LeerFilas.GetInt32(2),
                    IdDepartamento = LeerFilas.GetInt32(3),
                    Cedula = LeerFilas.GetString(4),
                    Nombre = LeerFilas.GetString(5),
                    Apellido = LeerFilas.GetString(6),
                    Telefono = LeerFilas.GetString(7),
                    Calle = LeerFilas.GetString(8),
                    Sector = LeerFilas.GetString(9),
                    Municipio = LeerFilas.GetString(10),
                    Provincia = LeerFilas.GetString(11),
                    Pais = LeerFilas.GetString(12),
                    Cargo = LeerFilas.GetString(13),
                    Contrato = LeerFilas.GetDateTime(14),
                    Fecha_nacimiento = LeerFilas.GetDateTime(15)

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarEmpleado(E_Empleados Empleado)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTAEMPLEADO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdUsuario", Empleado.IdUsuario);
            cmd.Parameters.AddWithValue("@IdDepartamento", Empleado.IdDepartamento);
            cmd.Parameters.AddWithValue("@Cedula", Empleado.Cedula);
            cmd.Parameters.AddWithValue("@Nombre", Empleado.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Empleado.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", Empleado.Telefono);
            cmd.Parameters.AddWithValue("@Calle", Empleado.Calle);
            cmd.Parameters.AddWithValue("@Sector", Empleado.Sector);
            cmd.Parameters.AddWithValue("@Municipio", Empleado.Municipio);
            cmd.Parameters.AddWithValue("@Provincia", Empleado.Provincia);
            cmd.Parameters.AddWithValue("@Pais", Empleado.Pais);
            cmd.Parameters.AddWithValue("@Cargo", Empleado.Cargo);
            cmd.Parameters.AddWithValue("@Contrato", Empleado.Contrato);
            cmd.Parameters.AddWithValue("@Fecha_nacimiento", Empleado.Fecha_nacimiento);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarEmpleado(E_Empleados Empleado)
        {
            SqlCommand cmd = new SqlCommand("SPEDITAEMPLEADO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODEmpleado", Empleado.CODEmpleado);
            cmd.Parameters.AddWithValue("@IdUsuario", Empleado.IdUsuario);
            cmd.Parameters.AddWithValue("@IdDepartamento", Empleado.IdDepartamento);
            cmd.Parameters.AddWithValue("@Cedula", Empleado.Cedula);
            cmd.Parameters.AddWithValue("@Nombre", Empleado.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Empleado.Apellido);
            cmd.Parameters.AddWithValue("@Telefono", Empleado.Telefono);
            cmd.Parameters.AddWithValue("@Calle", Empleado.Calle);
            cmd.Parameters.AddWithValue("@Sector", Empleado.Sector);
            cmd.Parameters.AddWithValue("@Municipio", Empleado.Municipio);
            cmd.Parameters.AddWithValue("@Provincia", Empleado.Provincia);
            cmd.Parameters.AddWithValue("@Pais", Empleado.Pais);
            cmd.Parameters.AddWithValue("@Cargo", Empleado.Cargo);
            cmd.Parameters.AddWithValue("@Contrato", Empleado.Contrato);
            cmd.Parameters.AddWithValue("@Fecha_nacimiento", Empleado.Fecha_nacimiento);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarEmpleado(E_Empleados Empleado)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINAEMPLEADO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODEmpleado", Empleado.CODEmpleado);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
