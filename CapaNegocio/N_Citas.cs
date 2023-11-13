using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Citas
    {
        D_Citas objDato = new D_Citas();

        public List<E_Citas>ListandoCitas(string buscar)
        {
            return objDato.ListarCitas(buscar);
        }
        
        public void InsertandoCitas(E_Citas Cita)
        {
            objDato.InsertarCita(Cita);
        }

        public void EditandoCita(E_Citas Cita)
        {
            objDato.EditarCita(Cita);
        }

        public void EliminandoCita(E_Citas Cita)
        {
            objDato.EliminarCita(Cita);
        }


    }
}
