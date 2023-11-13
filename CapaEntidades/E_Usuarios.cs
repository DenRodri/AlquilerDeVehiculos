using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Usuarios
    {
        private int _IdUsuario;
        private int _IdRol;
        private string _CODUsuario;
        private string _Nombre;
        private DateTime _Fecha_Creacion_Cuenta;
        private string _Password;
        private string _Email;
        private DateTime _Ultima_vez_ingresada;
        private bool _Online;
        private bool _Habilitado;

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public string CODUsuario { get => _CODUsuario; set => _CODUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public DateTime Fecha_Creacion_Cuenta { get => _Fecha_Creacion_Cuenta; set => _Fecha_Creacion_Cuenta = value; }
        public string Password { get => _Password; set => _Password = value; }
        public string Email { get => _Email; set => _Email = value; }
        public DateTime Ultima_vez_ingresada { get => _Ultima_vez_ingresada; set => _Ultima_vez_ingresada = value; }
        public bool Online { get => _Online; set => _Online = value; }
        public bool Habilitado { get => _Habilitado; set => _Habilitado = value; }
    }
}
