namespace LibreriaERP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Configuración = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel8 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel9 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel10 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel11 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.bbiVerArticulos = new System.Windows.Forms.RibbonButton();
            this.bbiClientes = new System.Windows.Forms.RibbonButton();
            this.bbiProveedores = new System.Windows.Forms.RibbonButton();
            this.bbiVerPresupuestos = new System.Windows.Forms.RibbonButton();
            this.bbiVerPedidos = new System.Windows.Forms.RibbonButton();
            this.bbiVerAlbaranes = new System.Windows.Forms.RibbonButton();
            this.bbiVerFacturas = new System.Windows.Forms.RibbonButton();
            this.bbiPresupuestosCompra = new System.Windows.Forms.RibbonButton();
            this.bbiPedidosCompra = new System.Windows.Forms.RibbonButton();
            this.bbiEntradas = new System.Windows.Forms.RibbonButton();
            this.bbiFacturasCompra = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // Configuración
            // 
            this.Configuración.Name = "Configuración";
            this.Configuración.Panels.Add(this.ribbonPanel1);
            this.Configuración.Text = "Configuración";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonButton1);
            this.ribbonPanel1.Items.Add(this.ribbonButton2);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "";
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
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(800, 157);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.Configuración);
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTab4);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Artículos";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.bbiVerArticulos);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Panels.Add(this.ribbonPanel3);
            this.ribbonTab2.Text = "Comercial";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.bbiClientes);
            this.ribbonPanel3.Items.Add(this.bbiProveedores);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Panels.Add(this.ribbonPanel4);
            this.ribbonTab3.Panels.Add(this.ribbonPanel5);
            this.ribbonTab3.Panels.Add(this.ribbonPanel6);
            this.ribbonTab3.Panels.Add(this.ribbonPanel7);
            this.ribbonTab3.Text = "Ventas";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.bbiVerPresupuestos);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.bbiVerPedidos);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "";
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.bbiVerAlbaranes);
            this.ribbonPanel6.Name = "ribbonPanel6";
            this.ribbonPanel6.Text = "";
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.bbiVerFacturas);
            this.ribbonPanel7.Name = "ribbonPanel7";
            this.ribbonPanel7.Text = "";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 157);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(800, 293);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Panels.Add(this.ribbonPanel8);
            this.ribbonTab4.Panels.Add(this.ribbonPanel9);
            this.ribbonTab4.Panels.Add(this.ribbonPanel10);
            this.ribbonTab4.Panels.Add(this.ribbonPanel11);
            this.ribbonTab4.Text = "Compras";
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.Items.Add(this.bbiPresupuestosCompra);
            this.ribbonPanel8.Name = "ribbonPanel8";
            this.ribbonPanel8.Text = "";
            // 
            // ribbonPanel9
            // 
            this.ribbonPanel9.Items.Add(this.bbiPedidosCompra);
            this.ribbonPanel9.Name = "ribbonPanel9";
            this.ribbonPanel9.Text = "";
            // 
            // ribbonPanel10
            // 
            this.ribbonPanel10.Items.Add(this.bbiEntradas);
            this.ribbonPanel10.Name = "ribbonPanel10";
            this.ribbonPanel10.Text = "";
            // 
            // ribbonPanel11
            // 
            this.ribbonPanel11.Items.Add(this.bbiFacturasCompra);
            this.ribbonPanel11.Name = "ribbonPanel11";
            this.ribbonPanel11.Text = "";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Configuración";
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Usuarios";
            this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
            // 
            // bbiVerArticulos
            // 
            this.bbiVerArticulos.Image = ((System.Drawing.Image)(resources.GetObject("bbiVerArticulos.Image")));
            this.bbiVerArticulos.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiVerArticulos.LargeImage")));
            this.bbiVerArticulos.Name = "bbiVerArticulos";
            this.bbiVerArticulos.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiVerArticulos.SmallImage")));
            this.bbiVerArticulos.Text = "Ver artículos";
            this.bbiVerArticulos.Click += new System.EventHandler(this.bbiVerArticulos_Click);
            // 
            // bbiClientes
            // 
            this.bbiClientes.Image = ((System.Drawing.Image)(resources.GetObject("bbiClientes.Image")));
            this.bbiClientes.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiClientes.LargeImage")));
            this.bbiClientes.Name = "bbiClientes";
            this.bbiClientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiClientes.SmallImage")));
            this.bbiClientes.Text = "Clientes";
            this.bbiClientes.Click += new System.EventHandler(this.bbiClientes_Click);
            // 
            // bbiProveedores
            // 
            this.bbiProveedores.Image = ((System.Drawing.Image)(resources.GetObject("bbiProveedores.Image")));
            this.bbiProveedores.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiProveedores.LargeImage")));
            this.bbiProveedores.Name = "bbiProveedores";
            this.bbiProveedores.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiProveedores.SmallImage")));
            this.bbiProveedores.Text = "Proveedores";
            this.bbiProveedores.Click += new System.EventHandler(this.bbiProveedores_Click);
            // 
            // bbiVerPresupuestos
            // 
            this.bbiVerPresupuestos.Image = ((System.Drawing.Image)(resources.GetObject("bbiVerPresupuestos.Image")));
            this.bbiVerPresupuestos.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiVerPresupuestos.LargeImage")));
            this.bbiVerPresupuestos.Name = "bbiVerPresupuestos";
            this.bbiVerPresupuestos.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiVerPresupuestos.SmallImage")));
            this.bbiVerPresupuestos.Text = "Presupuestos";
            this.bbiVerPresupuestos.Click += new System.EventHandler(this.bbiVerPresupuestos_Click);
            // 
            // bbiVerPedidos
            // 
            this.bbiVerPedidos.Image = ((System.Drawing.Image)(resources.GetObject("bbiVerPedidos.Image")));
            this.bbiVerPedidos.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiVerPedidos.LargeImage")));
            this.bbiVerPedidos.Name = "bbiVerPedidos";
            this.bbiVerPedidos.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiVerPedidos.SmallImage")));
            this.bbiVerPedidos.Text = "Pedidos";
            this.bbiVerPedidos.Click += new System.EventHandler(this.bbiVerPedidos_Click);
            // 
            // bbiVerAlbaranes
            // 
            this.bbiVerAlbaranes.Image = ((System.Drawing.Image)(resources.GetObject("bbiVerAlbaranes.Image")));
            this.bbiVerAlbaranes.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiVerAlbaranes.LargeImage")));
            this.bbiVerAlbaranes.Name = "bbiVerAlbaranes";
            this.bbiVerAlbaranes.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiVerAlbaranes.SmallImage")));
            this.bbiVerAlbaranes.Text = "Albaranes";
            this.bbiVerAlbaranes.Click += new System.EventHandler(this.bbiVerAlbaranes_Click);
            // 
            // bbiVerFacturas
            // 
            this.bbiVerFacturas.Image = ((System.Drawing.Image)(resources.GetObject("bbiVerFacturas.Image")));
            this.bbiVerFacturas.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiVerFacturas.LargeImage")));
            this.bbiVerFacturas.Name = "bbiVerFacturas";
            this.bbiVerFacturas.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiVerFacturas.SmallImage")));
            this.bbiVerFacturas.Text = "Facturas";
            this.bbiVerFacturas.Click += new System.EventHandler(this.bbiVerFacturas_Click);
            // 
            // bbiPresupuestosCompra
            // 
            this.bbiPresupuestosCompra.Image = ((System.Drawing.Image)(resources.GetObject("bbiPresupuestosCompra.Image")));
            this.bbiPresupuestosCompra.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiPresupuestosCompra.LargeImage")));
            this.bbiPresupuestosCompra.Name = "bbiPresupuestosCompra";
            this.bbiPresupuestosCompra.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiPresupuestosCompra.SmallImage")));
            this.bbiPresupuestosCompra.Text = "Presupuestos";
            this.bbiPresupuestosCompra.Click += new System.EventHandler(this.bbiPresupuestosCompra_Click);
            // 
            // bbiPedidosCompra
            // 
            this.bbiPedidosCompra.Image = ((System.Drawing.Image)(resources.GetObject("bbiPedidosCompra.Image")));
            this.bbiPedidosCompra.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiPedidosCompra.LargeImage")));
            this.bbiPedidosCompra.Name = "bbiPedidosCompra";
            this.bbiPedidosCompra.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiPedidosCompra.SmallImage")));
            this.bbiPedidosCompra.Text = "Pedidos";
            this.bbiPedidosCompra.Click += new System.EventHandler(this.bbiPedidosCompra_Click);
            // 
            // bbiEntradas
            // 
            this.bbiEntradas.Image = ((System.Drawing.Image)(resources.GetObject("bbiEntradas.Image")));
            this.bbiEntradas.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiEntradas.LargeImage")));
            this.bbiEntradas.Name = "bbiEntradas";
            this.bbiEntradas.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiEntradas.SmallImage")));
            this.bbiEntradas.Text = "Entradas";
            this.bbiEntradas.Click += new System.EventHandler(this.bbiEntradas_Click);
            // 
            // bbiFacturasCompra
            // 
            this.bbiFacturasCompra.Image = ((System.Drawing.Image)(resources.GetObject("bbiFacturasCompra.Image")));
            this.bbiFacturasCompra.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiFacturasCompra.LargeImage")));
            this.bbiFacturasCompra.Name = "bbiFacturasCompra";
            this.bbiFacturasCompra.SmallImage = ((System.Drawing.Image)(resources.GetObject("bbiFacturasCompra.SmallImage")));
            this.bbiFacturasCompra.Text = "Facturas";
            this.bbiFacturasCompra.Click += new System.EventHandler(this.bbiFacturasCompra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "LibreriaERP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RibbonTab Configuración;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton bbiVerArticulos;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton bbiClientes;
        private System.Windows.Forms.RibbonButton bbiProveedores;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton bbiVerPresupuestos;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton bbiVerPedidos;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton bbiVerAlbaranes;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonButton bbiVerFacturas;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonPanel ribbonPanel8;
        private System.Windows.Forms.RibbonButton bbiPresupuestosCompra;
        private System.Windows.Forms.RibbonPanel ribbonPanel9;
        private System.Windows.Forms.RibbonButton bbiPedidosCompra;
        private System.Windows.Forms.RibbonPanel ribbonPanel10;
        private System.Windows.Forms.RibbonButton bbiEntradas;
        private System.Windows.Forms.RibbonPanel ribbonPanel11;
        private System.Windows.Forms.RibbonButton bbiFacturasCompra;
    }
}

