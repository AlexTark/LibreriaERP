using LibreriaERP.Clases;
using LibreriaERP.Clases.FacturasCompra;
using Nowtic.Lib.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaERP.Forms.ComprasYVentas
{
    public partial class frmFacturasCompra : Form
    {
        public frmFacturasCompra()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            bsFacturasCompra.DataSource = FacturaCompra.GetAll(Conexiones.conexion);
            dgvFacturasCompra.DataSource = bsFacturasCompra;
        }

        private void bbiAgregarFactura_Click(object sender, EventArgs e)
        {
            frmDocumento frmDocumento = new frmDocumento(7);
            frmDocumento.ShowDialog();
            CargarDatos();
        }

        private void bbiEliminarFactura_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvFacturasCompra.Rows[dgvFacturasCompra.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvFacturasCompra.Rows[dgvFacturasCompra.CurrentRow.Index].Cells[1].Value.ToString();
            FacturaCompra facturaCompra = FacturaCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (facturaCompra != null)
            {
                BindingListView<LineasFacturaCompra> lineasFacturaCompras = LineasFacturaCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasFacturaCompras != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar la factura: {facturaCompra.Serie}-{facturaCompra.Codigo}\n¿Está seguro?", "Eliminar Factura", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var item in lineasFacturaCompras)
                        {
                            LineasFacturaCompra.Delete(Conexiones.conexion, item);
                        }
                        FacturaCompra.Delete(Conexiones.conexion, facturaCompra);
                        MessageBox.Show("Factura eliminada");
                        CargarDatos();
                    }
                }
            }
        }

        private void dgvFacturasCompra_DoubleClick(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvFacturasCompra.Rows[dgvFacturasCompra.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvFacturasCompra.Rows[dgvFacturasCompra.CurrentRow.Index].Cells[1].Value.ToString();

            FacturaCompra facturaCompra = FacturaCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (facturaCompra != null)
            {
                BindingListView<LineasFacturaCompra> lineasFacturaCompras = LineasFacturaCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasFacturaCompras != null)
                {
                    frmDocumento frmDocumento = new frmDocumento(facturaCompra, lineasFacturaCompras);
                    frmDocumento.ShowDialog();
                    CargarDatos();
                }
            }
        }

        private void bbiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
