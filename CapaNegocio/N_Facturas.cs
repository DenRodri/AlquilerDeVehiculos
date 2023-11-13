using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Facturas
    {
        D_Facturas objDato = new D_Facturas();

        public List<E_Facturas>ListandoFacturas(string buscar)
        {
            return objDato.ListarFacturas(buscar);
        }
        
        public void InsertandoFacturas(E_Facturas Factura)
        {
            objDato.InsertarFactura(Factura);
        }

        public void EditandoFactura(E_Facturas Factura)
        {
            objDato.EditarFactura(Factura);
        }

        public void EliminandoFactura(E_Facturas Factura)
        {
            objDato.EliminarFactura(Factura);
        }


    }
}
