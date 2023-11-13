using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Fotos
    {
        D_Fotos objDato = new D_Fotos();

        public List<E_Fotos>ListandoFotos(string buscar)
        {
            return objDato.ListarFotos(buscar);
        }
        
        public void InsertandoFotos(E_Fotos Foto)
        {
            objDato.InsertarFoto(Foto);
        }

        public void EditandoFoto(E_Fotos Foto)
        {
            objDato.EditarFoto(Foto);
        }

        public void EliminandoFoto(E_Fotos Foto)
        {
            objDato.EliminarFoto(Foto);
        }


    }
}
