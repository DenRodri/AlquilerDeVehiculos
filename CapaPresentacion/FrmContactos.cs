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
    public partial class FrmContactos : Form
    {
        private string idContacto;
        private bool Editarse = false;

        E_Contactos objEntidad = new E_Contactos();
        N_Contactos objNegocio = new N_Contactos();
        public FrmContactos()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmContactos_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaContactos.Columns[0].Visible = false;
            tablaContactos.Columns[1].HeaderText = "Codigo de Contacto";
            tablaContactos.Columns[2].HeaderText = "Tipo";
            tablaContactos.Columns[3].HeaderText = "Nombre";
            tablaContactos.Columns[4].HeaderText = "RNC";
            tablaContactos.Columns[5].HeaderText = "Calle";
            tablaContactos.Columns[6].HeaderText = "Sector";
            tablaContactos.Columns[7].HeaderText = "Municipio";
            tablaContactos.Columns[8].HeaderText = "Provincia";
            tablaContactos.Columns[9].HeaderText = "Pais";
            tablaContactos.Columns[10].HeaderText = "Nombre de la persona";
            tablaContactos.Columns[11].HeaderText = "Cargo";

            tablaContactos.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Contactos objNegocio = new N_Contactos();
            tablaContactos.DataSource = objNegocio.ListandoContactos(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCalle.Text = "";
            txtTipo.Text = "";
            txtRNC.Text = "";
            txtProv.Text = "";
            txtSector.Text = "";
            txtCodigo.Text = "";
            txtNomPer.Text = "";
            txtMunicipio.Text = "";
            txtPais.Text = "";
            txtCargo.Text = "";
            tablaContactos.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaContactos.SelectedRows.Count > 0)
            {
                Editarse = true;
                idContacto = tablaContactos.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaContactos.CurrentRow.Cells[1].Value.ToString();
                txtTipo.Text = tablaContactos.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = tablaContactos.CurrentRow.Cells[3].Value.ToString();
                txtRNC.Text = tablaContactos.CurrentRow.Cells[4].Value.ToString(); 
                txtCalle.Text = tablaContactos.CurrentRow.Cells[5].Value.ToString(); 
                txtSector.Text = tablaContactos.CurrentRow.Cells[6].Value.ToString();
                txtProv.Text = tablaContactos.CurrentRow.Cells[7].Value.ToString();
                txtPais.Text = tablaContactos.CurrentRow.Cells[8].Value.ToString(); 
                txtNomPer.Text = tablaContactos.CurrentRow.Cells[9].Value.ToString(); 
                txtCargo.Text = tablaContactos.CurrentRow.Cells[10].Value.ToString();
                txtMunicipio.Text = tablaContactos.CurrentRow.Cells[11].Value.ToString(); 

                
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
                    objEntidad.Tipo = txtTipo.Text;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.RNC = txtRNC.Text;
                    objEntidad.Calle = txtCalle.Text;
                    objEntidad.Sector = txtSector.Text;
                    objEntidad.Provincia = txtProv.Text;
                    objEntidad.Pais = txtPais.Text;
                    objEntidad.Nombre_Persona = txtNomPer.Text;
                    objEntidad.Cargo = txtCargo.Text;
                    objEntidad.Municipio = txtMunicipio.Text;

                    objNegocio.InsertandoContactos(objEntidad);

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
                    objEntidad.CODContacto = txtCodigo.Text;
                    objEntidad.Tipo = txtTipo.Text;
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.RNC = txtRNC.Text;
                    objEntidad.Calle = txtCalle.Text;
                    objEntidad.Sector = txtSector.Text;
                    objEntidad.Provincia = txtProv.Text;
                    objEntidad.Pais = txtPais.Text;
                    objEntidad.Nombre_Persona = txtNomPer.Text;
                    objEntidad.Cargo = txtCargo.Text;
                    objEntidad.Municipio = txtMunicipio.Text;

                    objNegocio.EditandoContacto(objEntidad);

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
            if(tablaContactos.SelectedRows.Count > 0)
            {
                objEntidad.CODContacto = tablaContactos.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoContacto(objEntidad);

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
