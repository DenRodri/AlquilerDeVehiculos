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
    public partial class FrmOrdenes : Form
    {
        private int IdCita, IdVehiculo;
        private bool Editarse = false;

        E_Ordenes objEntidad = new E_Ordenes();
        N_Ordenes objNegocio = new N_Ordenes();
        public FrmOrdenes()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaOrdenes.Columns[0].HeaderText = "Id de Cita";
            tablaOrdenes.Columns[1].HeaderText = "Id de Vehiculo";
            tablaOrdenes.Columns[2].HeaderText = "Fecha de Entrega";
            tablaOrdenes.Columns[3].HeaderText = "Fecha de devolucion";
            tablaOrdenes.Columns[4].HeaderText = "En_Proceso";
            tablaOrdenes.Columns[5].HeaderText = "Utilidad";
            tablaOrdenes.Columns[6].HeaderText = "Metodo de Pago";
            tablaOrdenes.Columns[7].HeaderText = "Tarifa";
            tablaOrdenes.Columns[8].HeaderText = "Total Pagado";
            tablaOrdenes.Columns[9].HeaderText = "Numero de Poliza";


            tablaOrdenes.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Ordenes objNegocio = new N_Ordenes();
            tablaOrdenes.DataSource = objNegocio.ListandoOrdenes(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtIdCita.Text = "";
            txtEnProc.Text = "";
            txtMetPag.Text = "";
            txtUtil.Text = "";
            txtTarifa.Text = "";
            txtIdVehiculo.Text = "";
            txtTotalPag.Text = "";
            txtNumPol.Text = "";
            tablaOrdenes.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaOrdenes.SelectedRows.Count > 0)
            {
                Editarse = true;
                txtIdCita.Text = tablaOrdenes.CurrentRow.Cells[0].Value.ToString();
                txtIdVehiculo.Text = tablaOrdenes.CurrentRow.Cells[1].Value.ToString();
                dtpFecha_Entrega.Value = Convert.ToDateTime(tablaOrdenes.CurrentRow.Cells[2].Value.ToString());
                dtpFecha_devolucion.Value = Convert.ToDateTime(tablaOrdenes.CurrentRow.Cells[3].Value.ToString());
                txtEnProc.Text = tablaOrdenes.CurrentRow.Cells[4].Value.ToString();
                txtUtil.Text = tablaOrdenes.CurrentRow.Cells[5].Value.ToString(); 
                txtMetPag.Text = tablaOrdenes.CurrentRow.Cells[6].Value.ToString(); 
                txtTarifa.Text = tablaOrdenes.CurrentRow.Cells[7].Value.ToString();
                txtTotalPag.Text = tablaOrdenes.CurrentRow.Cells[8].Value.ToString(); 
                txtNumPol.Text = tablaOrdenes.CurrentRow.Cells[9].Value.ToString();
               

                
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
                    objEntidad.IdCita = Convert.ToInt32(txtIdCita.Text);
                    objEntidad.IdVehiculo = Convert.ToInt32(txtIdVehiculo.Text);
                    objEntidad.Fecha_Entrega = dtpFecha_Entrega.Value.Date;
                    objEntidad.Fecha_devolucion = dtpFecha_devolucion.Value.Date;
                    objEntidad.En_Proceso = txtEnProc.Text;
                    objEntidad.Utilidad = txtUtil.Text;
                    objEntidad.MetodoPago = txtMetPag.Text;
                    objEntidad.Tarifa = Convert.ToInt32(txtTarifa.Text);
                    objEntidad.Total_Pag = Convert.ToInt32(txtTotalPag.Text);
                    objEntidad.Num_Poliza = txtNumPol.Text;


                    objNegocio.InsertandoOrdenes(objEntidad);

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
                    objEntidad.IdCita = Convert.ToInt32(txtIdCita.Text);
                    objEntidad.IdVehiculo = Convert.ToInt32(txtIdVehiculo.Text);
                    objEntidad.Fecha_Entrega = dtpFecha_Entrega.Value.Date;
                    objEntidad.Fecha_devolucion = dtpFecha_devolucion.Value.Date;
                    objEntidad.En_Proceso = txtEnProc.Text;
                    objEntidad.Utilidad = txtUtil.Text;
                    objEntidad.MetodoPago = txtMetPag.Text;
                    objEntidad.Tarifa = Convert.ToInt32(txtTarifa.Text);
                    objEntidad.Total_Pag = Convert.ToInt32(txtTotalPag.Text);
                    objEntidad.Num_Poliza = txtNumPol.Text;

                    objNegocio.EditandoOrden(objEntidad);

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
            if(tablaOrdenes.SelectedRows.Count > 0)
            {
                objEntidad.Num_Poliza = tablaOrdenes.CurrentRow.Cells[9].Value.ToString();
                objNegocio.EliminandoOrden(objEntidad);

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
