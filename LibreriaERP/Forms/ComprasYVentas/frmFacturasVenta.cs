using LibreriaERP.Clases;
using LibreriaERP.Clases.FacturasVenta;
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
    public partial class frmFacturasVenta : Form
    {
        public frmFacturasVenta()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            bsFacturasVenta.DataSource = FacturaVenta.GetAll(Conexiones.conexion);
            dgvFacturasVenta.DataSource = bsFacturasVenta;
        }

        private void bbiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bbiAgregarFactura_Click(object sender, EventArgs e)
        {
            frmDocumento frmDocumento = new frmDocumento(3);
            frmDocumento.ShowDialog();
            CargarDatos();
        }

        private void bbiEliminarFactura_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvFacturasVenta.Rows[dgvFacturasVenta.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvFacturasVenta.Rows[dgvFacturasVenta.CurrentRow.Index].Cells[1].Value.ToString();
            FacturaVenta facturaVenta = FacturaVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (facturaVenta != null)
            {
                BindingListView<LineasFacturaVenta> lineasFacturaVentas = LineasFacturaVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasFacturaVentas != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar la factura: {facturaVenta.Serie}-{facturaVenta.Codigo}\n¿Está seguro?", "Eliminar Factura", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var item in lineasFacturaVentas)
                        {
                            LineasFacturaVenta.Delete(Conexiones.conexion, item);
                        }
                        FacturaVenta.Delete(Conexiones.conexion, facturaVenta);
                        MessageBox.Show("Factura eliminada");
                        CargarDatos();
                    }
                }
            }
        }

        private void dgvFacturasVenta_DoubleClick(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvFacturasVenta.Rows[dgvFacturasVenta.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvFacturasVenta.Rows[dgvFacturasVenta.CurrentRow.Index].Cells[1].Value.ToString();
            FacturaVenta facturaVenta = FacturaVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (facturaVenta != null)
            {
                BindingListView<LineasFacturaVenta> lineasFacturaVentas = LineasFacturaVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasFacturaVentas != null)
                {
                    frmDocumento frmDocumento = new frmDocumento(facturaVenta, lineasFacturaVentas);
                    frmDocumento.ShowDialog();
                    CargarDatos();
                }
            }
        }
    }
}
