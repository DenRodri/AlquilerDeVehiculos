using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FrmHub : Form
    {

        public FrmHub()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CitasBT_Click(object sender, EventArgs e)
        {
            FrmCitas FrmCit = new FrmCitas();
            FrmCit.Show();
        }

        private void ClientesBT_Click(object sender, EventArgs e)
        {
            FrmClientes FrmClien = new FrmClientes();
            FrmClien.Show();
        }

        private void ContactosBT_Click(object sender, EventArgs e)
        {
            FrmContactos FrmCont = new FrmContactos();
            FrmCont.Show();
        }

        private void DepartamentosBT_Click(object sender, EventArgs e)
        {
            FrmDepartamentos FrmDep = new FrmDepartamentos();
            FrmDep.Show();
        }

        private void EmpleadosBT_Click(object sender, EventArgs e)
        {
            FrmEmpleados FrmEmp = new FrmEmpleados();
            FrmEmp.Show();
        }

        private void EstadoBT_Click(object sender, EventArgs e)
        {
            FrmEstado_Vehiculos FrmEst = new FrmEstado_Vehiculos();
            FrmEst.Show();
        }

        private void FacturasBT_Click(object sender, EventArgs e)
        {
            FrmFacturas FrmFac = new FrmFacturas();
            FrmFac.Show();
        }

        private void FotosBT_Click(object sender, EventArgs e)
        {
            FrmFotos FrmFot = new FrmFotos();
            FrmFot.Show();
        }

        private void InventarioBT_Click(object sender, EventArgs e)
        {
            FrmInventarios FrmInv = new FrmInventarios();
            FrmInv.Show();
        }

        private void ReservasBT_Click(object sender, EventArgs e)
        {
            FrmOrdenes FrmOrd = new FrmOrdenes();
            FrmOrd.Show();
        }

        private void PresupuestosBT_Click(object sender, EventArgs e)
        {
            FrmPresupuestos FrmPres = new FrmPresupuestos();
            FrmPres.Show();
        }

        private void SucursalesBT_Click(object sender, EventArgs e)
        {
            FrmSucursal FrmSuc = new FrmSucursal();
            FrmSuc.Show();
        }

        private void TransaccionesBT_Click(object sender, EventArgs e)
        {
            FrmTransacciones FrmTra = new FrmTransacciones();
            FrmTra.Show();
        }

        private void UsuariosBT_Click(object sender, EventArgs e)
        {
            FrmUsuarios FrmUsu = new FrmUsuarios();
            FrmUsu.Show();
        }

        private void VehiculosBT_Click(object sender, EventArgs e)
        {
            FrmVehiculos FrmVeh = new FrmVehiculos();
            FrmVeh.Show();
        }
    }
}
