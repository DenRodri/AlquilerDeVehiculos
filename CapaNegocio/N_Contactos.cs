using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Contactos
    {
        D_Contactos objDato = new D_Contactos();

        public List<E_Contactos>ListandoContactos(string buscar)
        {
            return objDato.ListarContactos(buscar);
        }
        
        public void InsertandoContactos(E_Contactos Contacto)
        {
            objDato.InsertarContacto(Contacto);
        }

        public void EditandoContacto(E_Contactos Contacto)
        {
            objDato.EditarContacto(Contacto);
        }

        public void EliminandoContacto(E_Contactos Contacto)
        {
            objDato.EliminarContacto(Contacto);
        }


    }
}
