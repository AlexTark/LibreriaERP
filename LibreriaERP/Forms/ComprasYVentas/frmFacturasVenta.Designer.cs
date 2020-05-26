namespace LibreriaERP.Forms.ComprasYVentas
{
    partial class frmFacturasVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturasVenta));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFacturasVenta = new System.Windows.Forms.DataGridView();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.bbiAgregarFactura = new System.Windows.Forms.RibbonButton();
            this.bbiEliminarFactura = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.bbiSalir = new System.Windows.Forms.RibbonButton();
            this.bsFacturasVenta = new System.Windows.Forms.BindingSource(this.components);
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoEvolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturasVenta)).BeginInit();
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
            this.ribbon1.Size = new System.Drawing.Size(869, 161);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Text = "ribbon1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFacturasVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 342);
            this.panel1.TabIndex = 1;
            // 
            // dgvFacturasVenta
            // 
            this.dgvFacturasVenta.AllowUserToAddRows = false;
            this.dgvFacturasVenta.AllowUserToDeleteRows = false;
            this.dgvFacturasVenta.AutoGenerateColumns = false;
            this.dgvFacturasVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturasVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacturasVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturasVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serieDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.documentoEvolucionDataGridViewTextBoxColumn});
            this.dgvFacturasVenta.DataSource = this.bsFacturasVenta;
            this.dgvFacturasVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturasVenta.Location = new System.Drawing.Point(0, 0);
            this.dgvFacturasVenta.Name = "dgvFacturasVenta";
            this.dgvFacturasVenta.ReadOnly = true;
            this.dgvFacturasVenta.Size = new System.Drawing.Size(869, 342);
            this.dgvFacturasVenta.TabIndex = 0;
            this.dgvFacturasVenta.DoubleClick += new System.EventHandler(this.dgvFacturasVenta_DoubleClick);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Facturas venta";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.bbiAgregarFactura);
            this.ribbonPanel1.Items.Add(this.bbiEliminarFactura);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // bbiAgregarFactura
            // 
            this.bbiAgregarFactura.Image = ((System.Drawing.Image)(resources.GetObject("bbiAgregarFactura.Image")));
            this.bbiAgregarFactura.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarFactura.LargeImage")));
            this.bbiAgregarFactura.Name = "bbiAgregarFactura";
            this.bbiAgregarFactura.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarFactura.SmallImage")));
            this.bbiAgregarFactura.Text = "Nueva factura";
            this.bbiAgregarFactura.Click += new System.EventHandler(this.bbiAgregarFactura_Click);
            // 
            // bbiEliminarFactura
            // 
            this.bbiEliminarFactura.Image = ((System.Drawing.Image)(resources.GetObject("bbiEliminarFactura.Image")));
            this.bbiEliminarFactura.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarFactura.LargeImage")));
            this.bbiEliminarFactura.Name = "bbiEliminarFactura";
            this.bbiEliminarFactura.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarFactura.SmallImage")));
            this.bbiEliminarFactura.Text = "Eliminar factura";
            this.bbiEliminarFactura.Click += new System.EventHandler(this.bbiEliminarFactura_Click);
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
            // bsFacturasVenta
            // 
            this.bsFacturasVenta.DataSource = typeof(LibreriaERP.Clases.FacturasVenta.FacturaVenta);
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentoEvolucionDataGridViewTextBoxColumn
            // 
            this.documentoEvolucionDataGridViewTextBoxColumn.DataPropertyName = "DocumentoEvolucion";
            this.documentoEvolucionDataGridViewTextBoxColumn.HeaderText = "DocumentoEvolucion";
            this.documentoEvolucionDataGridViewTextBoxColumn.Name = "documentoEvolucionDataGridViewTextBoxColumn";
            this.documentoEvolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmFacturasVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmFacturasVenta";
            this.Text = "Facturas venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturasVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton bbiAgregarFactura;
        private System.Windows.Forms.RibbonButton bbiEliminarFactura;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton bbiSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvFacturasVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoEvolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsFacturasVenta;
    }
}