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
    public partial class FrmTransacciones : Form
    {
        private string idTransaccione;
        private bool Editarse = false;

        E_Transacciones objEntidad = new E_Transacciones();
        N_Transacciones objNegocio = new N_Transacciones();
        public FrmTransacciones()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTransacciones_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaTransacciones.Columns[0].Visible = false;
            tablaTransacciones.Columns[1].HeaderText = "Codigo de Transaccione";
            tablaTransacciones.Columns[2].HeaderText = "Id de Factura";
            tablaTransacciones.Columns[3].HeaderText = "Id de Cliente";
            tablaTransacciones.Columns[4].HeaderText = "Monto";
            tablaTransacciones.Columns[5].HeaderText = "Fecha";

            tablaTransacciones.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Transacciones objNegocio = new N_Transacciones();
            tablaTransacciones.DataSource = objNegocio.ListandoTransacciones(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtIdClient.Text = "";
            txtIdFact.Text = "";
            txtMon.Text = "";
            tablaTransacciones.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaTransacciones.SelectedRows.Count > 0)
            {
                Editarse = true;
                idTransaccione = tablaTransacciones.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaTransacciones.CurrentRow.Cells[1].Value.ToString();
                txtIdFact.Text = tablaTransacciones.CurrentRow.Cells[2].Value.ToString();
                txtIdClient.Text = tablaTransacciones.CurrentRow.Cells[3].Value.ToString();
                txtMon.Text = tablaTransacciones.CurrentRow.Cells[4].Value.ToString(); 
                dtpFecha.Value = Convert.ToDateTime(tablaTransacciones.CurrentRow.Cells[6].Value.ToString());

                
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
                    objEntidad.IdFactura = Convert.ToInt32(txtIdFact.Text);
                    objEntidad.IdCliente = Convert.ToInt32(txtIdClient.Text);
                    objEntidad.Monto = Convert.ToInt32(txtMon.Text);
                    objEntidad.Fecha = dtpFecha.Value.Date;

                    objNegocio.InsertandoTransacciones(objEntidad);

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
                    objEntidad.CODTransaccion = txtCodigo.Text;
                    objEntidad.IdFactura = Convert.ToInt32(txtIdFact.Text);
                    objEntidad.IdCliente = Convert.ToInt32(txtIdClient.Text);
                    objEntidad.Monto = Convert.ToInt32(txtMon.Text);
                    objEntidad.Fecha = dtpFecha.Value.Date;

                    objNegocio.EditandoTransaccione(objEntidad);

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
            if(tablaTransacciones.SelectedRows.Count > 0)
            {
                objEntidad.CODTransaccion = tablaTransacciones.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoTransaccione(objEntidad);

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
