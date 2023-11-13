using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Inventarios
    {
        D_Inventarios objDato = new D_Inventarios();

        public List<E_Inventarios>ListandoInventarios(string buscar)
        {
            return objDato.ListarInventarios(buscar);
        }
        
        public void InsertandoInventarios(E_Inventarios Inventario)
        {
            objDato.InsertarInventario(Inventario);
        }

        public void EditandoInventario(E_Inventarios Inventario)
        {
            objDato.EditarInventario(Inventario);
        }

        public void EliminandoInventario(E_Inventarios Inventario)
        {
            objDato.EliminarInventario(Inventario);
        }


    }
}
