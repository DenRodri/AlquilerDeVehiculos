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
    public partial class FrmEstado_Vehiculos : Form
    {
        private string idEstado_Vehiculo;
        private bool Editarse = false, uso=false;

        E_Estado_Vehiculos objEntidad = new E_Estado_Vehiculos();
        N_Estado_Vehiculos objNegocio = new N_Estado_Vehiculos();
        public FrmEstado_Vehiculos()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEstado_Vehiculos_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaEstado_Vehiculos.Columns[0].Visible = false;
            tablaEstado_Vehiculos.Columns[1].HeaderText = "Codigo de Estado de Vehiculo";
            tablaEstado_Vehiculos.Columns[2].HeaderText = "Id de Vehiculo";
            tablaEstado_Vehiculos.Columns[3].HeaderText = "Id de Empleado Creador";
            tablaEstado_Vehiculos.Columns[4].HeaderText = "Nota";
            tablaEstado_Vehiculos.Columns[5].HeaderText = "Placa";
            tablaEstado_Vehiculos.Columns[6].HeaderText = "Matricula";
            tablaEstado_Vehiculos.Columns[7].HeaderText = "Combustible";
            tablaEstado_Vehiculos.Columns[8].HeaderText = "Lubricacion";
            tablaEstado_Vehiculos.Columns[9].HeaderText = "En Uso";
            tablaEstado_Vehiculos.Columns[10].HeaderText = "Fecha de Ultima Revision";
            tablaEstado_Vehiculos.Columns[11].HeaderText = "Revisado por";
            tablaEstado_Vehiculos.Columns[12].HeaderText = "Id de Contacto";

            tablaEstado_Vehiculos.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Estado_Vehiculos objNegocio = new N_Estado_Vehiculos();
            tablaEstado_Vehiculos.DataSource = objNegocio.ListandoEstado_Vehiculos(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtIdEmp.Text = "";
            txtPlaca.Text = "";
            txtIdVeh.Text = "";
            txtNota.Text = "";
            txtMatricula.Text = "";
            txtIdContacto.Text = "";
            txtLubricacion.Text = "";

            tablaEstado_Vehiculos.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaEstado_Vehiculos.SelectedRows.Count > 0)
            {
                Editarse = true;
                idEstado_Vehiculo = tablaEstado_Vehiculos.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaEstado_Vehiculos.CurrentRow.Cells[1].Value.ToString();
                txtIdVeh.Text = tablaEstado_Vehiculos.CurrentRow.Cells[2].Value.ToString();
                txtIdEmp.Text = tablaEstado_Vehiculos.CurrentRow.Cells[3].Value.ToString();
                txtNota.Text = tablaEstado_Vehiculos.CurrentRow.Cells[4].Value.ToString(); 
                txtPlaca.Text = tablaEstado_Vehiculos.CurrentRow.Cells[5].Value.ToString(); 
                txtMatricula.Text = tablaEstado_Vehiculos.CurrentRow.Cells[6].Value.ToString();
                txtCombustible.Text = tablaEstado_Vehiculos.CurrentRow.Cells[7].Value.ToString();
                txtLubricacion.Text = tablaEstado_Vehiculos.CurrentRow.Cells[8].Value.ToString(); 
                RevisadoCB.SelectedValue = tablaEstado_Vehiculos.CurrentRow.Cells[11].Value.ToString();
                txtIdContacto.Text = tablaEstado_Vehiculos.CurrentRow.Cells[12].Value.ToString();


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
                    objEntidad.IdVehiculo = Convert.ToInt32(txtIdVeh.Text);
                    objEntidad.IdEmpleado_Creador = Convert.ToInt32(txtIdEmp.Text);
                    objEntidad.Nota = txtNota.Text;
                    objEntidad.Placa = txtPlaca.Text;
                    objEntidad.Matricula = txtMatricula.Text;
                    objEntidad.Combustible = txtCombustible.Text;
                    objEntidad.Lubricacion = txtLubricacion.Text;
                    objEntidad.En_Uso = uso;
                    objEntidad.Fecha_Ultima_Revision = DateTime.Now;
                    objEntidad.Revisado_Por = RevisadoCB.SelectedItem.ToString();
                    objEntidad.IdContacto = Convert.ToInt32(txtIdContacto.Text);
                    

                    objNegocio.InsertandoEstado_Vehiculos(objEntidad);

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
                    objEntidad.CODEstado = txtCodigo.Text;
                    objEntidad.IdVehiculo = Convert.ToInt32(txtIdVeh.Text);
                    objEntidad.IdEmpleado_Creador = Convert.ToInt32(txtIdEmp.Text);
                    objEntidad.Nota = txtNota.Text;
                    objEntidad.Placa = txtPlaca.Text;
                    objEntidad.Matricula = txtMatricula.Text;
                    objEntidad.Combustible = txtCombustible.Text;
                    objEntidad.Lubricacion = txtLubricacion.Text;
                    objEntidad.En_Uso = uso;
                    objEntidad.Fecha_Ultima_Revision = DateTime.Now;
                    objEntidad.Revisado_Por = RevisadoCB.SelectedItem.ToString();
                    objEntidad.IdContacto = Convert.ToInt32(txtIdContacto.Text);

                    objNegocio.EditandoEstado_Vehiculo(objEntidad);

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
            if(tablaEstado_Vehiculos.SelectedRows.Count > 0)
            {
                objEntidad.CODEstado = tablaEstado_Vehiculos.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoEstado_Vehiculo(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que deseas eliminar");
            }
        }

        private void TraccionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RevisadoCB.SelectedValue.ToString() == "Mantenimiento")
            {
                txtIdContacto.Text = "";
                txtIdContacto.ReadOnly = true;
            }
            else
            {
                txtIdContacto.ReadOnly = false;
            }
        }

        private void SiRBT_CheckedChanged(object sender, EventArgs e)
        {
            if(SiRBT.Checked == true)
            {
                uso = true;

            }
        }

        private void NoRBT_CheckedChanged(object sender, EventArgs e)
        {
            if (NoRBT.Checked == true)
            {
                uso = false;
            }
        }
    }
}
