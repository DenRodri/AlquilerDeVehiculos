using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Presupuestos
    {
        D_Presupuestos objDato = new D_Presupuestos();

        public List<E_Presupuestos>ListandoPresupuesto(string buscar)
        {
            return objDato.ListarPresupuestos(buscar);
        }
        
        public void InsertandoPresupuesto(E_Presupuestos Presupuesto)
        {
            objDato.InsertarPresupuesto(Presupuesto);
        }

        public void EditandoPresupuesto(E_Presupuestos Presupuesto)
        {
            objDato.EditarPresupuesto(Presupuesto);
        }

        public void EliminandoPresupuesto(E_Presupuestos Presupuesto)
        {
            objDato.EliminarPresupuesto(Presupuesto);
        }


    }
}
