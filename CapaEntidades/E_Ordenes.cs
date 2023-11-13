using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Ordenes
    {
        private int _IdCita;
        private int _IdVehiculo;
        private DateTime _Fecha_Entrega;
        private DateTime _Fecha_devolucion;
        private string _En_Proceso;
        private string _Utilidad;
        private string _MetodoPago;
        private int _Tarifa;
        private int _Total_Pag;
        private string _Num_Poliza;

        public int IdCita { get => _IdCita; set => _IdCita = value; }
        public int IdVehiculo { get => _IdVehiculo; set => _IdVehiculo = value; }
        public DateTime Fecha_Entrega { get => _Fecha_Entrega; set => _Fecha_Entrega = value; }
        public DateTime Fecha_devolucion { get => _Fecha_devolucion; set => _Fecha_devolucion = value; }
        public string En_Proceso { get => _En_Proceso; set => _En_Proceso = value; }
        public string Utilidad { get => _Utilidad; set => _Utilidad = value; }
        public string MetodoPago { get => _MetodoPago; set => _MetodoPago = value; }
        public int Tarifa { get => _Tarifa; set => _Tarifa = value; }
        public int Total_Pag { get => _Total_Pag; set => _Total_Pag = value; }
        public string Num_Poliza { get => _Num_Poliza; set => _Num_Poliza = value; }
       
    }
}
