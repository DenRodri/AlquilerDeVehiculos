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
    public partial class FrmCitas : Form
    {
        private string idCita;
        private bool Editarse = false;

        E_Citas objEntidad = new E_Citas();
        N_Citas objNegocio = new N_Citas();
        public FrmCitas()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaCitas.Columns[0].Visible = false;
            tablaCitas.Columns[1].HeaderText = "Codigo de Cita";
            tablaCitas.Columns[2].HeaderText = "Id de Cliente";
            tablaCitas.Columns[3].HeaderText = "Id de Sucursal";
            tablaCitas.Columns[4].HeaderText = "Kilometraje";
            tablaCitas.Columns[5].HeaderText = "Garantia";
            tablaCitas.Columns[6].HeaderText = "Observaciones";
            tablaCitas.Columns[7].HeaderText = "Hecho_por";
            tablaCitas.Columns[8].HeaderText = "Id de Empleado";
            tablaCitas.Columns[9].HeaderText = "Id de Contacto";


            tablaCitas.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Citas objNegocio = new N_Citas();
            tablaCitas.DataSource = objNegocio.ListandoCitas(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtIdSucursal.Text = "";
            txtGarantia.Text = "";
            txtIdCliente.Text = "";
            txtKilometraje.Text = "";
            txtObservaciones.Text = "";
            txtIdContacto.Text = "";
            txtIdEmp.Text = "";
            tablaCitas.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaCitas.SelectedRows.Count > 0)
            {
                Editarse = true;
                idCita = tablaCitas.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaCitas.CurrentRow.Cells[1].Value.ToString();
                txtIdCliente.Text = tablaCitas.CurrentRow.Cells[2].Value.ToString();
                txtIdSucursal.Text = tablaCitas.CurrentRow.Cells[3].Value.ToString();
                txtKilometraje.Text = tablaCitas.CurrentRow.Cells[4].Value.ToString(); 
                txtGarantia.Text = tablaCitas.CurrentRow.Cells[5].Value.ToString(); 
                txtObservaciones.Text = tablaCitas.CurrentRow.Cells[6].Value.ToString();
                HechoPorCB.SelectedItem = tablaCitas.CurrentRow.Cells[7].Value.ToString();
                txtIdEmp.Text = tablaCitas.CurrentRow.Cells[8].Value.ToString(); 
                txtIdContacto.Text = tablaCitas.CurrentRow.Cells[9].Value.ToString(); 

                
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
                    objEntidad.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                    objEntidad.IdSucursal = Convert.ToInt32(txtIdSucursal.Text);
                    objEntidad.Kilometraje = Convert.ToInt32(txtKilometraje.Text);
                    objEntidad.Garantia = txtGarantia.Text;
                    objEntidad.Observaciones = txtObservaciones.Text;
                    objEntidad.Hecho_por = HechoPorCB.SelectedItem.ToString(); ;
                    objEntidad.IdEmpleado = Convert.ToInt32(txtIdEmp.Text);
                    objEntidad.IdContacto = Convert.ToInt32(txtIdContacto.Text);
                    

                    objNegocio.InsertandoCitas(objEntidad);

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
                    objEntidad.CODCita = txtCodigo.Text;
                    objEntidad.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                    objEntidad.IdSucursal = Convert.ToInt32(txtIdSucursal.Text);
                    objEntidad.Kilometraje = Convert.ToInt32(txtKilometraje.Text);
                    objEntidad.Garantia = txtGarantia.Text;
                    objEntidad.Observaciones = txtObservaciones.Text;
                    objEntidad.Hecho_por = HechoPorCB.SelectedItem.ToString(); ;
                    objEntidad.IdEmpleado = Convert.ToInt32(txtIdEmp.Text);
                    objEntidad.IdContacto = Convert.ToInt32(txtIdContacto.Text);

                    objNegocio.EditandoCita(objEntidad);

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
            if(tablaCitas.SelectedRows.Count > 0)
            {
                objEntidad.CODCita = tablaCitas.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoCita(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que deseas eliminar");
            }
        }

        private void HechoPorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HechoPorCB.SelectedValue.ToString() == "Sistema")
            {
                txtIdContacto.Text = "";
                txtIdContacto.ReadOnly = true;
            }
            else
            {
                txtIdContacto.ReadOnly = false;
            }
        }
    }
}
