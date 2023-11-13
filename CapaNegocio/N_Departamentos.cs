using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Departamentos
    {
        D_Departamentos objDato = new D_Departamentos();

        public List<E_Departamentos> ListandoDepartamentos(string buscar)
        {
            return objDato.ListarDepartamentos(buscar);
        }

        public void InsertandoDepartamentos(E_Departamentos Departamento)
        {
            objDato.InsertarDepartamento(Departamento);
        }

        public void EditandoDepartamento(E_Departamentos Departamento)
        {
            objDato.EditarDepartamento(Departamento);
        }

        public void EliminandoDepartamento(E_Departamentos Departamento)
        {
            objDato.EliminarDepartamento(Departamento);
        }


    }
}
