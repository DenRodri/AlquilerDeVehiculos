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
    public partial class FrmUsuarios : Form
    {
        private string idUsuario;
        private bool Habilitado = false, Online = false;
        private bool Editarse = false;

        E_Usuarios objEntidad = new E_Usuarios();
        N_Usuarios objNegocio = new N_Usuarios();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void cerrarFormula_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            mostrarBuscarTabla("");
            accionesTabla();
            
            
            
        }
        public void accionesTabla()
        {

            tablaUsuarios.Columns[0].Visible = false;
            tablaUsuarios.Columns[1].HeaderText = "Id de Rol";
            tablaUsuarios.Columns[2].HeaderText = "Codigo de Usuario";
            tablaUsuarios.Columns[3].HeaderText = "Nombre";
            tablaUsuarios.Columns[4].HeaderText = "Fecha de creacion de cuenta";
            tablaUsuarios.Columns[5].HeaderText = "Contraseña";
            tablaUsuarios.Columns[6].HeaderText = "Email";
            tablaUsuarios.Columns[7].HeaderText = "Ultima vez ingresada";
            tablaUsuarios.Columns[8].HeaderText = "Online";
            tablaUsuarios.Columns[9].HeaderText = "Habilitado";

            tablaUsuarios.ClearSelection();
        }
        public void mostrarBuscarTabla(string buscar)
        {
            N_Usuarios objNegocio = new N_Usuarios();
            tablaUsuarios.DataSource = objNegocio.ListandoUsuarios(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBuscarTabla(txtBuscar.Text);
        }
        private void limpiarCajas()
        {
            txtIdRol.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtCodigo.Text = "";
            txtPassword.Text = "";
            HabilitadoChB.Checked = false;
            OnlineChB.Checked = false;
            tablaUsuarios.ClearSelection();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            limpiarCajas();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tablaUsuarios.SelectedRows.Count > 0)
            {
                Editarse = true;
                idUsuario = tablaUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtIdRol.Text = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtCodigo.Text = tablaUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = tablaUsuarios.CurrentRow.Cells[3].Value.ToString();

                txtPassword.Text = tablaUsuarios.CurrentRow.Cells[5].Value.ToString(); 
                txtEmail.Text = tablaUsuarios.CurrentRow.Cells[6].Value.ToString(); 

                if(tablaUsuarios.CurrentRow.Cells[7].Value.ToString() == "1")
                {
                    OnlineChB.Checked = true;
                }else if(tablaUsuarios.CurrentRow.Cells[7].Value.ToString() == "0")
                {
                    OnlineChB.Checked = false;
                }
                if(tablaUsuarios.CurrentRow.Cells[8].Value.ToString() == "1")
                {
                    HabilitadoChB.Checked = true;
                }else if(tablaUsuarios.CurrentRow.Cells[8].Value.ToString() == "0")
                {
                    HabilitadoChB.Checked = false;
                }

                
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
                    objEntidad.IdRol = Convert.ToInt32(txtIdRol.Text);
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Fecha_Creacion_Cuenta = DateTime.Now;
                    objEntidad.Password = txtPassword.Text;
                    objEntidad.Email = txtEmail.Text;
                    objEntidad.Ultima_vez_ingresada = DateTime.Now;
                    objEntidad.Online = Online;
                    objEntidad.Habilitado = Habilitado;


                    objNegocio.InsertandoUsuarios(objEntidad);

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
                    objEntidad.CODUsuario = txtCodigo.Text;
                    objEntidad.IdRol = Convert.ToInt32(txtIdRol.Text);
                    objEntidad.Nombre = txtNombre.Text;
                    objEntidad.Fecha_Creacion_Cuenta = DateTime.Now;
                    objEntidad.Password = txtPassword.Text;
                    objEntidad.Email = txtEmail.Text;
                    objEntidad.Ultima_vez_ingresada = DateTime.Now;
                    objEntidad.Online = Online;
                    objEntidad.Habilitado = Habilitado;

                    objNegocio.EditandoUsuario(objEntidad);

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
            if(tablaUsuarios.SelectedRows.Count > 0)
            {
                objEntidad.CODUsuario = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                objNegocio.EliminandoUsuario(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                mostrarBuscarTabla("");
            }
            else
            {
                MessageBox.Show("Seleccione la fila que deseas eliminar");
            }
        }

        private void HabilitadoChB_CheckedChanged(object sender, EventArgs e)
        {
            if (HabilitadoChB.Checked == true)
            {
                Habilitado = true;
            }
            else
            {
                Habilitado = false;
            }
        }

        private void OnlineChB_CheckedChanged(object sender, EventArgs e)
        {
            if(OnlineChB.Checked == true)
            {
                Online = true;
            }
            else
            {
                Online = false;
            }
        }
    }
}
