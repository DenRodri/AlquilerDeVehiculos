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
    public partial class FrmFacturas : Form
    {
        private string idFactura;
        private bool Editarse = false;

        E_Facturas objEntidad = new E_Facturas();
        N_Facturas objNegocio = new N_Facturas();
        public FrmFacturas()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaFacturas.Columns[0].Visible = false;
            tablaFacturas.Columns[1].HeaderText = "Codigo de Factura";
            tablaFacturas.Columns[2].HeaderText = "Id de Cita";
            tablaFacturas.Columns[3].HeaderText = "Nombre de Agencia";
            tablaFacturas.Columns[4].HeaderText = "RNC";
            tablaFacturas.Columns[5].HeaderText = "Fecha";
            tablaFacturas.Columns[6].HeaderText = "Total_Bruto";
            tablaFacturas.Columns[7].HeaderText = "ITEBIS";
            tablaFacturas.Columns[8].HeaderText = "Descuento";
            tablaFacturas.Columns[9].HeaderText = "Total_General";

            tablaFacturas.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Facturas objNegocio = new N_Facturas();
            tablaFacturas.DataSource = objNegocio.ListandoFacturas(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtNomAg.Text = "";
            txtITEBIS.Text = "";
            txtIdCita.Text = "";
            txtRNC.Text = "";
            txtDesc.Text = "";
            txtTotalG.Text = "";
            txtCodigo.Text = "";
            txtTotal_Bruto.Text = "";
            tablaFacturas.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaFacturas.SelectedRows.Count > 0)
            {
                Editarse = true;
                idFactura = tablaFacturas.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaFacturas.CurrentRow.Cells[1].Value.ToString();
                txtIdCita.Text = tablaFacturas.CurrentRow.Cells[2].Value.ToString();
                txtNomAg.Text = tablaFacturas.CurrentRow.Cells[3].Value.ToString();
                txtRNC.Text = tablaFacturas.CurrentRow.Cells[4].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(tablaFacturas.CurrentRow.Cells[5].Value.ToString());
                txtTotal_Bruto.Text = tablaFacturas.CurrentRow.Cells[6].Value.ToString();
                txtITEBIS.Text = tablaFacturas.CurrentRow.Cells[7].Value.ToString(); 
                txtDesc.Text = tablaFacturas.CurrentRow.Cells[8].Value.ToString();
                txtTotalG.Text = tablaFacturas.CurrentRow.Cells[9].Value.ToString();
                
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
                    objEntidad.Nombre_Agencia = txtNomAg.Text;
                    objEntidad.RNC = txtRNC.Text;
                    objEntidad.Fecha = dtpFecha.Value.Date;
                    objEntidad.Total_Bruto = Convert.ToInt32(txtTotal_Bruto.Text);
                    objEntidad.ITEBIS = Convert.ToInt32(txtITEBIS.Text);
                    objEntidad.Descuento = Convert.ToInt32(txtDesc.Text);
                    objEntidad.Total_General = Convert.ToInt32(txtTotalG.Text);

                    objNegocio.InsertandoFacturas(objEntidad);

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
                    objEntidad.CODFactura = txtCodigo.Text;
                    objEntidad.IdCita = Convert.ToInt32(txtIdCita.Text);
                    objEntidad.Nombre_Agencia = txtNomAg.Text;
                    objEntidad.RNC = txtRNC.Text;
                    objEntidad.Fecha = dtpFecha.Value.Date;
                    objEntidad.Total_Bruto = Convert.ToInt32(txtTotal_Bruto.Text);
                    objEntidad.ITEBIS = Convert.ToInt32(txtITEBIS.Text);
                    objEntidad.Descuento = Convert.ToInt32(txtDesc.Text);
                    objEntidad.Total_General = Convert.ToInt32(txtTotalG.Text);


                    objNegocio.EditandoFactura(objEntidad);

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
            if(tablaFacturas.SelectedRows.Count > 0)
            {
                objEntidad.CODFactura = tablaFacturas.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoFactura(objEntidad);

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
