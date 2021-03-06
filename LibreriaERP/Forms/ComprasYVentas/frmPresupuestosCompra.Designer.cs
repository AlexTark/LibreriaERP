﻿namespace LibreriaERP.Forms.ComprasYVentas
{
    partial class frmPresupuestosCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuestosCompra));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPresupuestosCompra = new System.Windows.Forms.DataGridView();
            this.bsPresupuestosCompra = new System.Windows.Forms.BindingSource(this.components);
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.bbiAgregarPresupuesto = new System.Windows.Forms.RibbonButton();
            this.bbiEliminarPresupuesto = new System.Windows.Forms.RibbonButton();
            this.bbiGenerarPedido = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.bbiSalir = new System.Windows.Forms.RibbonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuestosCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuestosCompra)).BeginInit();
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
            this.ribbon1.Size = new System.Drawing.Size(961, 164);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPresupuestosCompra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 382);
            this.panel1.TabIndex = 1;
            // 
            // dgvPresupuestosCompra
            // 
            this.dgvPresupuestosCompra.AllowUserToAddRows = false;
            this.dgvPresupuestosCompra.AllowUserToDeleteRows = false;
            this.dgvPresupuestosCompra.AutoGenerateColumns = false;
            this.dgvPresupuestosCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresupuestosCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPresupuestosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuestosCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serieDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dgvPresupuestosCompra.DataSource = this.bsPresupuestosCompra;
            this.dgvPresupuestosCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPresupuestosCompra.Location = new System.Drawing.Point(0, 0);
            this.dgvPresupuestosCompra.Name = "dgvPresupuestosCompra";
            this.dgvPresupuestosCompra.ReadOnly = true;
            this.dgvPresupuestosCompra.Size = new System.Drawing.Size(961, 382);
            this.dgvPresupuestosCompra.TabIndex = 0;
            this.dgvPresupuestosCompra.DoubleClick += new System.EventHandler(this.dgvPresupuestosCompra_DoubleClick);
            // 
            // bsPresupuestosCompra
            // 
            this.bsPresupuestosCompra.DataSource = typeof(LibreriaERP.Clases.PresupuestosCompra.PresupuestoCompra);
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
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Presupuestos compra";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.bbiAgregarPresupuesto);
            this.ribbonPanel1.Items.Add(this.bbiEliminarPresupuesto);
            this.ribbonPanel1.Items.Add(this.bbiGenerarPedido);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
            // 
            // bbiAgregarPresupuesto
            // 
            this.bbiAgregarPresupuesto.Image = ((System.Drawing.Image)(resources.GetObject("bbiAgregarPresupuesto.Image")));
            this.bbiAgregarPresupuesto.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarPresupuesto.LargeImage")));
            this.bbiAgregarPresupuesto.Name = "bbiAgregarPresupuesto";
            this.bbiAgregarPresupuesto.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiAgregarPresupuesto.SmallImage")));
            this.bbiAgregarPresupuesto.Text = "Nuevo presupuesto";
            this.bbiAgregarPresupuesto.Click += new System.EventHandler(this.bbiAgregarPresupuesto_Click);
            // 
            // bbiEliminarPresupuesto
            // 
            this.bbiEliminarPresupuesto.Image = ((System.Drawing.Image)(resources.GetObject("bbiEliminarPresupuesto.Image")));
            this.bbiEliminarPresupuesto.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarPresupuesto.LargeImage")));
            this.bbiEliminarPresupuesto.Name = "bbiEliminarPresupuesto";
            this.bbiEliminarPresupuesto.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiEliminarPresupuesto.SmallImage")));
            this.bbiEliminarPresupuesto.Text = "Eliminar presupuesto";
            this.bbiEliminarPresupuesto.Click += new System.EventHandler(this.bbiEliminarPresupuesto_Click);
            // 
            // bbiGenerarPedido
            // 
            this.bbiGenerarPedido.Image = ((System.Drawing.Image)(resources.GetObject("bbiGenerarPedido.Image")));
            this.bbiGenerarPedido.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGenerarPedido.LargeImage")));
            this.bbiGenerarPedido.Name = "bbiGenerarPedido";
            this.bbiGenerarPedido.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiGenerarPedido.SmallImage")));
            this.bbiGenerarPedido.Text = "Generar pedido";
            this.bbiGenerarPedido.Click += new System.EventHandler(this.bbiGenerarPedido_Click);
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
            // frmPresupuestosCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPresupuestosCompra";
            this.Text = "Presupuestos compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuestosCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuestosCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton bbiAgregarPresupuesto;
        private System.Windows.Forms.RibbonButton bbiEliminarPresupuesto;
        private System.Windows.Forms.RibbonButton bbiGenerarPedido;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton bbiSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPresupuestosCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsPresupuestosCompra;
    }
}