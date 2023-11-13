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
    public class D_Estado_Vehiculos
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
        public List<E_Estado_Vehiculos> ListarEstado_Vehiculos(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRAESTADO_VEHICULO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Placa", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Estado_Vehiculos> Listar = new List<E_Estado_Vehiculos>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Estado_Vehiculos
                {
                    IdEstado = LeerFilas.GetInt32(0),
                    CODEstado = LeerFilas.GetString(1),
                    IdVehiculo = LeerFilas.GetInt32(2),
                    IdEmpleado_Creador = LeerFilas.GetInt32(3),
                    Nota = LeerFilas.GetString(4),
                    Placa = LeerFilas.GetString(5),
                    Matricula = LeerFilas.GetString(6),
                    Combustible = LeerFilas.GetString(7),
                    Lubricacion = LeerFilas.GetString(8),
                    En_Uso = LeerFilas.GetBoolean(9),
                    Fecha_Ultima_Revision = LeerFilas.GetDateTime(10),
                    Revisado_Por = LeerFilas.GetString(11),
                    IdContacto = SafeGetint(LeerFilas, 12)

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarEstado_Vehiculo(E_Estado_Vehiculos Estado_Vehiculo)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTAESTADO_VEHICULO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdVehiculo", Estado_Vehiculo.IdVehiculo);
            cmd.Parameters.AddWithValue("@IdEmpleado_Creador", Estado_Vehiculo.IdEmpleado_Creador);
            cmd.Parameters.AddWithValue("@Nota", Estado_Vehiculo.Nota);
            cmd.Parameters.AddWithValue("@Placa", Estado_Vehiculo.Placa);
            cmd.Parameters.AddWithValue("@Matricula", Estado_Vehiculo.Matricula);
            cmd.Parameters.AddWithValue("@Combustible", Estado_Vehiculo.Combustible);
            cmd.Parameters.AddWithValue("@Lubricacion", Estado_Vehiculo.Lubricacion);
            cmd.Parameters.AddWithValue("@En_Uso", Estado_Vehiculo.En_Uso);
            cmd.Parameters.AddWithValue("@Fecha_Ultima_Revision", Estado_Vehiculo.Fecha_Ultima_Revision);
            cmd.Parameters.AddWithValue("@Revisado_Por", Estado_Vehiculo.Revisado_Por);
            cmd.Parameters.AddWithValue("@IdContacto", Estado_Vehiculo.IdContacto);
        
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarEstado_Vehiculo(E_Estado_Vehiculos Estado_Vehiculo)
        {
            SqlCommand cmd = new SqlCommand("SPEDITAESTADO_VEHICULO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODEstado_Vehiculo", Estado_Vehiculo.CODEstado);
            cmd.Parameters.AddWithValue("@IdVehiculo", Estado_Vehiculo.IdVehiculo);
            cmd.Parameters.AddWithValue("@IdEmpleado_Creador", Estado_Vehiculo.IdEmpleado_Creador);
            cmd.Parameters.AddWithValue("@Nota", Estado_Vehiculo.Nota);
            cmd.Parameters.AddWithValue("@Placa", Estado_Vehiculo.Placa);
            cmd.Parameters.AddWithValue("@Matricula", Estado_Vehiculo.Matricula);
            cmd.Parameters.AddWithValue("@Combustible", Estado_Vehiculo.Combustible);
            cmd.Parameters.AddWithValue("@Lubricacion", Estado_Vehiculo.Lubricacion);
            cmd.Parameters.AddWithValue("@En_Uso", Estado_Vehiculo.En_Uso);
            cmd.Parameters.AddWithValue("@Fecha_Ultima_Revision", Estado_Vehiculo.Fecha_Ultima_Revision);
            cmd.Parameters.AddWithValue("@Revisado_Por", Estado_Vehiculo.Revisado_Por);
            cmd.Parameters.AddWithValue("@IdContacto", Estado_Vehiculo.IdContacto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarEstado_Vehiculo(E_Estado_Vehiculos Estado_Vehiculo)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINAESTADO_VEHICULO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODEstado_Vehiculo", Estado_Vehiculo.CODEstado);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
