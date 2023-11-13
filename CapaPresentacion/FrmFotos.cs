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
    public partial class FrmFotos : Form
    {
        private string idFoto;
        private bool Editarse = false;

        E_Fotos objEntidad = new E_Fotos();
        N_Fotos objNegocio = new N_Fotos();
        public FrmFotos()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFotos_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaFotos.Columns[0].Visible = false;
            tablaFotos.Columns[1].HeaderText = "Codigo de Foto";
            tablaFotos.Columns[2].HeaderText = "Id de Vehiculo";
            tablaFotos.Columns[3].HeaderText = "Nombre";
            tablaFotos.Columns[4].HeaderText = "Tipo de Foto";
            tablaFotos.Columns[5].HeaderText = "Link de Imagen";
            tablaFotos.Columns[6].HeaderText = "Fecha de Foto";

            tablaFotos.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Fotos objNegocio = new N_Fotos();
            tablaFotos.DataSource = objNegocio.ListandoFotos(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtLinkImagen.Text = "";
            txtIdVeh.Text = "";
            txtTipoFoto.Text = "";
            tablaFotos.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaFotos.SelectedRows.Count > 0)
            {
                Editarse = true;
                idFoto = tablaFotos.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaFotos.CurrentRow.Cells[1].Value.ToString();
                txtIdVeh.Text = tablaFotos.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = tablaFotos.CurrentRow.Cells[3].Value.ToString();
                txtTipoFoto.Text = tablaFotos.CurrentRow.Cells[4].Value.ToString(); 
                txtLinkImagen.Text = tablaFotos.CurrentRow.Cells[5].Value.ToString(); 
                dtpFecha_Foto.Value = Convert.ToDateTime(tablaFotos.CurrentRow.Cells[6].Value.ToString());

                
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
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Tipo_foto = txtTipoFoto.Text;
                    objEntidad.Link_Imagen = txtLinkImagen.Text;
                    objEntidad.Fecha_Foto = dtpFecha_Foto.Value.Date;

                    objNegocio.InsertandoFotos(objEntidad);

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
                    objEntidad.CODFoto = txtCodigo.Text;
                    objEntidad.IdVehiculo = Convert.ToInt32(txtIdVeh.Text);
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Tipo_foto = txtTipoFoto.Text;
                    objEntidad.Link_Imagen = txtLinkImagen.Text;
                    objEntidad.Fecha_Foto = dtpFecha_Foto.Value.Date;

                    objNegocio.EditandoFoto(objEntidad);

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
            if(tablaFotos.SelectedRows.Count > 0)
            {
                objEntidad.CODFoto = tablaFotos.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoFoto(objEntidad);

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
