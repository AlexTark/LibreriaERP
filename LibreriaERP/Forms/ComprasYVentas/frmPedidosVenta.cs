using LibreriaERP.Clases;
using LibreriaERP.Clases.Albaranes;
using LibreriaERP.Clases.PedidosVenta;
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
    public partial class frmPedidosVenta : Form
    {
        public frmPedidosVenta()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            bsPedidosVenta.DataSource = PedidoVenta.GetAll(Conexiones.conexion);
            dgvPedidosVenta.DataSource = bsPedidosVenta;
        }

        private void bbiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bbiAgregarPedido_Click(object sender, EventArgs e)
        {
            frmDocumento frmDocumento = new frmDocumento(1);
            frmDocumento.ShowDialog();
            CargarDatos();
        }

        private void dgvPedidosVenta_DoubleClick(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPedidosVenta.Rows[dgvPedidosVenta.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPedidosVenta.Rows[dgvPedidosVenta.CurrentRow.Index].Cells[1].Value.ToString();
            PedidoVenta pedidoVenta = PedidoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (pedidoVenta != null)
            {
                BindingListView<LineasPedidoVenta> lineasPedidoVentas = LineasPedidoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPedidoVentas != null)
                {
                    frmDocumento frmDocumento = new frmDocumento(pedidoVenta, lineasPedidoVentas);
                    frmDocumento.ShowDialog();
                    CargarDatos();
                }
            }
        }

        private void bbiEliminarPedido_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPedidosVenta.Rows[dgvPedidosVenta.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPedidosVenta.Rows[dgvPedidosVenta.CurrentRow.Index].Cells[1].Value.ToString();
            PedidoVenta pedidoVenta = PedidoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (pedidoVenta != null)
            {
                BindingListView<LineasPedidoVenta> lineasPedidoVentas = LineasPedidoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPedidoVentas != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el pedido: {pedidoVenta.Serie}-{pedidoVenta.Codigo}\n¿Está seguro?", "Eliminar Pedido", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var item in lineasPedidoVentas)
                        {
                            LineasPedidoVenta.Delete(Conexiones.conexion, item);
                        }
                        PedidoVenta.Delete(Conexiones.conexion, pedidoVenta);
                        MessageBox.Show("Pedido eliminado");
                        CargarDatos();
                    }
                }
            }
        }

        private void bbiGenerarAlbaran_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPedidosVenta.Rows[dgvPedidosVenta.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPedidosVenta.Rows[dgvPedidosVenta.CurrentRow.Index].Cells[1].Value.ToString();
            PedidoVenta pedidoVenta = PedidoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (pedidoVenta != null)
            {
                BindingListView<LineasPedidoVenta> lineasPedidoVentas = LineasPedidoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPedidoVentas != null)
                {

                    DialogResult dialogResult = MessageBox.Show($"Se va a crear un albarán\n¿Está seguro?", "Generar Albaran", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Albaran albaran = new Albaran();
                        //pedidoVenta.Serie = presupuestoVenta.Serie;
                        //pedidoVenta.Codigo = presupuestoVenta.Codigo;
                        albaran.Cliente = pedidoVenta.Cliente;
                        albaran.Total = pedidoVenta.Total;
                        albaran.Observaciones = pedidoVenta.Observaciones;
                        albaran.DocumentoEvolucion = $"{pedidoVenta.Serie}-{pedidoVenta.Codigo}";

                        //PedidoVenta.Save(Conexiones.conexion, pedidoVenta);

                        BindingListView<LineasAlbaran> lineasAlbaran = new BindingListView<LineasAlbaran>();
                        foreach (LineasPedidoVenta lineaPedido in lineasPedidoVentas)
                        {
                            LineasAlbaran linea = new LineasAlbaran();
                            //linea.Serie = lineaPresupuesto.Serie;
                            //linea.Codigo = lineaPresupuesto.Codigo;
                            //linea.Posicion = lineaPresupuesto.Posicion;
                            linea.CodArticulo = lineaPedido.CodArticulo;
                            linea.Descripcion = lineaPedido.Descripcion;
                            linea.Cantidad = lineaPedido.Cantidad;
                            linea.PrecioCoste = lineaPedido.PrecioCoste;
                            linea.PrecioVenta = lineaPedido.PrecioVenta;

                            lineasAlbaran.Add(linea);
                        }

                        frmDocumento frmDocumento = new frmDocumento(albaran, lineasAlbaran);
                        frmDocumento.ShowDialog();
                    }
                }
            }
        }
    }
}
