using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Clientes
    {
        private int _IdCliente;
        private string _CODCliente;
        private int _IdUsuario;
        private int _IdEmpleado_Creador;
        private string _Cedula;
        private string _Documento;
        private int _Documento_num;
        private string _Tarjeta_Credito;
        private string _Trato;
        private string _Nombre;
        private string _Apellido;
        private string _Telefono;
        private string _Calle;
        private string _Sector;
        private string _Municipio;
        private string _Provincia;
        private string _Pais;
        private DateTime _Fecha_nacimiento;
        private string _Foto_Link;
        private string _Tipo_Cliente;
        private string _Observacion;
        

        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public string CODCliente { get => _CODCliente; set => _CODCliente = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdEmpleado_Creador { get => _IdEmpleado_Creador; set => _IdEmpleado_Creador = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Trato { get => _Trato; set => _Trato = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Calle { get => _Calle; set => _Calle = value; }
        public string Sector { get => _Sector; set => _Sector = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public string Provincia { get => _Provincia; set => _Provincia = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public DateTime Fecha_nacimiento { get => _Fecha_nacimiento; set => _Fecha_nacimiento = value; }
        public string Foto_Link { get => _Foto_Link; set => _Foto_Link = value; }
        public string Tipo_Cliente { get => _Tipo_Cliente; set => _Tipo_Cliente = value; }
        public string Observacion { get => _Observacion; set => _Observacion = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public int Documento_num { get => _Documento_num; set => _Documento_num = value; }
        public string Tarjeta_Credito { get => _Tarjeta_Credito; set => _Tarjeta_Credito = value; }
    }
}
