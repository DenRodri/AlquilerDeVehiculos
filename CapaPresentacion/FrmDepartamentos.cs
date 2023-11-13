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
    public partial class FrmDepartamentos : Form
    {
        private string idDepartamento;
        private bool Editarse = false;

        E_Departamentos objEntidad = new E_Departamentos();
        N_Departamentos objNegocio = new N_Departamentos();
        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaDepartamentos.Columns[0].Visible = false;
            tablaDepartamentos.Columns[1].HeaderText = "Codigo de departamento";
            tablaDepartamentos.Columns[2].HeaderText = "Nombre";
            tablaDepartamentos.Columns[3].HeaderText = "Telefono";
            tablaDepartamentos.Columns[4].HeaderText = "Descripcion";
            tablaDepartamentos.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Vehiculos objNegocio = new N_Vehiculos();
            tablaDepartamentos.DataSource = objNegocio.ListandoVehiculos(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            tablaDepartamentos.ClearSelection();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTel.Text = "";
            txtDescripcion.Text = "";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaDepartamentos.SelectedRows.Count > 0)
            {
                Editarse = true;
                idDepartamento = tablaDepartamentos.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaDepartamentos.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaDepartamentos.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = tablaDepartamentos.CurrentRow.Cells[3].Value.ToString();
                txtDescripcion.Text = tablaDepartamentos.CurrentRow.Cells[4].Value.ToString();

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
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Telefono = txtTel.Text;
                    objEntidad.Descripcion = txtDescripcion.Text;
                    objNegocio.InsertandoDepartamentos(objEntidad);

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
                    objEntidad.CODDepartamento = txtCodigo.Text;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Telefono = txtTel.Text;
                    objEntidad.Descripcion = txtDescripcion.Text;
                    objNegocio.EditandoDepartamento(objEntidad);

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
            if(tablaDepartamentos.SelectedRows.Count > 0)
            {
                objEntidad.CODDepartamento = tablaDepartamentos.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoDepartamento(objEntidad);

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
