using LibreriaERP.Clases;
using LibreriaERP.Clases.PedidosCompra;
using LibreriaERP.Clases.PresupuestosCompra;
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
    public partial class frmPresupuestosCompra : Form
    {
        public frmPresupuestosCompra()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            bsPresupuestosCompra.DataSource = PresupuestoCompra.GetAll(Conexiones.conexion);
            dgvPresupuestosCompra.DataSource = bsPresupuestosCompra;
        }

        private void bbiAgregarPresupuesto_Click(object sender, EventArgs e)
        {
            frmDocumento frmDocumento = new frmDocumento(4);
            frmDocumento.ShowDialog();
            CargarDatos();
        }

        private void bbiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPresupuestosCompra_DoubleClick(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPresupuestosCompra.Rows[dgvPresupuestosCompra.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPresupuestosCompra.Rows[dgvPresupuestosCompra.CurrentRow.Index].Cells[1].Value.ToString();

            PresupuestoCompra presupuestoCompra = PresupuestoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (presupuestoCompra != null)
            {
                BindingListView<LineasPresupuestoCompra> lineasPresupuestoCompras = LineasPresupuestoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPresupuestoCompras != null)
                {
                    frmDocumento frmDocumento = new frmDocumento(presupuestoCompra, lineasPresupuestoCompras);
                    frmDocumento.ShowDialog();
                    CargarDatos();
                }
            }
        }

        private void bbiEliminarPresupuesto_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPresupuestosCompra.Rows[dgvPresupuestosCompra.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPresupuestosCompra.Rows[dgvPresupuestosCompra.CurrentRow.Index].Cells[1].Value.ToString();
            PresupuestoCompra presupuestoCompra = PresupuestoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (presupuestoCompra != null)
            {
                BindingListView<LineasPresupuestoCompra> lineasPresupuestoCompras = LineasPresupuestoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPresupuestoCompras != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el presupuesto: {presupuestoCompra.Serie}-{presupuestoCompra.Codigo}\n¿Está seguro?", "Eliminar Presupuesto", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var item in lineasPresupuestoCompras)
                        {
                            LineasPresupuestoCompra.Delete(Conexiones.conexion, item);
                        }
                        PresupuestoCompra.Delete(Conexiones.conexion, presupuestoCompra);
                        MessageBox.Show("Presupuesto eliminado");
                        CargarDatos();
                    }
                }
            }
        }

        private void bbiGenerarPedido_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPresupuestosCompra.Rows[dgvPresupuestosCompra.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPresupuestosCompra.Rows[dgvPresupuestosCompra.CurrentRow.Index].Cells[1].Value.ToString();
            PresupuestoCompra presupuestoCompra = PresupuestoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (presupuestoCompra != null)
            {
                BindingListView<LineasPresupuestoCompra> lineasPresupuestoCompras = LineasPresupuestoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPresupuestoCompras != null)
                {

                    DialogResult dialogResult = MessageBox.Show($"Se va a crear un pedido\n¿Está seguro?", "Generar pedido", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        PedidoCompra pedidoCompra = new PedidoCompra();
                        //pedidoVenta.Serie = presupuestoVenta.Serie;
                        //pedidoVenta.Codigo = presupuestoVenta.Codigo;
                        pedidoCompra.Proveedor = presupuestoCompra.Proveedor;
                        pedidoCompra.Total = presupuestoCompra.Total;
                        pedidoCompra.Observaciones = presupuestoCompra.Observaciones;
                        pedidoCompra.DocumentoEvolucion = $"{presupuestoCompra.Serie}-{presupuestoCompra.Codigo}";

                        //PedidoVenta.Save(Conexiones.conexion, pedidoVenta);

                        BindingListView<LineasPedidoCompra> lineasPedidoCompras = new BindingListView<LineasPedidoCompra>();
                        foreach (LineasPresupuestoCompra lineaPresupuesto in lineasPresupuestoCompras)
                        {
                            LineasPedidoCompra linea = new LineasPedidoCompra();
                            //linea.Serie = lineaPresupuesto.Serie;
                            //linea.Codigo = lineaPresupuesto.Codigo;
                            //linea.Posicion = lineaPresupuesto.Posicion;
                            linea.CodArticulo = lineaPresupuesto.CodArticulo;
                            linea.Descripcion = lineaPresupuesto.Descripcion;
                            linea.Cantidad = lineaPresupuesto.Cantidad;
                            linea.PrecioVenta = lineaPresupuesto.PrecioVenta;

                            lineasPedidoCompras.Add(linea);
                        }

                        frmDocumento frmDocumento = new frmDocumento(pedidoCompra, lineasPedidoCompras);
                        frmDocumento.ShowDialog();
                    }
                }
            }
        }
    }
}
