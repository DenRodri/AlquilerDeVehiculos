using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_Departamentos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Departamentos> ListarDepartamentos(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRADEPARTAMENTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Departamentos> Listar = new List<E_Departamentos>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Departamentos
                {
                    IdDepartamento = LeerFilas.GetInt32(0),
                    CODDepartamento = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Telefono = LeerFilas.GetString(3),
                    Descripcion = LeerFilas.GetString(4)

                });

            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarDepartamento(E_Departamentos Departamento)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTADEPARTAMENTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Departamento.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", Departamento.Telefono);
            cmd.Parameters.AddWithValue("@Descripcion", Departamento.Descripcion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarDepartamento(E_Departamentos Departamento)
        {
            SqlCommand cmd = new SqlCommand("SPEDITADEPARTAMENTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODDepartamento", Departamento.CODDepartamento);
            cmd.Parameters.AddWithValue("@Nombre", Departamento.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", Departamento.Telefono);
            cmd.Parameters.AddWithValue("@Descripcion", Departamento.Descripcion);
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarDepartamento(E_Departamentos Departamento)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINADEPARTAMENTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODDepartamento", Departamento.CODDepartamento);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
