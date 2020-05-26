namespace LibreriaERP.Forms.ComprasYVentas
{
    partial class frmPedidosCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosCompra));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPedidosCompra = new System.Windows.Forms.DataGridView();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.bbiAgregarPedido = new System.Windows.Forms.RibbonButton();
            this.bbiEliminarPedido = new System.Windows.Forms.RibbonButton();
            this.bbiGenerarEntrada = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.bbiSalir = new System.Windows.Forms.RibbonButton();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoEvolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPedidosCompra = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosCompra)).BeginInit();
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
            this.ribbon1.Size = new System.Drawing.Size(823, 168);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPedidosCompra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 321);
            this.panel1.TabIndex = 1;
            // 
            // dgvPedidosCompra
            // 
            this.dgvPedidosCompra.AllowUserToAddRows = false;
            this.dgvPedidosCompra.AllowUserToDeleteRows = false;
            this.dgvPedidosCompra.AutoGenerateColumns = false;
            this.dgvPedidosCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidosCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serieDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.documentoEvolucionDataGridViewTextBoxColumn});
            this.dgvPedidosCompra.DataSource = this.bsPedidosCompra;
            this.dgvPedidosCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidosCompra.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidosCompra.Name = "dgvPedidosCompra";
            this.dgvPedidosCompra.ReadOnly = true;
            this.dgvPedidosCompra.Size = new System.Drawing.Size(823, 321);
            this.dgvPedidosCompra.TabIndex = 0;
            this.dgvPedidosCompra.DoubleClick += new System.EventHandler(this.dgvPedidosCompra_DoubleClick);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Pedidos compra";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.bbiAgregarPedido);
            this.ribbonPanel1.Items.Add(this.bbiEliminarPedido);
            this.ribbonPanel1.Items.Add(this.bbiGenerarEntrada);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // bbiAgregarPedido
            // 
            this.bbiAgregarPedido.Image = ((System.Drawing.Image)(resources.GetObject("bbiAgregarPedido.Image")));
            this.bbiAgregarPedido.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarPedido.LargeImage")));
            this.bbiAgregarPedido.Name = "bbiAgregarPedido";
            this.bbiAgregarPedido.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarPedido.SmallImage")));
            this.bbiAgregarPedido.Text = "Nuevo pedido";
            this.bbiAgregarPedido.Click += new System.EventHandler(this.bbiAgregarPedido_Click);
            // 
            // bbiEliminarPedido
            // 
            this.bbiEliminarPedido.Image = ((System.Drawing.Image)(resources.GetObject("bbiEliminarPedido.Image")));
            this.bbiEliminarPedido.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarPedido.LargeImage")));
            this.bbiEliminarPedido.Name = "bbiEliminarPedido";
            this.bbiEliminarPedido.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarPedido.SmallImage")));
            this.bbiEliminarPedido.Text = "Eliminar pedido";
            this.bbiEliminarPedido.Click += new System.EventHandler(this.bbiEliminarPedido_Click);
            // 
            // bbiGenerarEntrada
            // 
            this.bbiGenerarEntrada.Image = ((System.Drawing.Image)(resources.GetObject("bbiGenerarEntrada.Image")));
            this.bbiGenerarEntrada.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGenerarEntrada.LargeImage")));
            this.bbiGenerarEntrada.Name = "bbiGenerarEntrada";
            this.bbiGenerarEntrada.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiGenerarEntrada.SmallImage")));
            this.bbiGenerarEntrada.Text = "Generar entrada";
            this.bbiGenerarEntrada.Click += new System.EventHandler(this.bbiGenerarEntrada_Click);
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
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bsPedidosCompra
            // 
            this.bsPedidosCompra.DataSource = typeof(LibreriaERP.Clases.PedidosCompra.PedidoCompra);
            // 
            // frmPedidosCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPedidosCompra";
            this.Text = "Pedidos compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton bbiAgregarPedido;
        private System.Windows.Forms.RibbonButton bbiEliminarPedido;
        private System.Windows.Forms.RibbonButton bbiGenerarEntrada;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton bbiSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPedidosCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoEvolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsPedidosCompra;
    }
}