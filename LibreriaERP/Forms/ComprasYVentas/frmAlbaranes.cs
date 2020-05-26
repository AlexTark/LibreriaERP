using LibreriaERP.Clases;
using LibreriaERP.Clases.Albaranes;
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
    public partial class frmAlbaranes : Form
    {
        public frmAlbaranes()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            bsAlbaranes.DataSource = Albaran.GetAll(Conexiones.conexion);
            dgvAlbaranes.DataSource = bsAlbaranes;
        }

        private void bbiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bbiAgregarAlbaran_Click(object sender, EventArgs e)
        {
            frmDocumento frmDocumento = new frmDocumento(2);
            frmDocumento.ShowDialog();
            CargarDatos();
        }

        private void bbiEliminarAlbaran_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvAlbaranes.Rows[dgvAlbaranes.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvAlbaranes.Rows[dgvAlbaranes.CurrentRow.Index].Cells[1].Value.ToString();
            Albaran albaran = Albaran.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (albaran != null)
            {
                BindingListView<LineasAlbaran> lineasAlbaran = LineasAlbaran.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasAlbaran != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el albarán: {albaran.Serie}-{albaran.Codigo}\n¿Está seguro?", "Eliminar Albarán", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var item in lineasAlbaran)
                        {
                            LineasAlbaran.Delete(Conexiones.conexion, item);
                        }
                        Albaran.Delete(Conexiones.conexion, albaran);
                        MessageBox.Show("Albarán eliminado");
                        CargarDatos();
                    }
                }
            }
        }

        private void dgvAlbaranes_DoubleClick(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvAlbaranes.Rows[dgvAlbaranes.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvAlbaranes.Rows[dgvAlbaranes.CurrentRow.Index].Cells[1].Value.ToString();
            Albaran albaran = Albaran.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (albaran != null)
            {
                BindingListView<LineasAlbaran> lineasAlbarans = LineasAlbaran.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasAlbarans != null)
                {
                    frmDocumento frmDocumento = new frmDocumento(albaran, lineasAlbarans);
                    frmDocumento.ShowDialog();
                    CargarDatos();
                }
            }
        }

        private void bbiGenerarFactura_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvAlbaranes.Rows[dgvAlbaranes.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvAlbaranes.Rows[dgvAlbaranes.CurrentRow.Index].Cells[1].Value.ToString();
            Albaran albaran = Albaran.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (albaran != null)
            {
                BindingListView<LineasAlbaran> lineasAlbarans = LineasAlbaran.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasAlbarans != null)
                {

                    DialogResult dialogResult = MessageBox.Show($"Se va a crear una factura de venta\n¿Está seguro?", "Generar Factura de venta", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        FacturaVenta facturaVenta = new FacturaVenta();
                        //pedidoVenta.Serie = presupuestoVenta.Serie;
                        //pedidoVenta.Codigo = presupuestoVenta.Codigo;
                        facturaVenta.Cliente = albaran.Cliente;
                        facturaVenta.Total = albaran.Total;
                        facturaVenta.Observaciones = albaran.Observaciones;
                        facturaVenta.DocumentoEvolucion = $"{albaran.Serie}-{albaran.Codigo}";

                        //PedidoVenta.Save(Conexiones.conexion, pedidoVenta);

                        BindingListView<LineasFacturaVenta> lineasFacturaVentas = new BindingListView<LineasFacturaVenta>();
                        foreach (LineasAlbaran lineaAlbaran in lineasAlbarans)
                        {
                            LineasFacturaVenta linea = new LineasFacturaVenta();
                            //linea.Serie = lineaPresupuesto.Serie;
                            //linea.Codigo = lineaPresupuesto.Codigo;
                            //linea.Posicion = lineaPresupuesto.Posicion;
                            linea.CodArticulo = lineaAlbaran.CodArticulo;
                            linea.Descripcion = lineaAlbaran.Descripcion;
                            linea.Cantidad = lineaAlbaran.Cantidad;
                            linea.PrecioCoste = lineaAlbaran.PrecioCoste;
                            linea.PrecioVenta = lineaAlbaran.PrecioVenta;

                            lineasFacturaVentas.Add(linea);
                        }

                        frmDocumento frmDocumento = new frmDocumento(facturaVenta, lineasFacturaVentas);
                        frmDocumento.ShowDialog();
                    }
                }
            }
        }
    }
}
