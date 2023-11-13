using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Fotos
    {
        private int _IdFoto;
        private string _CODFoto;
        private int _IdVehiculo;
        private string _Nombre;
        private string _Tipo_foto;
        private string _Link_Imagen;
        private DateTime _Fecha_Foto;

        public int IdFoto { get => _IdFoto; set => _IdFoto = value; }
        public string CODFoto { get => _CODFoto; set => _CODFoto = value; }
        public int IdVehiculo { get => _IdVehiculo; set => _IdVehiculo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Tipo_foto { get => _Tipo_foto; set => _Tipo_foto = value; }
        public string Link_Imagen { get => _Link_Imagen; set => _Link_Imagen = value; }
        public DateTime Fecha_Foto { get => _Fecha_Foto; set => _Fecha_Foto = value; }
    }
}
