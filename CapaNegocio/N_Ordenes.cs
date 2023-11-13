using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Ordenes
    {
        D_Ordenes objDato = new D_Ordenes();

        public List<E_Ordenes>ListandoOrdenes(string buscar)
        {
            return objDato.ListarOrdenes(buscar);
        }
        
        public void InsertandoOrdenes(E_Ordenes Orden)
        {
            objDato.InsertarOrden(Orden);
        }

        public void EditandoOrden(E_Ordenes Orden)
        {
            objDato.EditarOrden(Orden);
        }

        public void EliminandoOrden(E_Ordenes Orden)
        {
            objDato.EliminarOrden(Orden);
        }


    }
}
