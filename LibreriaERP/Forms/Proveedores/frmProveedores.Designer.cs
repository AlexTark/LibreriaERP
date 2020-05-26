namespace LibreriaERP.Forms.Proveedores
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.bbiAgregarProveedor = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.bbiEliminarProveedor = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.bbiSalir = new System.Windows.Forms.RibbonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreComercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreFiscalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(800, 160);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Proveedores";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.bbiAgregarProveedor);
            this.ribbonPanel1.Items.Add(this.bbiEliminarProveedor);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // bbiAgregarProveedor
            // 
            this.bbiAgregarProveedor.DropDownItems.Add(this.ribbonButton2);
            this.bbiAgregarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("bbiAgregarProveedor.Image")));
            this.bbiAgregarProveedor.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarProveedor.LargeImage")));
            this.bbiAgregarProveedor.Name = "bbiAgregarProveedor";
            this.bbiAgregarProveedor.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarProveedor.SmallImage")));
            this.bbiAgregarProveedor.Text = "Agregar proveedor";
            this.bbiAgregarProveedor.Click += new System.EventHandler(this.bbiAgregarProveedor_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // bbiEliminarProveedor
            // 
            this.bbiEliminarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("bbiEliminarProveedor.Image")));
            this.bbiEliminarProveedor.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarProveedor.LargeImage")));
            this.bbiEliminarProveedor.Name = "bbiEliminarProveedor";
            this.bbiEliminarProveedor.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarProveedor.SmallImage")));
            this.bbiEliminarProveedor.Text = "Eliminar proveedor";
            this.bbiEliminarProveedor.Click += new System.EventHandler(this.bbiEliminarProveedor_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.bbiSalir);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "";
            // 
            // bbiSalir
            // 
            this.bbiSalir.Image = ((System.Drawing.Image)(resources.GetObject("bbiSalir.Image")));
            this.bbiSalir.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSalir.LargeImage")));
            this.bbiSalir.Name = "bbiSalir";
            this.bbiSalir.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiSalir.SmallImage")));
            this.bbiSalir.Text = "Salir";
            this.bbiSalir.Click += new System.EventHandler(this.bbiSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProveedores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 290);
            this.panel1.TabIndex = 1;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AutoGenerateColumns = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.nombreComercialDataGridViewTextBoxColumn,
            this.nombreFiscalDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.movilDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.numeroCuentaDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dgvProveedores.DataSource = this.proveedorBindingSource;
            this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedores.Location = new System.Drawing.Point(0, 0);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.Size = new System.Drawing.Size(800, 290);
            this.dgvProveedores.TabIndex = 0;
            this.dgvProveedores.DoubleClick += new System.EventHandler(this.dgvProveedores_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreComercialDataGridViewTextBoxColumn
            // 
            this.nombreComercialDataGridViewTextBoxColumn.DataPropertyName = "NombreComercial";
            this.nombreComercialDataGridViewTextBoxColumn.HeaderText = "NombreComercial";
            this.nombreComercialDataGridViewTextBoxColumn.Name = "nombreComercialDataGridViewTextBoxColumn";
            this.nombreComercialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreFiscalDataGridViewTextBoxColumn
            // 
            this.nombreFiscalDataGridViewTextBoxColumn.DataPropertyName = "NombreFiscal";
            this.nombreFiscalDataGridViewTextBoxColumn.HeaderText = "NombreFiscal";
            this.nombreFiscalDataGridViewTextBoxColumn.Name = "nombreFiscalDataGridViewTextBoxColumn";
            this.nombreFiscalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movilDataGridViewTextBoxColumn
            // 
            this.movilDataGridViewTextBoxColumn.DataPropertyName = "Movil";
            this.movilDataGridViewTextBoxColumn.HeaderText = "Movil";
            this.movilDataGridViewTextBoxColumn.Name = "movilDataGridViewTextBoxColumn";
            this.movilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroCuentaDataGridViewTextBoxColumn
            // 
            this.numeroCuentaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCuenta";
            this.numeroCuentaDataGridViewTextBoxColumn.HeaderText = "NumeroCuenta";
            this.numeroCuentaDataGridViewTextBoxColumn.Name = "numeroCuentaDataGridViewTextBoxColumn";
            this.numeroCuentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(LibreriaERP.Clases.Proveedores.Proveedor);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmProveedores";
            this.Text = "Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton bbiAgregarProveedor;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreFiscalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.RibbonButton bbiEliminarProveedor;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton bbiSalir;
    }
}