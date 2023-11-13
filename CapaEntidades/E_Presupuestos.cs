using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Presupuestos
    {
        private int _IdPresupuesto;
        private string _CODPresupuesto;
        private int _IdDepartamento;
        private int _Presupuesto;
        private string _Nota;
        private DateTime _Fecha_actualizado;
        private string _Factura;

        public int IdPresupuesto { get => _IdPresupuesto; set => _IdPresupuesto = value; }
        public string CODPresupuesto { get => _CODPresupuesto; set => _CODPresupuesto = value; }
        public int IdDepartamento { get => _IdDepartamento; set => _IdDepartamento = value; }
        public int Presupuesto { get => _Presupuesto; set => _Presupuesto = value; }
        public string Nota { get => _Nota; set => _Nota = value; }
        public DateTime Fecha_actualizado { get => _Fecha_actualizado; set => _Fecha_actualizado = value; }
        public string Factura { get => _Factura; set => _Factura = value; }
    }
}
