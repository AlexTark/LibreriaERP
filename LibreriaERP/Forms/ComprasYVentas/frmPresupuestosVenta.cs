using LibreriaERP.Clases;
using LibreriaERP.Clases.PedidosVenta;
using LibreriaERP.Clases.PresupuestosVenta;
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
    public partial class frmPresupuestosVenta : Form
    {
        public frmPresupuestosVenta()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            bsPresupuestosVenta.DataSource = PresupuestoVenta.GetAll(Conexiones.conexion);
            dgvPresupuestosVenta.DataSource = bsPresupuestosVenta;
        }

        private void bbiAgregarPresupuesto_Click(object sender, EventArgs e)
        {
            frmDocumento frmDocumento = new frmDocumento(0);
            frmDocumento.ShowDialog();
            CargarDatos();
        }

        private void bbiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPresupuestosVenta_DoubleClick(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPresupuestosVenta.Rows[dgvPresupuestosVenta.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPresupuestosVenta.Rows[dgvPresupuestosVenta.CurrentRow.Index].Cells[1].Value.ToString();
            PresupuestoVenta presupuestoVenta = PresupuestoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (presupuestoVenta != null)
            {
                BindingListView<LineasPresupuestoVenta> lineasPresupuestoVentas = LineasPresupuestoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPresupuestoVentas != null)
                {
                    frmDocumento frmDocumento = new frmDocumento(presupuestoVenta, lineasPresupuestoVentas);
                    frmDocumento.ShowDialog();
                    CargarDatos();
                }
            }
        }

        private void bbiEliminarPresupuesto_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPresupuestosVenta.Rows[dgvPresupuestosVenta.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPresupuestosVenta.Rows[dgvPresupuestosVenta.CurrentRow.Index].Cells[1].Value.ToString();
            PresupuestoVenta presupuestoVenta = PresupuestoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (presupuestoVenta != null)
            {
                BindingListView<LineasPresupuestoVenta> lineasPresupuestoVentas = LineasPresupuestoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPresupuestoVentas != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el presupuesto: {presupuestoVenta.Serie}-{presupuestoVenta.Codigo}\n¿Está seguro?", "Eliminar Presupuesto", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var item in lineasPresupuestoVentas)
                        {
                            LineasPresupuestoVenta.Delete(Conexiones.conexion, item);
                        }
                        PresupuestoVenta.Delete(Conexiones.conexion, presupuestoVenta);
                        MessageBox.Show("Presupuesto eliminado");
                        CargarDatos();
                    }
                }
            }
        }

        private void bbiGenerarPedido_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvPresupuestosVenta.Rows[dgvPresupuestosVenta.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvPresupuestosVenta.Rows[dgvPresupuestosVenta.CurrentRow.Index].Cells[1].Value.ToString();
            PresupuestoVenta presupuestoVenta = PresupuestoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (presupuestoVenta != null)
            {
                BindingListView<LineasPresupuestoVenta> lineasPresupuestoVentas = LineasPresupuestoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasPresupuestoVentas != null)
                {

                    DialogResult dialogResult = MessageBox.Show($"Se va a crear un pedido\n¿Está seguro?", "Generar pedido", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        PedidoVenta pedidoVenta = new PedidoVenta();
                        //pedidoVenta.Serie = presupuestoVenta.Serie;
                        //pedidoVenta.Codigo = presupuestoVenta.Codigo;
                        pedidoVenta.Cliente = presupuestoVenta.Cliente;
                        pedidoVenta.Total = presupuestoVenta.Total;
                        pedidoVenta.Observaciones = presupuestoVenta.Observaciones;
                        pedidoVenta.DocumentoEvolucion = $"{presupuestoVenta.Serie}-{presupuestoVenta.Codigo}";

                        //PedidoVenta.Save(Conexiones.conexion, pedidoVenta);

                        BindingListView<LineasPedidoVenta> lineasPedidoVentas = new BindingListView<LineasPedidoVenta>();
                        foreach (LineasPresupuestoVenta lineaPresupuesto in lineasPresupuestoVentas)
                        {
                            LineasPedidoVenta linea = new LineasPedidoVenta();
                            //linea.Serie = lineaPresupuesto.Serie;
                            //linea.Codigo = lineaPresupuesto.Codigo;
                            //linea.Posicion = lineaPresupuesto.Posicion;
                            linea.CodArticulo = lineaPresupuesto.CodArticulo;
                            linea.Descripcion = lineaPresupuesto.Descripcion;
                            linea.Cantidad = lineaPresupuesto.Cantidad;
                            linea.PrecioCoste = lineaPresupuesto.PrecioCoste;
                            linea.PrecioVenta = lineaPresupuesto.PrecioVenta;

                            lineasPedidoVentas.Add(linea);
                        }

                        frmDocumento frmDocumento = new frmDocumento(pedidoVenta, lineasPedidoVentas);
                        frmDocumento.ShowDialog();
                    }
                }
            }
        }
    }
}
