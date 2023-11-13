using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Vehiculos
    {
        D_Vehiculos objDato = new D_Vehiculos();

        public List<E_Vehiculos>ListandoVehiculos(string buscar)
        {
            return objDato.ListarVehiculos(buscar);
        }
        
        public void InsertandoVehiculos(E_Vehiculos Vehiculo)
        {
            objDato.InsertarVehiculo(Vehiculo);
        }

        public void EditandoVehiculo(E_Vehiculos Vehiculo)
        {
            objDato.EditarVehiculo(Vehiculo);
        }

        public void EliminandoVehiculo(E_Vehiculos Vehiculo)
        {
            objDato.EliminarVehiculo(Vehiculo);
        }


    }
}
