using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Estado_Vehiculos
    {
        D_Estado_Vehiculos objDato = new D_Estado_Vehiculos();

        public List<E_Estado_Vehiculos>ListandoEstado_Vehiculos(string buscar)
        {
            return objDato.ListarEstado_Vehiculos(buscar);
        }
        
        public void InsertandoEstado_Vehiculos(E_Estado_Vehiculos Estado_Vehiculo)
        {
            objDato.InsertarEstado_Vehiculo(Estado_Vehiculo);
        }

        public void EditandoEstado_Vehiculo(E_Estado_Vehiculos Estado_Vehiculo)
        {
            objDato.EditarEstado_Vehiculo(Estado_Vehiculo);
        }

        public void EliminandoEstado_Vehiculo(E_Estado_Vehiculos Estado_Vehiculo)
        {
            objDato.EliminarEstado_Vehiculo(Estado_Vehiculo);
        }


    }
}
