using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Departamentos
    {
        private int _IdDepartamento;
        private string _CODDepartamento;
        private string _Nombre;
        private string _Telefono;
        private string _Descripcion;
        public int IdDepartamento { get => _IdDepartamento; set => _IdDepartamento = value; }
        public string CODDepartamento { get => _CODDepartamento; set => _CODDepartamento = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
