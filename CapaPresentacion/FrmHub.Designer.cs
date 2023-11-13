namespace CapaPresentacion
{
    partial class FrmHub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHub));
            this.topFormulario = new System.Windows.Forms.Panel();
            this.cerrarFormula = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.radiusElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CitasBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ClientesBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ContactosBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DepartamentosBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EmpleadosBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReservasBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.InventarioBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FotosBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FacturasBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EstadoBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.VehiculosBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.UsuariosBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TransaccionesBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SucursalesBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PresupuestosBT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.topFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topFormulario
            // 
            this.topFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.topFormulario.Controls.Add(this.cerrarFormula);
            this.topFormulario.Controls.Add(this.pictureBox1);
            this.topFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.topFormulario.Location = new System.Drawing.Point(0, 0);
            this.topFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topFormulario.Name = "topFormulario";
            this.topFormulario.Size = new System.Drawing.Size(1389, 46);
            this.topFormulario.TabIndex = 1;
            // 
            // cerrarFormula
            // 
            this.cerrarFormula.Image = ((System.Drawing.Image)(resources.GetObject("cerrarFormula.Image")));
            this.cerrarFormula.Location = new System.Drawing.Point(1319, 0);
            this.cerrarFormula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cerrarFormula.Name = "cerrarFormula";
            this.cerrarFormula.Size = new System.Drawing.Size(59, 39);
            this.cerrarFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrarFormula.TabIndex = 3;
            this.cerrarFormula.TabStop = false;
            this.cerrarFormula.Click += new System.EventHandler(this.cerrarFormula_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(596, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // moverFormulario
            // 
            this.moverFormulario.Fixed = true;
            this.moverFormulario.Horizontal = true;
            this.moverFormulario.TargetControl = this.topFormulario;
            this.moverFormulario.Vertical = true;
            // 
            // radiusElipse
            // 
            this.radiusElipse.ElipseRadius = 7;
            this.radiusElipse.TargetControl = this;
            // 
            // CitasBT
            // 
            this.CitasBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CitasBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CitasBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CitasBT.BorderRadius = 0;
            this.CitasBT.ButtonText = "Citas";
            this.CitasBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CitasBT.DisabledColor = System.Drawing.Color.Gray;
            this.CitasBT.Iconcolor = System.Drawing.Color.Transparent;
            this.CitasBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("CitasBT.Iconimage")));
            this.CitasBT.Iconimage_right = null;
            this.CitasBT.Iconimage_right_Selected = null;
            this.CitasBT.Iconimage_Selected = null;
            this.CitasBT.IconMarginLeft = 0;
            this.CitasBT.IconMarginRight = 0;
            this.CitasBT.IconRightVisible = true;
            this.CitasBT.IconRightZoom = 0D;
            this.CitasBT.IconVisible = true;
            this.CitasBT.IconZoom = 90D;
            this.CitasBT.IsTab = false;
            this.CitasBT.Location = new System.Drawing.Point(23, 82);
            this.CitasBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CitasBT.Name = "CitasBT";
            this.CitasBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CitasBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.CitasBT.OnHoverTextColor = System.Drawing.Color.White;
            this.CitasBT.selected = false;
            this.CitasBT.Size = new System.Drawing.Size(392, 59);
            this.CitasBT.TabIndex = 2;
            this.CitasBT.Text = "Citas";
            this.CitasBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CitasBT.Textcolor = System.Drawing.Color.White;
            this.CitasBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitasBT.Click += new System.EventHandler(this.CitasBT_Click);
            // 
            // ClientesBT
            // 
            this.ClientesBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ClientesBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ClientesBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientesBT.BorderRadius = 0;
            this.ClientesBT.ButtonText = "Clientes";
            this.ClientesBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientesBT.DisabledColor = System.Drawing.Color.Gray;
            this.ClientesBT.Iconcolor = System.Drawing.Color.Transparent;
            this.ClientesBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("ClientesBT.Iconimage")));
            this.ClientesBT.Iconimage_right = null;
            this.ClientesBT.Iconimage_right_Selected = null;
            this.ClientesBT.Iconimage_Selected = null;
            this.ClientesBT.IconMarginLeft = 0;
            this.ClientesBT.IconMarginRight = 0;
            this.ClientesBT.IconRightVisible = true;
            this.ClientesBT.IconRightZoom = 0D;
            this.ClientesBT.IconVisible = true;
            this.ClientesBT.IconZoom = 90D;
            this.ClientesBT.IsTab = false;
            this.ClientesBT.Location = new System.Drawing.Point(23, 177);
            this.ClientesBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientesBT.Name = "ClientesBT";
            this.ClientesBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ClientesBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ClientesBT.OnHoverTextColor = System.Drawing.Color.White;
            this.ClientesBT.selected = false;
            this.ClientesBT.Size = new System.Drawing.Size(392, 59);
            this.ClientesBT.TabIndex = 3;
            this.ClientesBT.Text = "Clientes";
            this.ClientesBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClientesBT.Textcolor = System.Drawing.Color.White;
            this.ClientesBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesBT.Click += new System.EventHandler(this.ClientesBT_Click);
            // 
            // ContactosBT
            // 
            this.ContactosBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ContactosBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ContactosBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContactosBT.BorderRadius = 0;
            this.ContactosBT.ButtonText = "Contactos";
            this.ContactosBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactosBT.DisabledColor = System.Drawing.Color.Gray;
            this.ContactosBT.Iconcolor = System.Drawing.Color.Transparent;
            this.ContactosBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("ContactosBT.Iconimage")));
            this.ContactosBT.Iconimage_right = null;
            this.ContactosBT.Iconimage_right_Selected = null;
            this.ContactosBT.Iconimage_Selected = null;
            this.ContactosBT.IconMarginLeft = 0;
            this.ContactosBT.IconMarginRight = 0;
            this.ContactosBT.IconRightVisible = true;
            this.ContactosBT.IconRightZoom = 0D;
            this.ContactosBT.IconVisible = true;
            this.ContactosBT.IconZoom = 90D;
            this.ContactosBT.IsTab = false;
            this.ContactosBT.Location = new System.Drawing.Point(23, 269);
            this.ContactosBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactosBT.Name = "ContactosBT";
            this.ContactosBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ContactosBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ContactosBT.OnHoverTextColor = System.Drawing.Color.White;
            this.ContactosBT.selected = false;
            this.ContactosBT.Size = new System.Drawing.Size(392, 59);
            this.ContactosBT.TabIndex = 4;
            this.ContactosBT.Text = "Contactos";
            this.ContactosBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ContactosBT.Textcolor = System.Drawing.Color.White;
            this.ContactosBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactosBT.Click += new System.EventHandler(this.ContactosBT_Click);
            // 
            // DepartamentosBT
            // 
            this.DepartamentosBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.DepartamentosBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.DepartamentosBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DepartamentosBT.BorderRadius = 0;
            this.DepartamentosBT.ButtonText = "Departamentos";
            this.DepartamentosBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepartamentosBT.DisabledColor = System.Drawing.Color.Gray;
            this.DepartamentosBT.Iconcolor = System.Drawing.Color.Transparent;
            this.DepartamentosBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("DepartamentosBT.Iconimage")));
            this.DepartamentosBT.Iconimage_right = null;
            this.DepartamentosBT.Iconimage_right_Selected = null;
            this.DepartamentosBT.Iconimage_Selected = null;
            this.DepartamentosBT.IconMarginLeft = 0;
            this.DepartamentosBT.IconMarginRight = 0;
            this.DepartamentosBT.IconRightVisible = true;
            this.DepartamentosBT.IconRightZoom = 0D;
            this.DepartamentosBT.IconVisible = true;
            this.DepartamentosBT.IconZoom = 90D;
            this.DepartamentosBT.IsTab = false;
            this.DepartamentosBT.Location = new System.Drawing.Point(23, 361);
            this.DepartamentosBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepartamentosBT.Name = "DepartamentosBT";
            this.DepartamentosBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.DepartamentosBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.DepartamentosBT.OnHoverTextColor = System.Drawing.Color.White;
            this.DepartamentosBT.selected = false;
            this.DepartamentosBT.Size = new System.Drawing.Size(392, 59);
            this.DepartamentosBT.TabIndex = 5;
            this.DepartamentosBT.Text = "Departamentos";
            this.DepartamentosBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DepartamentosBT.Textcolor = System.Drawing.Color.White;
            this.DepartamentosBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartamentosBT.Click += new System.EventHandler(this.DepartamentosBT_Click);
            // 
            // EmpleadosBT
            // 
            this.EmpleadosBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EmpleadosBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EmpleadosBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmpleadosBT.BorderRadius = 0;
            this.EmpleadosBT.ButtonText = "Empleados";
            this.EmpleadosBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpleadosBT.DisabledColor = System.Drawing.Color.Gray;
            this.EmpleadosBT.Iconcolor = System.Drawing.Color.Transparent;
            this.EmpleadosBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("EmpleadosBT.Iconimage")));
            this.EmpleadosBT.Iconimage_right = null;
            this.EmpleadosBT.Iconimage_right_Selected = null;
            this.EmpleadosBT.Iconimage_Selected = null;
            this.EmpleadosBT.IconMarginLeft = 0;
            this.EmpleadosBT.IconMarginRight = 0;
            this.EmpleadosBT.IconRightVisible = true;
            this.EmpleadosBT.IconRightZoom = 0D;
            this.EmpleadosBT.IconVisible = true;
            this.EmpleadosBT.IconZoom = 90D;
            this.EmpleadosBT.IsTab = false;
            this.EmpleadosBT.Location = new System.Drawing.Point(23, 448);
            this.EmpleadosBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmpleadosBT.Name = "EmpleadosBT";
            this.EmpleadosBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EmpleadosBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.EmpleadosBT.OnHoverTextColor = System.Drawing.Color.White;
            this.EmpleadosBT.selected = false;
            this.EmpleadosBT.Size = new System.Drawing.Size(392, 59);
            this.EmpleadosBT.TabIndex = 6;
            this.EmpleadosBT.Text = "Empleados";
            this.EmpleadosBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmpleadosBT.Textcolor = System.Drawing.Color.White;
            this.EmpleadosBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpleadosBT.Click += new System.EventHandler(this.EmpleadosBT_Click);
            // 
            // ReservasBT
            // 
            this.ReservasBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ReservasBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ReservasBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReservasBT.BorderRadius = 0;
            this.ReservasBT.ButtonText = "Reservas por Cita";
            this.ReservasBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReservasBT.DisabledColor = System.Drawing.Color.Gray;
            this.ReservasBT.Iconcolor = System.Drawing.Color.Transparent;
            this.ReservasBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("ReservasBT.Iconimage")));
            this.ReservasBT.Iconimage_right = null;
            this.ReservasBT.Iconimage_right_Selected = null;
            this.ReservasBT.Iconimage_Selected = null;
            this.ReservasBT.IconMarginLeft = 0;
            this.ReservasBT.IconMarginRight = 0;
            this.ReservasBT.IconRightVisible = true;
            this.ReservasBT.IconRightZoom = 0D;
            this.ReservasBT.IconVisible = true;
            this.ReservasBT.IconZoom = 90D;
            this.ReservasBT.IsTab = false;
            this.ReservasBT.Location = new System.Drawing.Point(470, 448);
            this.ReservasBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReservasBT.Name = "ReservasBT";
            this.ReservasBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ReservasBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ReservasBT.OnHoverTextColor = System.Drawing.Color.White;
            this.ReservasBT.selected = false;
            this.ReservasBT.Size = new System.Drawing.Size(392, 59);
            this.ReservasBT.TabIndex = 11;
            this.ReservasBT.Text = "Reservas por Cita";
            this.ReservasBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReservasBT.Textcolor = System.Drawing.Color.White;
            this.ReservasBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservasBT.Click += new System.EventHandler(this.ReservasBT_Click);
            // 
            // InventarioBT
            // 
            this.InventarioBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.InventarioBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.InventarioBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventarioBT.BorderRadius = 0;
            this.InventarioBT.ButtonText = "Inventario";
            this.InventarioBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InventarioBT.DisabledColor = System.Drawing.Color.Gray;
            this.InventarioBT.Iconcolor = System.Drawing.Color.Transparent;
            this.InventarioBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("InventarioBT.Iconimage")));
            this.InventarioBT.Iconimage_right = null;
            this.InventarioBT.Iconimage_right_Selected = null;
            this.InventarioBT.Iconimage_Selected = null;
            this.InventarioBT.IconMarginLeft = 0;
            this.InventarioBT.IconMarginRight = 0;
            this.InventarioBT.IconRightVisible = true;
            this.InventarioBT.IconRightZoom = 0D;
            this.InventarioBT.IconVisible = true;
            this.InventarioBT.IconZoom = 90D;
            this.InventarioBT.IsTab = false;
            this.InventarioBT.Location = new System.Drawing.Point(470, 361);
            this.InventarioBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InventarioBT.Name = "InventarioBT";
            this.InventarioBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.InventarioBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.InventarioBT.OnHoverTextColor = System.Drawing.Color.White;
            this.InventarioBT.selected = false;
            this.InventarioBT.Size = new System.Drawing.Size(392, 59);
            this.InventarioBT.TabIndex = 10;
            this.InventarioBT.Text = "Inventario";
            this.InventarioBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InventarioBT.Textcolor = System.Drawing.Color.White;
            this.InventarioBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventarioBT.Click += new System.EventHandler(this.InventarioBT_Click);
            // 
            // FotosBT
            // 
            this.FotosBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.FotosBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.FotosBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FotosBT.BorderRadius = 0;
            this.FotosBT.ButtonText = "Fotos de Vehiculos";
            this.FotosBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FotosBT.DisabledColor = System.Drawing.Color.Gray;
            this.FotosBT.Iconcolor = System.Drawing.Color.Transparent;
            this.FotosBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("FotosBT.Iconimage")));
            this.FotosBT.Iconimage_right = null;
            this.FotosBT.Iconimage_right_Selected = null;
            this.FotosBT.Iconimage_Selected = null;
            this.FotosBT.IconMarginLeft = 0;
            this.FotosBT.IconMarginRight = 0;
            this.FotosBT.IconRightVisible = true;
            this.FotosBT.IconRightZoom = 0D;
            this.FotosBT.IconVisible = true;
            this.FotosBT.IconZoom = 90D;
            this.FotosBT.IsTab = false;
            this.FotosBT.Location = new System.Drawing.Point(470, 269);
            this.FotosBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FotosBT.Name = "FotosBT";
            this.FotosBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.FotosBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.FotosBT.OnHoverTextColor = System.Drawing.Color.White;
            this.FotosBT.selected = false;
            this.FotosBT.Size = new System.Drawing.Size(392, 59);
            this.FotosBT.TabIndex = 9;
            this.FotosBT.Text = "Fotos de Vehiculos";
            this.FotosBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FotosBT.Textcolor = System.Drawing.Color.White;
            this.FotosBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FotosBT.Click += new System.EventHandler(this.FotosBT_Click);
            // 
            // FacturasBT
            // 
            this.FacturasBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.FacturasBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.FacturasBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FacturasBT.BorderRadius = 0;
            this.FacturasBT.ButtonText = "Facturas";
            this.FacturasBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FacturasBT.DisabledColor = System.Drawing.Color.Gray;
            this.FacturasBT.Iconcolor = System.Drawing.Color.Transparent;
            this.FacturasBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("FacturasBT.Iconimage")));
            this.FacturasBT.Iconimage_right = null;
            this.FacturasBT.Iconimage_right_Selected = null;
            this.FacturasBT.Iconimage_Selected = null;
            this.FacturasBT.IconMarginLeft = 0;
            this.FacturasBT.IconMarginRight = 0;
            this.FacturasBT.IconRightVisible = true;
            this.FacturasBT.IconRightZoom = 0D;
            this.FacturasBT.IconVisible = true;
            this.FacturasBT.IconZoom = 90D;
            this.FacturasBT.IsTab = false;
            this.FacturasBT.Location = new System.Drawing.Point(470, 177);
            this.FacturasBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FacturasBT.Name = "FacturasBT";
            this.FacturasBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.FacturasBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.FacturasBT.OnHoverTextColor = System.Drawing.Color.White;
            this.FacturasBT.selected = false;
            this.FacturasBT.Size = new System.Drawing.Size(392, 59);
            this.FacturasBT.TabIndex = 8;
            this.FacturasBT.Text = "Facturas";
            this.FacturasBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FacturasBT.Textcolor = System.Drawing.Color.White;
            this.FacturasBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturasBT.Click += new System.EventHandler(this.FacturasBT_Click);
            // 
            // EstadoBT
            // 
            this.EstadoBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EstadoBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EstadoBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EstadoBT.BorderRadius = 0;
            this.EstadoBT.ButtonText = "Estado de Vehiculos";
            this.EstadoBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EstadoBT.DisabledColor = System.Drawing.Color.Gray;
            this.EstadoBT.Iconcolor = System.Drawing.Color.Transparent;
            this.EstadoBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("EstadoBT.Iconimage")));
            this.EstadoBT.Iconimage_right = null;
            this.EstadoBT.Iconimage_right_Selected = null;
            this.EstadoBT.Iconimage_Selected = null;
            this.EstadoBT.IconMarginLeft = 0;
            this.EstadoBT.IconMarginRight = 0;
            this.EstadoBT.IconRightVisible = true;
            this.EstadoBT.IconRightZoom = 0D;
            this.EstadoBT.IconVisible = true;
            this.EstadoBT.IconZoom = 90D;
            this.EstadoBT.IsTab = false;
            this.EstadoBT.Location = new System.Drawing.Point(470, 82);
            this.EstadoBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EstadoBT.Name = "EstadoBT";
            this.EstadoBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.EstadoBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.EstadoBT.OnHoverTextColor = System.Drawing.Color.White;
            this.EstadoBT.selected = false;
            this.EstadoBT.Size = new System.Drawing.Size(392, 59);
            this.EstadoBT.TabIndex = 7;
            this.EstadoBT.Text = "Estado de Vehiculos";
            this.EstadoBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EstadoBT.Textcolor = System.Drawing.Color.White;
            this.EstadoBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoBT.Click += new System.EventHandler(this.EstadoBT_Click);
            // 
            // VehiculosBT
            // 
            this.VehiculosBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.VehiculosBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.VehiculosBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VehiculosBT.BorderRadius = 0;
            this.VehiculosBT.ButtonText = "Vehiculos";
            this.VehiculosBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VehiculosBT.DisabledColor = System.Drawing.Color.Gray;
            this.VehiculosBT.Iconcolor = System.Drawing.Color.Transparent;
            this.VehiculosBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("VehiculosBT.Iconimage")));
            this.VehiculosBT.Iconimage_right = null;
            this.VehiculosBT.Iconimage_right_Selected = null;
            this.VehiculosBT.Iconimage_Selected = null;
            this.VehiculosBT.IconMarginLeft = 0;
            this.VehiculosBT.IconMarginRight = 0;
            this.VehiculosBT.IconRightVisible = true;
            this.VehiculosBT.IconRightZoom = 0D;
            this.VehiculosBT.IconVisible = true;
            this.VehiculosBT.IconZoom = 90D;
            this.VehiculosBT.IsTab = false;
            this.VehiculosBT.Location = new System.Drawing.Point(947, 448);
            this.VehiculosBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VehiculosBT.Name = "VehiculosBT";
            this.VehiculosBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.VehiculosBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.VehiculosBT.OnHoverTextColor = System.Drawing.Color.White;
            this.VehiculosBT.selected = false;
            this.VehiculosBT.Size = new System.Drawing.Size(392, 59);
            this.VehiculosBT.TabIndex = 16;
            this.VehiculosBT.Text = "Vehiculos";
            this.VehiculosBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VehiculosBT.Textcolor = System.Drawing.Color.White;
            this.VehiculosBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiculosBT.Click += new System.EventHandler(this.VehiculosBT_Click);
            // 
            // UsuariosBT
            // 
            this.UsuariosBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.UsuariosBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.UsuariosBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UsuariosBT.BorderRadius = 0;
            this.UsuariosBT.ButtonText = "Usuarios";
            this.UsuariosBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsuariosBT.DisabledColor = System.Drawing.Color.Gray;
            this.UsuariosBT.Iconcolor = System.Drawing.Color.Transparent;
            this.UsuariosBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("UsuariosBT.Iconimage")));
            this.UsuariosBT.Iconimage_right = null;
            this.UsuariosBT.Iconimage_right_Selected = null;
            this.UsuariosBT.Iconimage_Selected = null;
            this.UsuariosBT.IconMarginLeft = 0;
            this.UsuariosBT.IconMarginRight = 0;
            this.UsuariosBT.IconRightVisible = true;
            this.UsuariosBT.IconRightZoom = 0D;
            this.UsuariosBT.IconVisible = true;
            this.UsuariosBT.IconZoom = 90D;
            this.UsuariosBT.IsTab = false;
            this.UsuariosBT.Location = new System.Drawing.Point(947, 361);
            this.UsuariosBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsuariosBT.Name = "UsuariosBT";
            this.UsuariosBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.UsuariosBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.UsuariosBT.OnHoverTextColor = System.Drawing.Color.White;
            this.UsuariosBT.selected = false;
            this.UsuariosBT.Size = new System.Drawing.Size(392, 59);
            this.UsuariosBT.TabIndex = 15;
            this.UsuariosBT.Text = "Usuarios";
            this.UsuariosBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsuariosBT.Textcolor = System.Drawing.Color.White;
            this.UsuariosBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosBT.Click += new System.EventHandler(this.UsuariosBT_Click);
            // 
            // TransaccionesBT
            // 
            this.TransaccionesBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.TransaccionesBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.TransaccionesBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TransaccionesBT.BorderRadius = 0;
            this.TransaccionesBT.ButtonText = "Transacciones";
            this.TransaccionesBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransaccionesBT.DisabledColor = System.Drawing.Color.Gray;
            this.TransaccionesBT.Iconcolor = System.Drawing.Color.Transparent;
            this.TransaccionesBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("TransaccionesBT.Iconimage")));
            this.TransaccionesBT.Iconimage_right = null;
            this.TransaccionesBT.Iconimage_right_Selected = null;
            this.TransaccionesBT.Iconimage_Selected = null;
            this.TransaccionesBT.IconMarginLeft = 0;
            this.TransaccionesBT.IconMarginRight = 0;
            this.TransaccionesBT.IconRightVisible = true;
            this.TransaccionesBT.IconRightZoom = 0D;
            this.TransaccionesBT.IconVisible = true;
            this.TransaccionesBT.IconZoom = 90D;
            this.TransaccionesBT.IsTab = false;
            this.TransaccionesBT.Location = new System.Drawing.Point(947, 269);
            this.TransaccionesBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TransaccionesBT.Name = "TransaccionesBT";
            this.TransaccionesBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.TransaccionesBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.TransaccionesBT.OnHoverTextColor = System.Drawing.Color.White;
            this.TransaccionesBT.selected = false;
            this.TransaccionesBT.Size = new System.Drawing.Size(392, 59);
            this.TransaccionesBT.TabIndex = 14;
            this.TransaccionesBT.Text = "Transacciones";
            this.TransaccionesBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TransaccionesBT.Textcolor = System.Drawing.Color.White;
            this.TransaccionesBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransaccionesBT.Click += new System.EventHandler(this.TransaccionesBT_Click);
            // 
            // SucursalesBT
            // 
            this.SucursalesBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SucursalesBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SucursalesBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SucursalesBT.BorderRadius = 0;
            this.SucursalesBT.ButtonText = "Sucursales";
            this.SucursalesBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SucursalesBT.DisabledColor = System.Drawing.Color.Gray;
            this.SucursalesBT.Iconcolor = System.Drawing.Color.Transparent;
            this.SucursalesBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("SucursalesBT.Iconimage")));
            this.SucursalesBT.Iconimage_right = null;
            this.SucursalesBT.Iconimage_right_Selected = null;
            this.SucursalesBT.Iconimage_Selected = null;
            this.SucursalesBT.IconMarginLeft = 0;
            this.SucursalesBT.IconMarginRight = 0;
            this.SucursalesBT.IconRightVisible = true;
            this.SucursalesBT.IconRightZoom = 0D;
            this.SucursalesBT.IconVisible = true;
            this.SucursalesBT.IconZoom = 90D;
            this.SucursalesBT.IsTab = false;
            this.SucursalesBT.Location = new System.Drawing.Point(947, 177);
            this.SucursalesBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SucursalesBT.Name = "SucursalesBT";
            this.SucursalesBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SucursalesBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SucursalesBT.OnHoverTextColor = System.Drawing.Color.White;
            this.SucursalesBT.selected = false;
            this.SucursalesBT.Size = new System.Drawing.Size(392, 59);
            this.SucursalesBT.TabIndex = 13;
            this.SucursalesBT.Text = "Sucursales";
            this.SucursalesBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SucursalesBT.Textcolor = System.Drawing.Color.White;
            this.SucursalesBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SucursalesBT.Click += new System.EventHandler(this.SucursalesBT_Click);
            // 
            // PresupuestosBT
            // 
            this.PresupuestosBT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.PresupuestosBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.PresupuestosBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PresupuestosBT.BorderRadius = 0;
            this.PresupuestosBT.ButtonText = "Presupuestos";
            this.PresupuestosBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PresupuestosBT.DisabledColor = System.Drawing.Color.Gray;
            this.PresupuestosBT.Iconcolor = System.Drawing.Color.Transparent;
            this.PresupuestosBT.Iconimage = ((System.Drawing.Image)(resources.GetObject("PresupuestosBT.Iconimage")));
            this.PresupuestosBT.Iconimage_right = null;
            this.PresupuestosBT.Iconimage_right_Selected = null;
            this.PresupuestosBT.Iconimage_Selected = null;
            this.PresupuestosBT.IconMarginLeft = 0;
            this.PresupuestosBT.IconMarginRight = 0;
            this.PresupuestosBT.IconRightVisible = true;
            this.PresupuestosBT.IconRightZoom = 0D;
            this.PresupuestosBT.IconVisible = true;
            this.PresupuestosBT.IconZoom = 90D;
            this.PresupuestosBT.IsTab = false;
            this.PresupuestosBT.Location = new System.Drawing.Point(947, 82);
            this.PresupuestosBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PresupuestosBT.Name = "PresupuestosBT";
            this.PresupuestosBT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.PresupuestosBT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.PresupuestosBT.OnHoverTextColor = System.Drawing.Color.White;
            this.PresupuestosBT.selected = false;
            this.PresupuestosBT.Size = new System.Drawing.Size(392, 59);
            this.PresupuestosBT.TabIndex = 12;
            this.PresupuestosBT.Text = "Presupuestos";
            this.PresupuestosBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PresupuestosBT.Textcolor = System.Drawing.Color.White;
            this.PresupuestosBT.TextFont = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresupuestosBT.Click += new System.EventHandler(this.PresupuestosBT_Click);
            // 
            // FrmHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1389, 727);
            this.Controls.Add(this.VehiculosBT);
            this.Controls.Add(this.UsuariosBT);
            this.Controls.Add(this.TransaccionesBT);
            this.Controls.Add(this.SucursalesBT);
            this.Controls.Add(this.PresupuestosBT);
            this.Controls.Add(this.ReservasBT);
            this.Controls.Add(this.InventarioBT);
            this.Controls.Add(this.FotosBT);
            this.Controls.Add(this.FacturasBT);
            this.Controls.Add(this.EstadoBT);
            this.Controls.Add(this.EmpleadosBT);
            this.Controls.Add(this.DepartamentosBT);
            this.Controls.Add(this.ContactosBT);
            this.Controls.Add(this.ClientesBT);
            this.Controls.Add(this.CitasBT);
            this.Controls.Add(this.topFormulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHub";
            this.Text = "FrmVehiculos";
            this.topFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrarFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topFormulario;
        private System.Windows.Forms.PictureBox cerrarFormula;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl moverFormulario;
        private Bunifu.Framework.UI.BunifuElipse radiusElipse;
        private Bunifu.Framework.UI.BunifuFlatButton VehiculosBT;
        private Bunifu.Framework.UI.BunifuFlatButton UsuariosBT;
        private Bunifu.Framework.UI.BunifuFlatButton TransaccionesBT;
        private Bunifu.Framework.UI.BunifuFlatButton SucursalesBT;
        private Bunifu.Framework.UI.BunifuFlatButton PresupuestosBT;
        private Bunifu.Framework.UI.BunifuFlatButton ReservasBT;
        private Bunifu.Framework.UI.BunifuFlatButton InventarioBT;
        private Bunifu.Framework.UI.BunifuFlatButton FotosBT;
        private Bunifu.Framework.UI.BunifuFlatButton FacturasBT;
        private Bunifu.Framework.UI.BunifuFlatButton EstadoBT;
        private Bunifu.Framework.UI.BunifuFlatButton EmpleadosBT;
        private Bunifu.Framework.UI.BunifuFlatButton DepartamentosBT;
        private Bunifu.Framework.UI.BunifuFlatButton ContactosBT;
        private Bunifu.Framework.UI.BunifuFlatButton ClientesBT;
        private Bunifu.Framework.UI.BunifuFlatButton CitasBT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}