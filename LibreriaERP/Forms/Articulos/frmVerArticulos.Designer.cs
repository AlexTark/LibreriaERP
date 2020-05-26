namespace LibreriaERP.Forms.Articulos
{
    partial class frmVerArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerArticulos));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.bbiAgregarArticulo = new System.Windows.Forms.RibbonButton();
            this.bbiEliminarArticulo = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.bbiSalir = new System.Windows.Forms.RibbonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCosteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoAux1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoAux2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoAux3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
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
            this.ribbon1.Size = new System.Drawing.Size(800, 163);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Artículos";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.bbiAgregarArticulo);
            this.ribbonPanel1.Items.Add(this.bbiEliminarArticulo);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // bbiAgregarArticulo
            // 
            this.bbiAgregarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("bbiAgregarArticulo.Image")));
            this.bbiAgregarArticulo.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarArticulo.LargeImage")));
            this.bbiAgregarArticulo.Name = "bbiAgregarArticulo";
            this.bbiAgregarArticulo.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarArticulo.SmallImage")));
            this.bbiAgregarArticulo.Text = "Agregar artículo";
            this.bbiAgregarArticulo.Click += new System.EventHandler(this.bbiAgregarArticulo_Click);
            // 
            // bbiEliminarArticulo
            // 
            this.bbiEliminarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("bbiEliminarArticulo.Image")));
            this.bbiEliminarArticulo.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarArticulo.LargeImage")));
            this.bbiEliminarArticulo.Name = "bbiEliminarArticulo";
            this.bbiEliminarArticulo.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarArticulo.SmallImage")));
            this.bbiEliminarArticulo.Text = "Eliminar artículo";
            this.bbiEliminarArticulo.Click += new System.EventHandler(this.bbiEliminarArticulo_Click);
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
            this.panel1.Controls.Add(this.dgvArticulos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 287);
            this.panel1.TabIndex = 2;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AutoGenerateColumns = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioCosteDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.campoAux1DataGridViewTextBoxColumn,
            this.campoAux2DataGridViewTextBoxColumn,
            this.campoAux3DataGridViewTextBoxColumn});
            this.dgvArticulos.DataSource = this.articuloBindingSource;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.Location = new System.Drawing.Point(0, 0);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(800, 287);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.DoubleClick += new System.EventHandler(this.dgvArticulos_DoubleClick);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioCosteDataGridViewTextBoxColumn
            // 
            this.precioCosteDataGridViewTextBoxColumn.DataPropertyName = "PrecioCoste";
            this.precioCosteDataGridViewTextBoxColumn.HeaderText = "PrecioCoste";
            this.precioCosteDataGridViewTextBoxColumn.Name = "precioCosteDataGridViewTextBoxColumn";
            this.precioCosteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // campoAux1DataGridViewTextBoxColumn
            // 
            this.campoAux1DataGridViewTextBoxColumn.DataPropertyName = "CampoAux1";
            this.campoAux1DataGridViewTextBoxColumn.HeaderText = "CampoAux1";
            this.campoAux1DataGridViewTextBoxColumn.Name = "campoAux1DataGridViewTextBoxColumn";
            this.campoAux1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // campoAux2DataGridViewTextBoxColumn
            // 
            this.campoAux2DataGridViewTextBoxColumn.DataPropertyName = "CampoAux2";
            this.campoAux2DataGridViewTextBoxColumn.HeaderText = "CampoAux2";
            this.campoAux2DataGridViewTextBoxColumn.Name = "campoAux2DataGridViewTextBoxColumn";
            this.campoAux2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // campoAux3DataGridViewTextBoxColumn
            // 
            this.campoAux3DataGridViewTextBoxColumn.DataPropertyName = "CampoAux3";
            this.campoAux3DataGridViewTextBoxColumn.HeaderText = "CampoAux3";
            this.campoAux3DataGridViewTextBoxColumn.Name = "campoAux3DataGridViewTextBoxColumn";
            this.campoAux3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(LibreriaERP.Clases.Articulos.Articulo);
            // 
            // frmVerArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmVerArticulos";
            this.Text = "Artículos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton bbiAgregarArticulo;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCosteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoAux1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoAux2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoAux3DataGridViewTextBoxColumn;
        private System.Windows.Forms.RibbonButton bbiEliminarArticulo;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton bbiSalir;
    }
}