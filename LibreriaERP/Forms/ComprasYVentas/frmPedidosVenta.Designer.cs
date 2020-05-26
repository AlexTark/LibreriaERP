namespace LibreriaERP.Forms.ComprasYVentas
{
    partial class frmPedidosVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosVenta));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPedidosVenta = new System.Windows.Forms.DataGridView();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.bbiAgregarPedido = new System.Windows.Forms.RibbonButton();
            this.bbiEliminarPedido = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.bbiSalir = new System.Windows.Forms.RibbonButton();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoEvolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPedidosVenta = new System.Windows.Forms.BindingSource(this.components);
            this.bbiGenerarAlbaran = new System.Windows.Forms.RibbonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosVenta)).BeginInit();
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
            this.ribbon1.Size = new System.Drawing.Size(865, 163);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPedidosVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 331);
            this.panel1.TabIndex = 1;
            // 
            // dgvPedidosVenta
            // 
            this.dgvPedidosVenta.AllowUserToAddRows = false;
            this.dgvPedidosVenta.AllowUserToDeleteRows = false;
            this.dgvPedidosVenta.AutoGenerateColumns = false;
            this.dgvPedidosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidosVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serieDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.documentoEvolucionDataGridViewTextBoxColumn});
            this.dgvPedidosVenta.DataSource = this.bsPedidosVenta;
            this.dgvPedidosVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidosVenta.Location = new System.Drawing.Point(0, 0);
            this.dgvPedidosVenta.Name = "dgvPedidosVenta";
            this.dgvPedidosVenta.ReadOnly = true;
            this.dgvPedidosVenta.Size = new System.Drawing.Size(865, 331);
            this.dgvPedidosVenta.TabIndex = 0;
            this.dgvPedidosVenta.DoubleClick += new System.EventHandler(this.dgvPedidosVenta_DoubleClick);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Pedidos venta";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.bbiAgregarPedido);
            this.ribbonPanel1.Items.Add(this.bbiEliminarPedido);
            this.ribbonPanel1.Items.Add(this.bbiGenerarAlbaran);
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
            // bsPedidosVenta
            // 
            this.bsPedidosVenta.DataSource = typeof(LibreriaERP.Clases.PedidosVenta.PedidoVenta);
            // 
            // bbiGenerarAlbaran
            // 
            this.bbiGenerarAlbaran.Image = ((System.Drawing.Image)(resources.GetObject("bbiGenerarAlbaran.Image")));
            this.bbiGenerarAlbaran.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGenerarAlbaran.LargeImage")));
            this.bbiGenerarAlbaran.Name = "bbiGenerarAlbaran";
            this.bbiGenerarAlbaran.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiGenerarAlbaran.SmallImage")));
            this.bbiGenerarAlbaran.Text = "Generar albarán";
            this.bbiGenerarAlbaran.Click += new System.EventHandler(this.bbiGenerarAlbaran_Click);
            // 
            // frmPedidosVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPedidosVenta";
            this.Text = "Pedidos venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidosVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsPedidosVenta;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPedidosVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoEvolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton bbiAgregarPedido;
        private System.Windows.Forms.RibbonButton bbiEliminarPedido;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton bbiSalir;
        private System.Windows.Forms.RibbonButton bbiGenerarAlbaran;
    }
}