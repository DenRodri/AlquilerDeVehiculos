using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Usuarios
    {
        D_Usuarios objDato = new D_Usuarios();

        public List<E_Usuarios>ListandoUsuarios(string buscar)
        {
            return objDato.ListarUsuarios(buscar);
        }
        
        public void InsertandoUsuarios(E_Usuarios Usuario)
        {
            objDato.InsertarUsuario(Usuario);
        }

        public void EditandoUsuario(E_Usuarios Usuario)
        {
            objDato.EditarUsuario(Usuario);
        }

        public void EliminandoUsuario(E_Usuarios Usuario)
        {
            objDato.EliminarUsuario(Usuario);
        }


    }
}
