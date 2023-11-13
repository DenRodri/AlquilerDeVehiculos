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
    public partial class FrmVehiculos : Form
    {
        private string idVehiculo;
        private bool Editarse = false;

        E_Vehiculos objEntidad = new E_Vehiculos();
        N_Vehiculos objNegocio = new N_Vehiculos();
        public FrmVehiculos()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaVehiculos.Columns[0].Visible = false;
            tablaVehiculos.Columns[1].HeaderText = "Codigo de Vehiculo";
            tablaVehiculos.Columns[2].HeaderText = "Id de Inventario";
            tablaVehiculos.Columns[3].HeaderText = "Id de Contacto";
            tablaVehiculos.Columns[4].HeaderText = "Id de Sucursal";
            tablaVehiculos.Columns[5].HeaderText = "Id de Empleado Creador";
            tablaVehiculos.Columns[6].HeaderText = "Numero de Chassis";
            tablaVehiculos.Columns[7].HeaderText = "Fecha de compra";
            tablaVehiculos.Columns[8].HeaderText = "Monto de compra";
            tablaVehiculos.Columns[9].HeaderText = "Color";
            tablaVehiculos.Columns[10].HeaderText = "Motor";
            tablaVehiculos.Columns[11].HeaderText = "Millaje";
            tablaVehiculos.Columns[12].HeaderText = "Transmision";
            tablaVehiculos.Columns[13].HeaderText = "Traccion";
            tablaVehiculos.Columns[14].HeaderText = "Combustion";

            tablaVehiculos.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Vehiculos objNegocio = new N_Vehiculos();
            tablaVehiculos.DataSource = objNegocio.ListandoVehiculos(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtIdCont.Text = "";
            txtIdEmp.Text = "";
            txtIdInv.Text = "";
            txtIdSuc.Text = "";
            txtChassis.Text = "";
            txtCodigo.Text = "";
            txtColor.Text = "";
            txtMillaje.Text = "";
            txtMonComp.Text = "";
            txtMotor.Text = "";
            tablaVehiculos.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaVehiculos.SelectedRows.Count > 0)
            {
                Editarse = true;
                idVehiculo = tablaVehiculos.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaVehiculos.CurrentRow.Cells[1].Value.ToString();
                txtIdInv.Text = tablaVehiculos.CurrentRow.Cells[2].Value.ToString();
                txtIdCont.Text = tablaVehiculos.CurrentRow.Cells[3].Value.ToString();
                txtIdSuc.Text = tablaVehiculos.CurrentRow.Cells[4].Value.ToString(); 
                txtIdEmp.Text = tablaVehiculos.CurrentRow.Cells[5].Value.ToString(); 
                txtChassis.Text = tablaVehiculos.CurrentRow.Cells[6].Value.ToString();
                dtpFecha_Compra.Value = Convert.ToDateTime(tablaVehiculos.CurrentRow.Cells[7].Value.ToString());
                txtMonComp.Text = tablaVehiculos.CurrentRow.Cells[8].Value.ToString(); 
                txtColor.Text = tablaVehiculos.CurrentRow.Cells[9].Value.ToString(); 
                txtMotor.Text = tablaVehiculos.CurrentRow.Cells[10].Value.ToString();
                txtMillaje.Text = tablaVehiculos.CurrentRow.Cells[11].Value.ToString();
                TransCB.SelectedItem = tablaVehiculos.CurrentRow.Cells[12].Value.ToString();
                TraccionCB.SelectedItem = tablaVehiculos.CurrentRow.Cells[13].Value.ToString();
                CombustionCB.SelectedItem = tablaVehiculos.CurrentRow.Cells[14].Value.ToString();

                
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Editarse == false)
            {
                try
                {
                    objEntidad.IdInventario = Convert.ToInt32(txtIdInv.Text);
                    objEntidad.IdContacto = Convert.ToInt32(txtIdCont.Text);
                    objEntidad.IdSucursal = Convert.ToInt32(txtIdSuc.Text);
                    objEntidad.IdEmpleado_Creador = Convert.ToInt32(txtIdEmp.Text);
                    objEntidad.No_Chassis = txtChassis.Text;
                    objEntidad.Fecha_Comprado = dtpFecha_Compra.Value.Date;
                    objEntidad.Monto_Compra = Convert.ToInt32(txtMonComp.Text);
                    objEntidad.Color = txtColor.Text;
                    objEntidad.Motor = txtMotor.Text;
                    objEntidad.Millaje = Convert.ToInt32(txtMillaje.Text);
                    objEntidad.Transmision = TransCB.SelectedItem.ToString();
                    objEntidad.Traccion = TraccionCB.SelectedItem.ToString();
                    objEntidad.Combustion = CombustionCB.SelectedItem.ToString();

                    objNegocio.InsertandoVehiculos(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    Editarse = false;


                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
            if(Editarse == true)
            {
                try
                {
                    objEntidad.CODVehiculo = txtCodigo.Text;
                    objEntidad.IdInventario = Convert.ToInt32(txtIdInv.Text);
                    objEntidad.IdContacto = Convert.ToInt32(txtIdCont.Text);
                    objEntidad.IdSucursal = Convert.ToInt32(txtIdSuc.Text);
                    objEntidad.IdEmpleado_Creador = Convert.ToInt32(txtIdEmp.Text);
                    objEntidad.No_Chassis = txtChassis.Text;
                    objEntidad.Fecha_Comprado = dtpFecha_Compra.Value.Date;
                    objEntidad.Monto_Compra = Convert.ToInt32(txtMonComp.Text);
                    objEntidad.Color = txtColor.Text;
                    objEntidad.Motor = txtMotor.Text;
                    objEntidad.Millaje = Convert.ToInt32(txtMillaje.Text);
                    objEntidad.Transmision = TransCB.SelectedItem.ToString();
                    objEntidad.Traccion = TraccionCB.SelectedItem.ToString();
                    objEntidad.Combustion = CombustionCB.SelectedItem.ToString();

                    objNegocio.EditandoVehiculo(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    mostrarBuscarTabla("");
                    limpiarCajas();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro" + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(tablaVehiculos.SelectedRows.Count > 0)
            {
                objEntidad.CODVehiculo = tablaVehiculos.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoVehiculo(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que deseas eliminar");
            }
        }
    }
}
