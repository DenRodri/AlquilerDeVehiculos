using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Vehiculos
    {
        private int _IdVehiculo;
        private string _CODVehiculo;
        private int _IdInventario;
        private int _IdContacto;
        private int _IdSucursal;
        private int _IdEmpleado_Creador;
        private string _No_Chassis;
        private DateTime _Fecha_Comprado;
        private int _Monto_Compra;
        private string _Color;
        private string _Motor;
        private int _Millaje;
        private string _Transmision;
        private string _Traccion;
        private string _Combustion;
        public int IdVehiculo { get => _IdVehiculo; set => _IdVehiculo = value; }
        public string CODVehiculo { get => _CODVehiculo; set => _CODVehiculo = value; }
        public int IdInventario { get => _IdInventario; set => _IdInventario = value; }
        public int IdContacto { get => _IdContacto; set => _IdContacto = value; }
        public int IdSucursal { get => _IdSucursal; set => _IdSucursal = value; }
        public int IdEmpleado_Creador { get => _IdEmpleado_Creador; set => _IdEmpleado_Creador = value; }
        public string No_Chassis { get => _No_Chassis; set => _No_Chassis = value; }
        public DateTime Fecha_Comprado { get => _Fecha_Comprado; set => _Fecha_Comprado = value; }
        public int Monto_Compra { get => _Monto_Compra; set => _Monto_Compra = value; }
        public string Color { get => _Color; set => _Color = value; }
        public string Motor { get => _Motor; set => _Motor = value; }
        public int Millaje { get => _Millaje; set => _Millaje = value; }
        public string Transmision { get => _Transmision; set => _Transmision = value; }
        public string Traccion { get => _Traccion; set => _Traccion = value; }
        public string Combustion { get => _Combustion; set => _Combustion = value; }
        
    }
}
