using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Transacciones
    {
        private int _IdTransaccion;
        private string _CODTransaccion;
        private int _IdFactura;
        private int _IdCliente;
        private int _Monto;
        private DateTime _Fecha;

        public int IdTransaccion { get => _IdTransaccion; set => _IdTransaccion = value; }
        public string CODTransaccion { get => _CODTransaccion; set => _CODTransaccion = value; }
        public int IdFactura { get => _IdFactura; set => _IdFactura = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int Monto { get => _Monto; set => _Monto = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
    }
}
