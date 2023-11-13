using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Sucursal
    {
        D_Sucursal objDato = new D_Sucursal();

        public List<E_Sucursal>ListandoSucursal(string buscar)
        {
            return objDato.ListarSucursal(buscar);
        }
        
        public void InsertandoSucursal(E_Sucursal Sucursal)
        {
            objDato.InsertarSucursal(Sucursal);
        }

        public void EditandoSucursal(E_Sucursal Sucursal)
        {
            objDato.EditarSucursal(Sucursal);
        }

        public void EliminandoSucursal(E_Sucursal Sucursal)
        {
            objDato.EliminarSucursal(Sucursal);
        }


    }
}
