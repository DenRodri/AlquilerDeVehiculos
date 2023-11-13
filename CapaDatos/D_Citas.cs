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
    public class D_Citas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public int SafeGetint(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
            {
                return reader.GetInt32(colIndex);
            }
            else
            {
                return 0;
            }
        }
        public List<E_Citas> ListarCitas(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRACITAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODCita", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Citas> Listar = new List<E_Citas>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Citas
                {
                    IdCita = LeerFilas.GetInt32(0),
                    CODCita = LeerFilas.GetString(1),
                    IdCliente = LeerFilas.GetInt32(2),
                    IdSucursal = LeerFilas.GetInt32(3),
                    Kilometraje = LeerFilas.GetInt32(4),
                    Garantia = LeerFilas.GetString(5),
                    Observaciones = LeerFilas.GetString(6),
                    Hecho_por = LeerFilas.GetString(7),
                    IdEmpleado = LeerFilas.GetInt32(8),
                    IdContacto = SafeGetint(LeerFilas, 9)

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarCita(E_Citas Cita)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTACITAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdCliente", Cita.IdCliente);
            cmd.Parameters.AddWithValue("@IdSucursal", Cita.IdSucursal);
            cmd.Parameters.AddWithValue("@Kilometraje", Cita.Kilometraje);
            cmd.Parameters.AddWithValue("@Garantia", Cita.Garantia);
            cmd.Parameters.AddWithValue("@Observaciones", Cita.Observaciones);
            cmd.Parameters.AddWithValue("@Hecho_por", Cita.Hecho_por);
            cmd.Parameters.AddWithValue("@IdEmpleado", Cita.IdEmpleado);
            cmd.Parameters.AddWithValue("@IdContacto", Cita.IdContacto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarCita(E_Citas Cita)
        {
            SqlCommand cmd = new SqlCommand("SPEDITACITAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODCita", Cita.CODCita);
            cmd.Parameters.AddWithValue("@IdCliente", Cita.IdCliente);
            cmd.Parameters.AddWithValue("@IdSucursal", Cita.IdSucursal);
            cmd.Parameters.AddWithValue("@Kilometraje", Cita.Kilometraje);
            cmd.Parameters.AddWithValue("@Garantia", Cita.Garantia);
            cmd.Parameters.AddWithValue("@Observaciones", Cita.Observaciones);
            cmd.Parameters.AddWithValue("@Hecho_por", Cita.Hecho_por);
            cmd.Parameters.AddWithValue("@IdEmpleado", Cita.IdEmpleado);
            cmd.Parameters.AddWithValue("@IdContacto", Cita.IdContacto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarCita(E_Citas Cita)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINACITAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODCita", Cita.CODCita);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
