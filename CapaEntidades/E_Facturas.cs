using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Facturas
    {
        private int _IdFactura;
        private string _CODFactura;
        private int _IdCita;
        private string _Nombre_Agencia;
        private string _RNC;
        private DateTime _Fecha;
        private int _Total_Bruto;
        private int _ITEBIS;
        private int _Descuento;
        private int _Total_General;

        public int IdFactura { get => _IdFactura; set => _IdFactura = value; }
        public string CODFactura { get => _CODFactura; set => _CODFactura = value; }
        public int IdCita { get => _IdCita; set => _IdCita = value; }
        public string Nombre_Agencia { get => _Nombre_Agencia; set => _Nombre_Agencia = value; }
        public string RNC { get => _RNC; set => _RNC = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int Total_Bruto { get => _Total_Bruto; set => _Total_Bruto = value; }
        public int ITEBIS { get => _ITEBIS; set => _ITEBIS = value; }
        public int Descuento { get => _Descuento; set => _Descuento = value; }
        public int Total_General { get => _Total_General; set => _Total_General = value; }
     
    }
}
