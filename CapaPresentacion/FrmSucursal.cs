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
    public partial class FrmSucursal : Form
    {
        private string idSucursal;
        private bool Editarse = false;

        E_Sucursal objEntidad = new E_Sucursal();
        N_Sucursal objNegocio = new N_Sucursal();
        public FrmSucursal()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSucursal_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaSucursal.Columns[0].Visible = false;
            tablaSucursal.Columns[1].HeaderText = "Codigo de Sucursal";
            tablaSucursal.Columns[2].HeaderText = "Tipo";
            tablaSucursal.Columns[3].HeaderText = "Limite de Vehiculos";
            tablaSucursal.Columns[4].HeaderText = "Calle";
            tablaSucursal.Columns[5].HeaderText = "Sector";
            tablaSucursal.Columns[6].HeaderText = "Municipio";
            tablaSucursal.Columns[7].HeaderText = "Provincia";
            tablaSucursal.Columns[8].HeaderText = "Pais";
            tablaSucursal.Columns[9].HeaderText = "Metro cubico";

            tablaSucursal.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Sucursal objNegocio = new N_Sucursal();
            tablaSucursal.DataSource = objNegocio.ListandoSucursal(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtLimVeh.Text = "";
            txtSector.Text = "";
            txtCalle.Text = "";
            txtMunicipio.Text = "";
            txtCodigo.Text = "";
            txtPais.Text = "";
            txtProvincia.Text = "";
            txtM2.Text = "";
            tablaSucursal.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaSucursal.SelectedRows.Count > 0)
            {
                Editarse = true;
                idSucursal = tablaSucursal.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaSucursal.CurrentRow.Cells[1].Value.ToString();
                TipoCB.SelectedItem = tablaSucursal.CurrentRow.Cells[2].Value.ToString();
                txtLimVeh.Text = tablaSucursal.CurrentRow.Cells[3].Value.ToString();
                txtCalle.Text = tablaSucursal.CurrentRow.Cells[4].Value.ToString(); 
                txtSector.Text = tablaSucursal.CurrentRow.Cells[5].Value.ToString(); 
                txtMunicipio.Text = tablaSucursal.CurrentRow.Cells[6].Value.ToString();
                txtProvincia.Text = tablaSucursal.CurrentRow.Cells[7].Value.ToString(); 
                txtPais.Text = tablaSucursal.CurrentRow.Cells[8].Value.ToString(); 
                txtM2.Text = tablaSucursal.CurrentRow.Cells[9].Value.ToString();
                

                
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
                    objEntidad.Tipo = TipoCB.SelectedValue.ToString();
                    objEntidad.Limite_Vehiculos = Convert.ToInt32(txtLimVeh.Text);
                    objEntidad.Calle = txtCalle.Text;
                    objEntidad.Sector = txtSector.Text;
                    objEntidad.Municipio = txtMunicipio.Text;
                    objEntidad.Provincia = txtProvincia.Text;
                    objEntidad.Pais = txtProvincia.Text;
                    objEntidad.Metro_Cubico = Convert.ToInt32(txtPais.Text);

                    objNegocio.InsertandoSucursal(objEntidad);

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
                    objEntidad.CODSucursal = txtCodigo.Text;
                    objEntidad.Tipo = TipoCB.SelectedItem.ToString();
                    objEntidad.Limite_Vehiculos = Convert.ToInt32(txtLimVeh.Text);
                    objEntidad.Calle = txtCalle.Text;
                    objEntidad.Sector = txtSector.Text;
                    objEntidad.Municipio = txtMunicipio.Text;
                    objEntidad.Provincia = txtProvincia.Text;
                    objEntidad.Pais = txtProvincia.Text;
                    objEntidad.Metro_Cubico = Convert.ToInt32(txtPais.Text);

                    objNegocio.EditandoSucursal(objEntidad);

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
            if(tablaSucursal.SelectedRows.Count > 0)
            {
                objEntidad.CODSucursal = tablaSucursal.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoSucursal(objEntidad);

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
