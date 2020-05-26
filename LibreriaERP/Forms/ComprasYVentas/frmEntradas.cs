using LibreriaERP.Clases;
using LibreriaERP.Clases.Entradas;
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
    public partial class frmEntradas : Form
    {
        public frmEntradas()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            bsEntradas.DataSource = Entrada.GetAll(Conexiones.conexion);
            dgvEntradas.DataSource = bsEntradas;
        }

        private void bbiAgregarEntrada_Click(object sender, EventArgs e)
        {
            frmDocumento frmDocumento = new frmDocumento(6);
            frmDocumento.ShowDialog();
            CargarDatos();
        }

        private void bbiEliminarEntrada_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvEntradas.Rows[dgvEntradas.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvEntradas.Rows[dgvEntradas.CurrentRow.Index].Cells[1].Value.ToString();
            Entrada entrada = Entrada.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (entrada != null)
            {
                BindingListView<LineasEntrada> lineasEntradas = LineasEntrada.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasEntradas != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar la entrada: {entrada.Serie}-{entrada.Codigo}\n¿Está seguro?", "Eliminar Entrada", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var item in lineasEntradas)
                        {
                            LineasEntrada.Delete(Conexiones.conexion, item);
                        }
                        Entrada.Delete(Conexiones.conexion, entrada);
                        MessageBox.Show("Entrada eliminada");
                        CargarDatos();
                    }
                }
            }
        }

        private void dgvEntradas_DoubleClick(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvEntradas.Rows[dgvEntradas.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvEntradas.Rows[dgvEntradas.CurrentRow.Index].Cells[1].Value.ToString();

            Entrada entrada = Entrada.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (entrada != null)
            {
                BindingListView<LineasEntrada> lineasEntradas = LineasEntrada.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasEntradas != null)
                {
                    frmDocumento frmDocumento = new frmDocumento(entrada, lineasEntradas);
                    frmDocumento.ShowDialog();
                    CargarDatos();
                }
            }
        }

        private void bbiGenerarFactura_Click(object sender, EventArgs e)
        {
            int serie = Int32.Parse(dgvEntradas.Rows[dgvEntradas.CurrentRow.Index].Cells[0].Value.ToString());
            string codigo = dgvEntradas.Rows[dgvEntradas.CurrentRow.Index].Cells[1].Value.ToString();
            Entrada entrada = Entrada.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'").FirstOrDefault();

            if (entrada != null)
            {
                BindingListView<LineasEntrada> lineasEntradas = LineasEntrada.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");

                if (lineasEntradas != null)
                {

                    DialogResult dialogResult = MessageBox.Show($"Se va a crear una factura\n¿Está seguro?", "Generar factura", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        FacturaCompra facturaCompra = new FacturaCompra();
                        //pedidoVenta.Serie = presupuestoVenta.Serie;
                        //pedidoVenta.Codigo = presupuestoVenta.Codigo;
                        facturaCompra.Proveedor = entrada.Proveedor;
                        facturaCompra.Total = entrada.Total;
                        facturaCompra.Observaciones = entrada.Observaciones;
                        facturaCompra.DocumentoEvolucion = $"{entrada.Serie}-{entrada.Codigo}";

                        //PedidoVenta.Save(Conexiones.conexion, pedidoVenta);

                        BindingListView<LineasFacturaCompra> lineasFacturaCompras = new BindingListView<LineasFacturaCompra>();
                        foreach (LineasEntrada lineasEntrada in lineasEntradas)
                        {
                            LineasFacturaCompra linea = new LineasFacturaCompra();
                            //linea.Serie = lineaPresupuesto.Serie;
                            //linea.Codigo = lineaPresupuesto.Codigo;
                            //linea.Posicion = lineaPresupuesto.Posicion;
                            linea.CodArticulo = lineasEntrada.CodArticulo;
                            linea.Descripcion = lineasEntrada.Descripcion;
                            linea.Cantidad = lineasEntrada.Cantidad;
                            linea.PrecioVenta = lineasEntrada.PrecioVenta;

                            lineasFacturaCompras.Add(linea);
                        }

                        frmDocumento frmDocumento = new frmDocumento(facturaCompra, lineasFacturaCompras);
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
