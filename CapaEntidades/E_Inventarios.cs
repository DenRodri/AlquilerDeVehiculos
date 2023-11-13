using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Inventarios
    {
        private int _IdInventario;
        private string _CODInventario;
        private int _IdEmpleado_Creador;
        private string _Tipo;
        private string _Marca;
        private string _Modelo;
        private string _Version;
        private int _Año;
        private int _Cantidad;
        private int _Costo;

        public int IdInventario { get => _IdInventario; set => _IdInventario = value; }
        public string CODInventario { get => _CODInventario; set => _CODInventario = value; }
        public int IdEmpleado_Creador { get => _IdEmpleado_Creador; set => _IdEmpleado_Creador = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Version { get => _Version; set => _Version = value; }
        public int Año { get => _Año; set => _Año = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public int Costo { get => _Costo; set => _Costo = value; }
    }
}
