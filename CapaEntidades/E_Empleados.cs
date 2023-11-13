using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Empleados
    {
        private int _IdEmpleado;
        private string _CODEmpleado;
        private int _IdUsuario;
        private int _IdDepartamento;
        private string _Cedula;
        private string _Nombre;
        private string _Apellido;
        private string _Telefono;
        private string _Calle;
        private string _Sector;
        private string _Municipio;
        private string _Provincia;
        private string _Pais;
        private string _Cargo;
        private DateTime _Contrato;
        private DateTime _Fecha_nacimiento;

        public int IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public string CODEmpleado { get => _CODEmpleado; set => _CODEmpleado = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdDepartamento { get => _IdDepartamento; set => _IdDepartamento = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Calle { get => _Calle; set => _Calle = value; }
        public string Sector { get => _Sector; set => _Sector = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public string Provincia { get => _Provincia; set => _Provincia = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public string Cargo { get => _Cargo; set => _Cargo = value; }
        public DateTime Contrato { get => _Contrato; set => _Contrato = value; }
        public DateTime Fecha_nacimiento { get => _Fecha_nacimiento; set => _Fecha_nacimiento = value; }
    }
}
