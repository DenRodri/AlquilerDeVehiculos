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
    public class D_Contactos
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Contactos> ListarContactos(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SPMUESTRACONTACTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_Contactos> Listar = new List<E_Contactos>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Contactos
                {
                    IdContacto = LeerFilas.GetInt32(0),
                    CODContacto = LeerFilas.GetString(1),
                    Tipo = LeerFilas.GetString(2),
                    Nombre = LeerFilas.GetString(3),
                    RNC = LeerFilas.GetString(4),
                    Calle = LeerFilas.GetString(5),
                    Sector = LeerFilas.GetString(6),
                    Municipio = LeerFilas.GetString(7),
                    Provincia = LeerFilas.GetString(8),
                    Pais = LeerFilas.GetString(9),
                    Nombre_Persona = LeerFilas.GetString(10),
                    Cargo = LeerFilas.GetString(11)
                    

                });
                    
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        public void InsertarContacto(E_Contactos Contacto)
        {
            SqlCommand cmd = new SqlCommand("SPINSERTACONTACTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Tipo", Contacto.Tipo);
            cmd.Parameters.AddWithValue("@Nombre", Contacto.Nombre);
            cmd.Parameters.AddWithValue("@RNC", Contacto.RNC);
            cmd.Parameters.AddWithValue("@Calle", Contacto.Calle);
            cmd.Parameters.AddWithValue("@Sector", Contacto.Sector);
            cmd.Parameters.AddWithValue("@Municipio", Contacto.Municipio);
            cmd.Parameters.AddWithValue("@Provincia", Contacto.Provincia);
            cmd.Parameters.AddWithValue("@Pais", Contacto.Pais);
            cmd.Parameters.AddWithValue("@Nombre_Persona", Contacto.Nombre_Persona);
            cmd.Parameters.AddWithValue("@Cargo", Contacto.Cargo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarContacto(E_Contactos Contacto)
        {
            SqlCommand cmd = new SqlCommand("SPEDITACONTACTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODContacto", Contacto.CODContacto);
            cmd.Parameters.AddWithValue("@Tipo", Contacto.Tipo);
            cmd.Parameters.AddWithValue("@Nombre", Contacto.Nombre);
            cmd.Parameters.AddWithValue("@RNC", Contacto.RNC);
            cmd.Parameters.AddWithValue("@Calle", Contacto.Calle);
            cmd.Parameters.AddWithValue("@Sector", Contacto.Sector);
            cmd.Parameters.AddWithValue("@Municipio", Contacto.Municipio);
            cmd.Parameters.AddWithValue("@Provincia", Contacto.Provincia);
            cmd.Parameters.AddWithValue("@Pais", Contacto.Pais);
            cmd.Parameters.AddWithValue("@Nombre_Persona", Contacto.Nombre_Persona);
            cmd.Parameters.AddWithValue("@Cargo", Contacto.Cargo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarContacto(E_Contactos Contacto)
        {
            SqlCommand cmd = new SqlCommand("SPELIMINACONTACTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@CODContacto", Contacto.CODContacto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
