using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Sucursal
    {
        private int _IdSucursal;
        private string _CODSucursal;
        private string _Tipo;
        private int _Limite_Vehiculos;
        private string _Calle;
        private string _Sector;
        private string _Municipio;
        private string _Provincia;
        private string _Pais;
        private int _Metro_Cubico;

        public int IdSucursal { get => _IdSucursal; set => _IdSucursal = value; }
        public string CODSucursal { get => _CODSucursal; set => _CODSucursal = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public int Limite_Vehiculos { get => _Limite_Vehiculos; set => _Limite_Vehiculos = value; }
        public string Calle { get => _Calle; set => _Calle = value; }
        public string Sector { get => _Sector; set => _Sector = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public string Provincia { get => _Provincia; set => _Provincia = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public int Metro_Cubico { get => _Metro_Cubico; set => _Metro_Cubico = value; }
    }
}
