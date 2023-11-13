using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Empleados
    {
        D_Empleados objDato = new D_Empleados();

        public List<E_Empleados>ListandoEmpleados(string buscar)
        {
            return objDato.ListarEmpleados(buscar);
        }
        
        public void InsertandoEmpleados(E_Empleados Empleado)
        {
            objDato.InsertarEmpleado(Empleado);
        }

        public void EditandoEmpleado(E_Empleados Empleado)
        {
            objDato.EditarEmpleado(Empleado);
        }

        public void EliminandoEmpleado(E_Empleados Empleado)
        {
            objDato.EliminarEmpleado(Empleado);
        }


    }
}
