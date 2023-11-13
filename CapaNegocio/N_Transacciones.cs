using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Transacciones
    {
        D_Transacciones objDato = new D_Transacciones();

        public List<E_Transacciones>ListandoTransacciones(string buscar)
        {
            return objDato.ListarTransacciones(buscar);
        }
        
        public void InsertandoTransacciones(E_Transacciones Transaccione)
        {
            objDato.InsertarTransaccione(Transaccione);
        }

        public void EditandoTransaccione(E_Transacciones Transaccione)
        {
            objDato.EditarTransaccione(Transaccione);
        }

        public void EliminandoTransaccione(E_Transacciones Transaccione)
        {
            objDato.EliminarTransaccione(Transaccione);
        }


    }
}
