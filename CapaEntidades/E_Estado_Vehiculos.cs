using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Estado_Vehiculos
    {
        private int _IdEstado;
        private string _CODEstado;
        private int _IdVehiculo;
        private int _IdEmpleado_Creador;
        private string _Nota;
        private string _Placa;
        private string _Matricula;
        private string _Combustible;
        private string _Lubricacion;
        private bool _En_Uso;
        private DateTime _Fecha_Ultima_Revision;
        private string _Revisado_Por;
        private int? _IdContacto;

        public int IdEstado { get => _IdEstado; set => _IdEstado = value; }
        public string CODEstado { get => _CODEstado; set => _CODEstado = value; }
        public int IdVehiculo { get => _IdVehiculo; set => _IdVehiculo = value; }
        public int IdEmpleado_Creador { get => _IdEmpleado_Creador; set => _IdEmpleado_Creador = value; }
        public string Nota { get => _Nota; set => _Nota = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string Matricula { get => _Matricula; set => _Matricula = value; }
        public string Combustible { get => _Combustible; set => _Combustible = value; }
        public string Lubricacion { get => _Lubricacion; set => _Lubricacion = value; }
        public bool En_Uso { get => _En_Uso; set => _En_Uso = value; }
        public DateTime Fecha_Ultima_Revision { get => _Fecha_Ultima_Revision; set => _Fecha_Ultima_Revision = value; }
        public string Revisado_Por { get => _Revisado_Por; set => _Revisado_Por = value; }
        public int? IdContacto { get => _IdContacto; set => _IdContacto = value; }
    }
}
