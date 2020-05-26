using LibreriaERP.Clases;
using LibreriaERP.Clases.Entradas;
using LibreriaERP.Clases.PedidosCompra;
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
    public partial class frmPedidosCompra : Form
    {
        public frmPedidosCompra()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            bsPedidosCompra.DataSource = PedidoCompra.GetAll(Conexiones.conexion);
            dgvPedidosCompra.DataSource = bsPedidosCompra;
        }

        private void bbiAgregarPedido_Click(object sender, EventArgs e)
        {
            frmDocumento frmDocumento = new frmDocumento(5);
            frmDocumento.ShowDialog();
            CargarDatos();
        }

        private void bbiEliminarPedido_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPedidosCompra.Rows[dgvPedidosCompra.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPedidosCompra.Rows[dgvPedidosCompra.CurrentRow.Index].Cells[1].Value.ToString();
            PedidoCompra pedidoCompra = PedidoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (pedidoCompra != null)
            {
                BindingListView<LineasPedidoCompra> lineasPedidoCompras = LineasPedidoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPedidoCompras != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el pedido: {pedidoCompra.Serie}-{pedidoCompra.Codigo}\n¿Está seguro?", "Eliminar Pedido", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var item in lineasPedidoCompras)
                        {
                            LineasPedidoCompra.Delete(Conexiones.conexion, item);
                        }
                        PedidoCompra.Delete(Conexiones.conexion, pedidoCompra);
                        MessageBox.Show("Pedido eliminado");
                        CargarDatos();
                    }
                }
            }
        }

        private void dgvPedidosCompra_DoubleClick(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPedidosCompra.Rows[dgvPedidosCompra.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPedidosCompra.Rows[dgvPedidosCompra.CurrentRow.Index].Cells[1].Value.ToString();

            PedidoCompra pedidoCompra = PedidoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (pedidoCompra != null)
            {
                BindingListView<LineasPedidoCompra> lineasPedidoCompras = LineasPedidoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPedidoCompras != null)
                {
                    frmDocumento frmDocumento = new frmDocumento(pedidoCompra, lineasPedidoCompras);
                    frmDocumento.ShowDialog();
                    CargarDatos();
                }
            }
        }

        private void bbiGenerarEntrada_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPedidosCompra.Rows[dgvPedidosCompra.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPedidosCompra.Rows[dgvPedidosCompra.CurrentRow.Index].Cells[1].Value.ToString();
            PedidoCompra pedidoCompra = PedidoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (pedidoCompra != null)
            {
                BindingListView<LineasPedidoCompra> lineasPedidoCompras = LineasPedidoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPedidoCompras != null)
                {

                    DialogResult dialogResult = MessageBox.Show($"Se va a crear una entrada\n¿Está seguro?", "Generar entrada", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Entrada entrada = new Entrada();
                        //pedidoVenta.Serie = presupuestoVenta.Serie;
                        //pedidoVenta.Codigo = presupuestoVenta.Codigo;
                        entrada.Proveedor = pedidoCompra.Proveedor;
                        entrada.Total = pedidoCompra.Total;
                        entrada.Observaciones = pedidoCompra.Observaciones;
                        entrada.DocumentoEvolucion = $"{pedidoCompra.Serie}-{pedidoCompra.Codigo}";

                        //PedidoVenta.Save(Conexiones.conexion, pedidoVenta);

                        BindingListView<LineasEntrada> lineasEntradas = new BindingListView<LineasEntrada>();
                        foreach (LineasPedidoCompra lineaPresupuesto in lineasPedidoCompras)
                        {
                            LineasEntrada linea = new LineasEntrada();
                            //linea.Serie = lineaPresupuesto.Serie;
                            //linea.Codigo = lineaPresupuesto.Codigo;
                            //linea.Posicion = lineaPresupuesto.Posicion;
                            linea.CodArticulo = lineaPresupuesto.CodArticulo;
                            linea.Descripcion = lineaPresupuesto.Descripcion;
                            linea.Cantidad = lineaPresupuesto.Cantidad;
                            linea.PrecioVenta = lineaPresupuesto.PrecioVenta;

                            lineasEntradas.Add(linea);
                        }

                        frmDocumento frmDocumento = new frmDocumento(entrada, lineasEntradas);
                        frmDocumento.ShowDialog();
                    }
                }
            }
        }

        private void bbiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
