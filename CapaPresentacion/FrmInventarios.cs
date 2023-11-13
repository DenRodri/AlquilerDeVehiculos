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
    public partial class FrmInventarios : Form
    {
        private string idInventario;
        private bool Editarse = false;

        E_Inventarios objEntidad = new E_Inventarios();
        N_Inventarios objNegocio = new N_Inventarios();
        public FrmInventarios()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmInventarios_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaInventarios.Columns[0].Visible = false;
            tablaInventarios.Columns[1].HeaderText = "Codigo de Inventario";
            tablaInventarios.Columns[2].HeaderText = "Id de Empleado creador";
            tablaInventarios.Columns[3].HeaderText = "Tipo";
            tablaInventarios.Columns[4].HeaderText = "Marca";
            tablaInventarios.Columns[5].HeaderText = "Modelo";
            tablaInventarios.Columns[6].HeaderText = "Version";
            tablaInventarios.Columns[7].HeaderText = "Año";
            tablaInventarios.Columns[8].HeaderText = "Cantidad";
            tablaInventarios.Columns[9].HeaderText = "Costo";

            tablaInventarios.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Inventarios objNegocio = new N_Inventarios();
            tablaInventarios.DataSource = objNegocio.ListandoInventarios(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtTipo.Text = "";
            txtModelo.Text = "";
            txtIdEmpleado.Text = "";
            txtMarca.Text = "";
            txtVersion.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtYear.Text = "";
            txtCosto.Text = "";
            tablaInventarios.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaInventarios.SelectedRows.Count > 0)
            {
                Editarse = true;
                idInventario = tablaInventarios.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaInventarios.CurrentRow.Cells[1].Value.ToString();
                txtIdEmpleado.Text = tablaInventarios.CurrentRow.Cells[2].Value.ToString();
                txtTipo.Text = tablaInventarios.CurrentRow.Cells[3].Value.ToString();
                txtMarca.Text = tablaInventarios.CurrentRow.Cells[4].Value.ToString(); 
                txtModelo.Text = tablaInventarios.CurrentRow.Cells[5].Value.ToString(); 
                txtVersion.Text = tablaInventarios.CurrentRow.Cells[6].Value.ToString();
                txtYear.Text = tablaInventarios.CurrentRow.Cells[7].Value.ToString(); 
                txtCantidad.Text = tablaInventarios.CurrentRow.Cells[8].Value.ToString(); 
                txtCosto.Text = tablaInventarios.CurrentRow.Cells[9].Value.ToString();
                

                
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
                    objEntidad.IdEmpleado_Creador = Convert.ToInt32(txtIdEmpleado.Text);
                    objEntidad.Tipo = txtTipo.Text;
                    objEntidad.Marca = txtMarca.Text;
                    objEntidad.Modelo = txtModelo.Text;
                    objEntidad.Version = txtVersion.Text;
                    objEntidad.Año = Convert.ToInt32(txtYear.Text);
                    objEntidad.Cantidad = Convert.ToInt32(txtYear.Text);
                    objEntidad.Costo = Convert.ToInt32(txtCantidad.Text);
                   

                    objNegocio.InsertandoInventarios(objEntidad);

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
                    objEntidad.CODInventario = txtCodigo.Text;
                    objEntidad.IdEmpleado_Creador = Convert.ToInt32(txtIdEmpleado.Text);
                    objEntidad.Tipo = txtTipo.Text;
                    objEntidad.Marca = txtMarca.Text;
                    objEntidad.Modelo = txtModelo.Text;
                    objEntidad.Version = txtVersion.Text;
                    objEntidad.Año = Convert.ToInt32(txtYear.Text);
                    objEntidad.Cantidad = Convert.ToInt32(txtYear.Text);
                    objEntidad.Costo = Convert.ToInt32(txtCantidad.Text);
                    objNegocio.EditandoInventario(objEntidad);

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
            if(tablaInventarios.SelectedRows.Count > 0)
            {
                objEntidad.CODInventario = tablaInventarios.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoInventario(objEntidad);

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
