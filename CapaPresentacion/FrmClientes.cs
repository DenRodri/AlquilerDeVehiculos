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
    public partial class FrmClientes : Form
    {
        private string idCliente;
        private bool Editarse = false;

        E_Clientes objEntidad = new E_Clientes();
        N_Clientes objNegocio = new N_Clientes();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaClientes.Columns[0].Visible = false;
            tablaClientes.Columns[1].HeaderText = "Codigo de Cliente";
            tablaClientes.Columns[2].HeaderText = "Id de Usuario";
            tablaClientes.Columns[3].HeaderText = "Id de Empleado Creador";
            tablaClientes.Columns[4].HeaderText = "Cedula";
            tablaClientes.Columns[5].HeaderText = "Trato";
            tablaClientes.Columns[6].HeaderText = "Nombre";
            tablaClientes.Columns[7].HeaderText = "Apellido";
            tablaClientes.Columns[8].HeaderText = "Telefono";
            tablaClientes.Columns[9].HeaderText = "Calle";
            tablaClientes.Columns[10].HeaderText = "Sector";
            tablaClientes.Columns[11].HeaderText = "Municipio";
            tablaClientes.Columns[12].HeaderText = "Provincia";
            tablaClientes.Columns[13].HeaderText = "Pais";
            tablaClientes.Columns[14].HeaderText = "Fecha de nacimiento";
            tablaClientes.Columns[15].HeaderText = "Link de foto";
            tablaClientes.Columns[16].HeaderText = "Tipo de cliente";
            tablaClientes.Columns[17].HeaderText = "Observacion";
            tablaClientes.Columns[18].HeaderText = "Documento";
            tablaClientes.Columns[19].HeaderText = "Numero de Documento";
            tablaClientes.Columns[20].HeaderText = "Tarjeta de credito";
            tablaClientes.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Clientes objNegocio = new N_Clientes();
            tablaClientes.DataSource = objNegocio.ListandoClientes(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtIdEmpleado.Text = "";
            txtTrato.Text = "";
            txtIdUsuario.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtCalle.Text = "";
            txtApellido.Text = "";
            txtMunicipio.Text = "";
            txtProvincia.Text = "";
            txtPais.Text = "";
            txtLink.Text = "";
            txtTipoCliente.Text = "";
            txtObservacion.Text = "";
            txtNumDoc.Text = "";
            txtTel.Text = "";
            txtTarjeta.Text = "";
            txtSect.Text = "";
            tablaClientes.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaClientes.SelectedRows.Count > 0)
            {
                Editarse = true;
                idCliente = tablaClientes.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaClientes.CurrentRow.Cells[1].Value.ToString();
                txtIdUsuario.Text = tablaClientes.CurrentRow.Cells[2].Value.ToString();
                txtIdEmpleado.Text = tablaClientes.CurrentRow.Cells[3].Value.ToString();
                txtCedula.Text = tablaClientes.CurrentRow.Cells[4].Value.ToString(); 
                txtTrato.Text = tablaClientes.CurrentRow.Cells[5].Value.ToString(); 
                txtNombre.Text = tablaClientes.CurrentRow.Cells[6].Value.ToString();
                txtApellido.Text = tablaClientes.CurrentRow.Cells[7].Value.ToString();
                txtTel.Text = tablaClientes.CurrentRow.Cells[8].Value.ToString(); 
                txtCalle.Text = tablaClientes.CurrentRow.Cells[9].Value.ToString(); 
                txtSect.Text = tablaClientes.CurrentRow.Cells[10].Value.ToString();
                txtMunicipio.Text = tablaClientes.CurrentRow.Cells[11].Value.ToString();
                txtProvincia.Text = tablaClientes.CurrentRow.Cells[12].Value.ToString();
                txtPais.Text = tablaClientes.CurrentRow.Cells[13].Value.ToString();
                dtpFecha_Nacimiento.Value = Convert.ToDateTime(tablaClientes.CurrentRow.Cells[14].Value.ToString());
                txtLink.Text = tablaClientes.CurrentRow.Cells[15].Value.ToString();
                txtTipoCliente.Text = tablaClientes.CurrentRow.Cells[16].Value.ToString();
                txtObservacion.Text = tablaClientes.CurrentRow.Cells[17].Value.ToString();
                DocumentoCB.SelectedItem = tablaClientes.CurrentRow.Cells[18].Value.ToString();
                txtNumDoc.Text = tablaClientes.CurrentRow.Cells[19].Value.ToString();
                txtTarjeta.Text = tablaClientes.CurrentRow.Cells[20].Value.ToString();
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
                    objEntidad.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
                    objEntidad.IdEmpleado_Creador = Convert.ToInt32(txtIdEmpleado.Text);
                    objEntidad.Cedula = txtCedula.Text;
                    objEntidad.Trato = txtTrato.Text;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Apellido = txtApellido.Text;
                    objEntidad.Telefono = txtTel.Text;
                    objEntidad.Calle = txtCalle.Text;
                    objEntidad.Sector = txtSect.Text;
                    objEntidad.Municipio = txtMunicipio.Text;
                    objEntidad.Provincia = txtProvincia.Text;
                    objEntidad.Pais = txtPais.Text;
                    objEntidad.Fecha_nacimiento = dtpFecha_Nacimiento.Value.Date;
                    objEntidad.Foto_Link = txtLink.Text;
                    objEntidad.Tipo_Cliente = txtTipoCliente.Text;
                    objEntidad.Observacion = txtObservacion.Text;
                    objEntidad.Documento = DocumentoCB.SelectedItem.ToString();
                    objEntidad.Documento_num = Convert.ToInt32(txtNumDoc.Text);
                    objEntidad.Tarjeta_Credito = txtTarjeta.Text;

                    objNegocio.InsertandoClientes(objEntidad);

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
                    objEntidad.CODCliente = txtCodigo.Text;
                    objEntidad.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
                    objEntidad.IdEmpleado_Creador = Convert.ToInt32(txtIdEmpleado.Text);
                    objEntidad.Cedula = txtCedula.Text;
                    objEntidad.Trato = txtTrato.Text;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Apellido = txtApellido.Text;
                    objEntidad.Telefono = txtTel.Text;
                    objEntidad.Calle = txtCalle.Text;
                    objEntidad.Sector = txtSect.Text;
                    objEntidad.Municipio = txtMunicipio.Text;
                    objEntidad.Provincia = txtProvincia.Text;
                    objEntidad.Pais = txtPais.Text;
                    objEntidad.Fecha_nacimiento = dtpFecha_Nacimiento.Value.Date;
                    objEntidad.Foto_Link = txtLink.Text;
                    objEntidad.Tipo_Cliente = txtTipoCliente.Text;
                    objEntidad.Observacion = txtObservacion.Text;
                    objEntidad.Documento = DocumentoCB.SelectedItem.ToString();
                    objEntidad.Documento_num = Convert.ToInt32(txtNumDoc.Text);
                    objEntidad.Tarjeta_Credito = txtTarjeta.Text;

                    objNegocio.EditandoCliente(objEntidad);

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
            if(tablaClientes.SelectedRows.Count > 0)
            {
                objEntidad.CODCliente = tablaClientes.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoCliente(objEntidad);

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
