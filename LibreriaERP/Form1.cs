using LibreriaERP.Forms;
using LibreriaERP.Forms.Articulos;
using LibreriaERP.Forms.Clientes;
using LibreriaERP.Forms.ComprasYVentas;
using LibreriaERP.Forms.Proveedores;
using LibreriaERP.Forms.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaERP
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            frmConfiguracion frmConfiguracion = new frmConfiguracion();
            frmConfiguracion.ShowDialog();
        }

        private void bbiVerArticulos_Click(object sender, EventArgs e)
        {
            frmVerArticulos frmVerArticulos = new frmVerArticulos();
            frmVerArticulos.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmVerArticulos);
            frmVerArticulos.Show();
        }

        private void bbiClientes_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmClientes);
            frmClientes.Show();
        }

        private void bbiProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmProveedores);
            frmProveedores.Show();
        }

        private void bbiVerPresupuestos_Click(object sender, EventArgs e)
        {
            frmPresupuestosVenta frmPresupuestosVenta = new frmPresupuestosVenta();
            frmPresupuestosVenta.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmPresupuestosVenta);
            frmPresupuestosVenta.Show();
        }

        private void bbiVerPedidos_Click(object sender, EventArgs e)
        {
            frmPedidosVenta frmPedidosVenta = new frmPedidosVenta();
            frmPedidosVenta.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmPedidosVenta);
            frmPedidosVenta.Show();
        }

        private void bbiVerAlbaranes_Click(object sender, EventArgs e)
        {
            frmAlbaranes frmAlbaranes = new frmAlbaranes();
            frmAlbaranes.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmAlbaranes);
            frmAlbaranes.Show();
        }

        private void bbiVerFacturas_Click(object sender, EventArgs e)
        {
            frmFacturasVenta frmFacturasVenta = new frmFacturasVenta();
            frmFacturasVenta.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmFacturasVenta);
            frmFacturasVenta.Show();
        }

        private void bbiPresupuestosCompra_Click(object sender, EventArgs e)
        {
            frmPresupuestosCompra frmPresupuestosCompra = new frmPresupuestosCompra();
            frmPresupuestosCompra.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmPresupuestosCompra);
            frmPresupuestosCompra.Show();
        }

        private void bbiPedidosCompra_Click(object sender, EventArgs e)
        {
            frmPedidosCompra frmPedidosCompra = new frmPedidosCompra();
            frmPedidosCompra.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmPedidosCompra);
            frmPedidosCompra.Show();
        }

        private void bbiEntradas_Click(object sender, EventArgs e)
        {
            frmEntradas frmEntradas = new frmEntradas();
            frmEntradas.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmEntradas);
            frmEntradas.Show();
        }

        private void bbiFacturasCompra_Click(object sender, EventArgs e)
        {
            frmFacturasCompra frmFacturasCompra = new frmFacturasCompra();
            frmFacturasCompra.MdiParent = this;
            this.pnlPrincipal.Controls.Add(frmFacturasCompra);
            frmFacturasCompra.Show();
        }
    }
}
