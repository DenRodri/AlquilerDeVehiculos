using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Clientes
    {
        D_Clientes objDato = new D_Clientes();

        public List<E_Clientes>ListandoClientes(string buscar)
        {
            return objDato.ListarClientes(buscar);
        }
        
        public void InsertandoClientes(E_Clientes Cliente)
        {
            objDato.InsertarCliente(Cliente);
        }

        public void EditandoCliente(E_Clientes Cliente)
        {
            objDato.EditarCliente(Cliente);
        }

        public void EliminandoCliente(E_Clientes Cliente)
        {
            objDato.EliminarCliente(Cliente);
        }


    }
}
