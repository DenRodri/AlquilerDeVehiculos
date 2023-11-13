using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Citas
    {
        private int _IdCita;
        private string _CODCita;
        private int _IdCliente;
        private int _IdSucursal;
        private int _Kilometraje;
        private string _Garantia;
        private string _Observaciones;
        private string _Hecho_por;
        private int _IdEmpleado;
        private int? _IdContacto;

        public int IdCita { get => _IdCita; set => _IdCita = value; }
        public string CODCita { get => _CODCita; set => _CODCita = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int IdSucursal { get => _IdSucursal; set => _IdSucursal = value; }
        public int Kilometraje { get => _Kilometraje; set => _Kilometraje = value; }
        public string Garantia { get => _Garantia; set => _Garantia = value; }
        public string Observaciones { get => _Observaciones; set => _Observaciones = value; }
        public string Hecho_por { get => _Hecho_por; set => _Hecho_por = value; }
        public int IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public int? IdContacto { get => _IdContacto; set => _IdContacto = value; }
    }
}
