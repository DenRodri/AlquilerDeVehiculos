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
    public partial class FrmPresupuestos : Form
    {
        private string idPresupuesto;
        private bool Editarse = false;

        E_Presupuestos objEntidad = new E_Presupuestos();
        N_Presupuestos objNegocio = new N_Presupuestos();
        public FrmPresupuestos()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPresupuestos_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaPresupuestos.Columns[0].Visible = false;
            tablaPresupuestos.Columns[1].HeaderText = "Codigo de Presupuestos";
            tablaPresupuestos.Columns[2].HeaderText = "Id de Departamento";
            tablaPresupuestos.Columns[3].HeaderText = "Id de Presupuesto";
            tablaPresupuestos.Columns[4].HeaderText = "Nota";
            tablaPresupuestos.Columns[5].HeaderText = "Fecha de actualizacion";
            tablaPresupuestos.Columns[6].HeaderText = "Factura";
            tablaPresupuestos.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Presupuestos objNegocio = new N_Presupuestos();
            tablaPresupuestos.DataSource = objNegocio.ListandoPresupuesto(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtPresupuesto.Text = "";
            txtIdDep.Text = "";
            txtNota.Text = "";
            txtFact.Text = "";

            tablaPresupuestos.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaPresupuestos.SelectedRows.Count > 0)
            {
                Editarse = true;
                idPresupuesto = tablaPresupuestos.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaPresupuestos.CurrentRow.Cells[1].Value.ToString();
                txtIdDep.Text = tablaPresupuestos.CurrentRow.Cells[2].Value.ToString();
                txtPresupuesto.Text = tablaPresupuestos.CurrentRow.Cells[3].Value.ToString();
                txtNota.Text = tablaPresupuestos.CurrentRow.Cells[4].Value.ToString();
                txtFact.Text = tablaPresupuestos.CurrentRow.Cells[6].Value.ToString();

                
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
                    objEntidad.IdDepartamento = Convert.ToInt32(txtIdDep.Text);
                    objEntidad.Presupuesto = Convert.ToInt32(txtPresupuesto.Text);
                    objEntidad.Fecha_actualizado = DateTime.Now;
                    objEntidad.Nota = txtNota.Text;
                    objEntidad.Factura = txtFact.Text;

                    objNegocio.InsertandoPresupuesto(objEntidad);

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
                    objEntidad.CODPresupuesto = txtCodigo.Text;
                    objEntidad.IdDepartamento = Convert.ToInt32(txtIdDep.Text);
                    objEntidad.Presupuesto = Convert.ToInt32(txtPresupuesto.Text);
                    objEntidad.Fecha_actualizado = DateTime.Now;
                    objEntidad.Nota = txtNota.Text;
                    objEntidad.Factura = txtFact.Text;

                    objNegocio.EditandoPresupuesto(objEntidad);

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
            if(tablaPresupuestos.SelectedRows.Count > 0)
            {
                objEntidad.CODPresupuesto = tablaPresupuestos.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoPresupuesto(objEntidad);

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
