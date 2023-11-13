using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Contactos
    {
        private int _IdContacto;
        private string _CODContacto;
        private string _Tipo;
        private string _Nombre;
        private string _RNC;
        private string _Calle;
        private string _Sector;
        private string _Municipio;
        private string _Provincia;
        private string _Pais;
        private string _Nombre_Persona;
        private string _Cargo;

        public int IdContacto { get => _IdContacto; set => _IdContacto = value; }
        public string CODContacto { get => _CODContacto; set => _CODContacto = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string RNC { get => _RNC; set => _RNC = value; }
        public string Calle { get => _Calle; set => _Calle = value; }
        public string Sector { get => _Sector; set => _Sector = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public string Provincia { get => _Provincia; set => _Provincia = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public string Nombre_Persona { get => _Nombre_Persona; set => _Nombre_Persona = value; }
        public string Cargo { get => _Cargo; set => _Cargo = value; }
    }
}
