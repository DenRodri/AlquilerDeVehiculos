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
    public class D_Presupuestos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Presupuestos> ListarPresupuestos(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRAPRESUPUESTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODPresupuesto", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Presupuestos> Listar = new List<E_Presupuestos>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Presupuestos
                {
                    IdPresupuesto = LeerFilas.GetInt32(0),
                    CODPresupuesto = LeerFilas.GetString(1),
                    IdDepartamento = LeerFilas.GetInt32(2),
                    Presupuesto = LeerFilas.GetInt32(3),
                    Nota = LeerFilas.GetString(4),
                    Fecha_actualizado = LeerFilas.GetDateTime(5),
                    Factura = LeerFilas.GetString(6)


                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarPresupuesto(E_Presupuestos Presupuesto)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTAPRESUPUESTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IdDepartamento", Presupuesto.IdDepartamento);
            cmd.Parameters.AddWithValue("@Presupuesto", Presupuesto.Presupuesto);
            cmd.Parameters.AddWithValue("@Nota", Presupuesto.Nota);
            cmd.Parameters.AddWithValue("@Fecha_Actualizado", Presupuesto.Fecha_actualizado);
            cmd.Parameters.AddWithValue("@Factura", Presupuesto.Factura);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarPresupuesto(E_Presupuestos Presupuesto)
        {
            SqlCommand cmd = new SqlCommand("SPEDITAPRESUPUESTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODPresupuesto", Presupuesto.CODPresupuesto);
            cmd.Parameters.AddWithValue("@IdDepartamento", Presupuesto.IdDepartamento);
            cmd.Parameters.AddWithValue("@Presupuesto", Presupuesto.Presupuesto);
            cmd.Parameters.AddWithValue("@Nota", Presupuesto.Nota);
            cmd.Parameters.AddWithValue("@Fecha_Actualizado", Presupuesto.Fecha_actualizado);
            cmd.Parameters.AddWithValue("@Factura", Presupuesto.Factura);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarPresupuesto(E_Presupuestos Presupuesto)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINAPRESUPUESTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODPresupuesto", Presupuesto.CODPresupuesto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
