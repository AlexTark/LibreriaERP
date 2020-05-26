namespace LibreriaERP.Forms.Articulos
{
    partial class frmSelectorArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectorArticulo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCosteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoAux1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoAux2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoAux3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsArticulo = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvArticulos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 491);
            this.panel1.TabIndex = 0;
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
            this.imagenDataGridViewTextBoxColumn,
            this.campoAux1DataGridViewTextBoxColumn,
            this.campoAux2DataGridViewTextBoxColumn,
            this.campoAux3DataGridViewTextBoxColumn});
            this.dgvArticulos.DataSource = this.bsArticulo;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.Location = new System.Drawing.Point(0, 0);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(858, 491);
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
            // imagenDataGridViewTextBoxColumn
            // 
            this.imagenDataGridViewTextBoxColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewTextBoxColumn.HeaderText = "Imagen";
            this.imagenDataGridViewTextBoxColumn.Name = "imagenDataGridViewTextBoxColumn";
            this.imagenDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bsArticulo
            // 
            this.bsArticulo.DataSource = typeof(LibreriaERP.Clases.Articulos.Articulo);
            // 
            // frmSelectorArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 491);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectorArticulo";
            this.Text = "Seleccione artículo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCosteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoAux1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoAux2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoAux3DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsArticulo;
    }
}