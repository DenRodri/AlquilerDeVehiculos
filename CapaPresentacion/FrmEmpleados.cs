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
    public partial class FrmEmpleados : Form
    {
        private string idEmpleado;
        private bool Editarse = false;

        E_Empleados objEntidad = new E_Empleados();
        N_Empleados objNegocio = new N_Empleados();
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaEmpleados.Columns[0].Visible = false;
            tablaEmpleados.Columns[1].HeaderText = "Codigo de Empleado";
            tablaEmpleados.Columns[2].HeaderText = "Id de Usuario";
            tablaEmpleados.Columns[3].HeaderText = "Id de Departamento";
            tablaEmpleados.Columns[4].HeaderText = "Cedula";
            tablaEmpleados.Columns[5].HeaderText = "Nombre";
            tablaEmpleados.Columns[6].HeaderText = "Apellido";
            tablaEmpleados.Columns[7].HeaderText = "Telefono";
            tablaEmpleados.Columns[8].HeaderText = "Calle";
            tablaEmpleados.Columns[9].HeaderText = "Sector";
            tablaEmpleados.Columns[10].HeaderText = "Municipio";
            tablaEmpleados.Columns[11].HeaderText = "Provincia";
            tablaEmpleados.Columns[12].HeaderText = "Pais";
            tablaEmpleados.Columns[13].HeaderText = "Cargo";
            tablaEmpleados.Columns[14].HeaderText = "Fecha_Contrato";
            tablaEmpleados.Columns[15].HeaderText = "Fecha_Nacimiento";

            tablaEmpleados.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Empleados objNegocio = new N_Empleados();
            tablaEmpleados.DataSource = objNegocio.ListandoEmpleados(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtIdDepartamento.Text = "";
            txtNombre.Text = "";
            txtIdUsuario.Text = "";
            txtCedula.Text = "";
            txtApellido.Text = "";
            txtCodigo.Text = "";
            txtMunicipio.Text = "";
            txtPais.Text = "";
            txtSector.Text = "";
            txtProvincia.Text = "";
            txtTel.Text = "";
            txtCalle.Text = "";
            txtCargo.Text = "";
            tablaEmpleados.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaEmpleados.SelectedRows.Count > 0)
            {
                Editarse = true;
                idEmpleado = tablaEmpleados.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtIdUsuario.Text = tablaEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtIdDepartamento.Text = tablaEmpleados.CurrentRow.Cells[3].Value.ToString();
                txtCedula.Text = tablaEmpleados.CurrentRow.Cells[4].Value.ToString(); 
                txtNombre.Text = tablaEmpleados.CurrentRow.Cells[5].Value.ToString(); 
                txtApellido.Text = tablaEmpleados.CurrentRow.Cells[6].Value.ToString();
                txtTel.Text = tablaEmpleados.CurrentRow.Cells[7].Value.ToString();
                txtCalle.Text = tablaEmpleados.CurrentRow.Cells[8].Value.ToString();
                txtSector.Text = tablaEmpleados.CurrentRow.Cells[9].Value.ToString();
                txtMunicipio.Text = tablaEmpleados.CurrentRow.Cells[10].Value.ToString();
                txtProvincia.Text = tablaEmpleados.CurrentRow.Cells[11].Value.ToString();
                txtPais.Text = tablaEmpleados.CurrentRow.Cells[12].Value.ToString();
                txtCargo.Text = tablaEmpleados.CurrentRow.Cells[13].Value.ToString();
                DtpFecha_Contrato.Value = Convert.ToDateTime(tablaEmpleados.CurrentRow.Cells[14].Value.ToString());
                DtpFecha_Nacimiento.Value = Convert.ToDateTime(tablaEmpleados.CurrentRow.Cells[15].Value.ToString());
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
                    objEntidad.IdDepartamento = Convert.ToInt32(txtIdDepartamento.Text);
                    objEntidad.Cedula = txtCedula.Text;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Apellido = txtApellido.Text;
                    objEntidad.Telefono = txtTel.Text;
                    objEntidad.Calle = txtCalle.Text;
                    objEntidad.Sector = txtSector.Text;
                    objEntidad.Municipio = txtMunicipio.Text;
                    objEntidad.Provincia = txtProvincia.Text;
                    objEntidad.Pais = txtPais.Text;
                    objEntidad.Cargo = txtCargo.Text;
                    objEntidad.Contrato = DtpFecha_Contrato.Value.Date;
                    objEntidad.Fecha_nacimiento = DtpFecha_Nacimiento.Value.Date;

                    objNegocio.InsertandoEmpleados(objEntidad);

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
                    objEntidad.CODEmpleado = txtCodigo.Text;
                    objEntidad.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
                    objEntidad.IdDepartamento = Convert.ToInt32(txtIdDepartamento.Text);
                    objEntidad.Cedula = txtCedula.Text;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Apellido = txtApellido.Text;
                    objEntidad.Telefono = txtTel.Text;
                    objEntidad.Calle = txtCalle.Text;
                    objEntidad.Sector = txtSector.Text;
                    objEntidad.Municipio = txtMunicipio.Text;
                    objEntidad.Provincia = txtProvincia.Text;
                    objEntidad.Pais = txtPais.Text;
                    objEntidad.Cargo = txtCargo.Text;
                    objEntidad.Contrato = DtpFecha_Contrato.Value.Date;
                    objEntidad.Fecha_nacimiento = DtpFecha_Nacimiento.Value.Date;

                    objNegocio.EditandoEmpleado(objEntidad);

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
            if(tablaEmpleados.SelectedRows.Count > 0)
            {
                objEntidad.CODEmpleado = tablaEmpleados.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoEmpleado(objEntidad);

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
