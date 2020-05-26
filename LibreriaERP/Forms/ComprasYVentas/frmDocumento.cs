using LibreriaERP.Clases;
using LibreriaERP.Clases.Albaranes;
using LibreriaERP.Clases.Articulos;
using LibreriaERP.Clases.Clientes;
using LibreriaERP.Clases.Entradas;
using LibreriaERP.Clases.FacturasCompra;
using LibreriaERP.Clases.FacturasVenta;
using LibreriaERP.Clases.PedidosCompra;
using LibreriaERP.Clases.PedidosVenta;
using LibreriaERP.Clases.PresupuestosCompra;
using LibreriaERP.Clases.PresupuestosVenta;
using LibreriaERP.Clases.Proveedores;
using LibreriaERP.Forms.Articulos;
using LibreriaERP.Forms.Clientes;
using LibreriaERP.Forms.Proveedores;
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
    public partial class frmDocumento : Form
    {
        //---------------- VENTAS --------------------------

        PresupuestoVenta presupuestoVenta;
        PedidoVenta pedidoVenta;
        Albaran albaran;
        FacturaVenta facturaVenta;

        BindingListView<LineasPresupuestoVenta> lineasPresupuestoVenta;
        BindingListView<LineasPedidoVenta> lineasPedidoVenta;
        BindingListView<LineasAlbaran> lineasAlbaran;
        BindingListView<LineasFacturaVenta> lineasFacturaVenta;

        //----------------- COMPRAS -----------------------------

        PresupuestoCompra presupuestoCompra;
        PedidoCompra pedidoCompra;
        Entrada entrada;
        FacturaCompra facturaCompra;

        BindingListView<LineasPresupuestoCompra> lineasPresupuestoCompras;
        BindingListView<LineasPedidoCompra> lineasPedidoCompras;
        BindingListView<LineasEntrada> lineasEntradas;
        BindingListView<LineasFacturaCompra> lineasFacturaCompras;

        public frmDocumento(PresupuestoVenta presupuestoVenta, BindingListView<LineasPresupuestoVenta> lineasPresupuestoVenta)
        {
            InitializeComponent();
            this.presupuestoVenta = presupuestoVenta;
            this.lineasPresupuestoVenta = lineasPresupuestoVenta;
            bsLineasPresupuestoVenta.DataSource = this.lineasPresupuestoVenta;
            dgvLineas.DataSource = bsLineasPresupuestoVenta;
            txtSerie.Enabled = false;
            txtCodigo.Enabled = false;

            //Introduzco los campos del presupuesto
            txtSerie.Text = this.presupuestoVenta.Serie.ToString();
            txtCodigo.Text = this.presupuestoVenta.Codigo.ToString();
            txtCliente.Text = this.presupuestoVenta.Cliente.ToString();
            Cliente cliente = Cliente.GetWhere(Conexiones.conexion, $"Id = {this.presupuestoVenta.Cliente}").FirstOrDefault();
            if (cliente != null)
            {
                txtNombreCliente.Text = cliente.NombreFiscal;
                txtDireccionCliente.Text = cliente.Direccion;
            }
            txtTotal.Text = this.presupuestoVenta.Total.ToString();
            memoObservaciones.Text = this.presupuestoVenta.Observaciones.ToString();
        }
        public frmDocumento(PedidoVenta pedidoVenta, BindingListView<LineasPedidoVenta> lineasPedidoVenta)
        {
            InitializeComponent();
            this.pedidoVenta = pedidoVenta;
            this.lineasPedidoVenta = lineasPedidoVenta;
            bsLineasPedidoVenta.DataSource = this.lineasPedidoVenta;
            dgvLineas.DataSource = bsLineasPedidoVenta;

            //Introduzco los campos del pedido
            if (this.pedidoVenta.Serie.Equals("") || this.pedidoVenta.Codigo.Equals(""))
            {
                txtSerie.Enabled = true;
                txtCodigo.Enabled = true;
            }
            else
            {
                txtSerie.Enabled = false;
                txtCodigo.Enabled = false;
            }
            txtSerie.Text = this.pedidoVenta.Serie.ToString();
            txtCodigo.Text = this.pedidoVenta.Codigo.ToString();
            txtCliente.Text = this.pedidoVenta.Cliente.ToString();
            Cliente cliente = Cliente.GetWhere(Conexiones.conexion, $"Id = {this.pedidoVenta.Cliente}").FirstOrDefault();
            if (cliente != null)
            {
                txtNombreCliente.Text = cliente.NombreFiscal;
                txtDireccionCliente.Text = cliente.Direccion;
            }
            txtTotal.Text = this.pedidoVenta.Total.ToString();
            memoObservaciones.Text = this.pedidoVenta.Observaciones.ToString();
        }
        public frmDocumento(Albaran albaran, BindingListView<LineasAlbaran> lineasAlbaran)
        {
            InitializeComponent();
            this.albaran = albaran;
            this.lineasAlbaran = lineasAlbaran;
            bsLineasAlbaran.DataSource = this.lineasAlbaran;
            dgvLineas.DataSource = bsLineasAlbaran;

            //Introduczo los campos del albaran
            if (this.albaran.Serie.Equals("") || this.albaran.Codigo.Equals(""))
            {
                txtSerie.Enabled = true;
                txtCodigo.Enabled = true;
            }
            else
            {
                txtSerie.Enabled = false;
                txtCodigo.Enabled = false;
            }
            txtSerie.Text = this.albaran.Serie.ToString();
            txtCodigo.Text = this.albaran.Codigo.ToString();
            txtCliente.Text = this.albaran.Cliente.ToString();
            Cliente cliente = Cliente.GetWhere(Conexiones.conexion, $"Id = {this.albaran.Cliente}").FirstOrDefault();
            if (cliente != null)
            {
                txtNombreCliente.Text = cliente.NombreFiscal;
                txtDireccionCliente.Text = cliente.Direccion;
            }
            txtTotal.Text = this.albaran.Total.ToString();
            memoObservaciones.Text = this.albaran.Observaciones.ToString();
        }
        public frmDocumento(FacturaVenta facturaVenta, BindingListView<LineasFacturaVenta> lineasFacturaVenta)
        {
            InitializeComponent();
            this.facturaVenta = facturaVenta;
            this.lineasFacturaVenta = lineasFacturaVenta;
            bsLineasFacturaVenta.DataSource = this.lineasFacturaVenta;
            dgvLineas.DataSource = bsLineasFacturaVenta;

            //Introduzco los campos de la factura
            if (this.facturaVenta.Serie.Equals("") || this.facturaVenta.Codigo.Equals(""))
            {
                txtSerie.Enabled = true;
                txtCodigo.Enabled = true;
            }
            else
            {
                txtSerie.Enabled = false;
                txtCodigo.Enabled = false;
            }
            txtSerie.Text = this.facturaVenta.Serie.ToString();
            txtCodigo.Text = this.facturaVenta.Codigo.ToString();
            txtCliente.Text = this.facturaVenta.Cliente.ToString();
            Cliente cliente = Cliente.GetWhere(Conexiones.conexion, $"Id = {this.facturaVenta.Cliente}").FirstOrDefault();
            if (cliente != null)
            {
                txtNombreCliente.Text = cliente.NombreFiscal;
                txtDireccionCliente.Text = cliente.Direccion;
            }
            txtTotal.Text = this.facturaVenta.Total.ToString();
            memoObservaciones.Text = this.facturaVenta.Observaciones.ToString();
        }

        public frmDocumento(PresupuestoCompra presupuestoCompra, BindingListView<LineasPresupuestoCompra> lineasPresupuestoCompras)
        {
            InitializeComponent();
            this.presupuestoCompra = presupuestoCompra;
            this.lineasPresupuestoCompras = lineasPresupuestoCompras;
            bsLineasPresupuestoCompra.DataSource = this.lineasPresupuestoCompras;
            dgvLineas.DataSource = bsLineasPresupuestoCompra;

            //Introducto los campos del presupuesto
            lblClienteProveedor.Text = "Proveedor:";
            txtSerie.Text = this.presupuestoCompra.Serie.ToString();
            txtCodigo.Text = this.presupuestoCompra.Codigo.ToString();
            txtCliente.Text = this.presupuestoCompra.Proveedor.ToString();
            Proveedor proveedor = Proveedor.GetWhere(Conexiones.conexion, $"Id = {this.presupuestoCompra.Proveedor}").FirstOrDefault();
            if (proveedor != null)
            {
                txtNombreCliente.Text = proveedor.NombreFiscal;
                txtDireccionCliente.Text = proveedor.Direccion;
            }
            txtTotal.Text = this.presupuestoCompra.Total.ToString();
            memoObservaciones.Text = this.presupuestoCompra.Observaciones.ToString();
        }

        public frmDocumento(PedidoCompra pedidoCompra, BindingListView<LineasPedidoCompra> lineasPedidoCompras)
        {
            InitializeComponent();
            this.pedidoCompra = pedidoCompra;
            this.lineasPedidoCompras = lineasPedidoCompras;
            bsLineasPedidoCompra.DataSource = this.lineasPedidoCompras;
            dgvLineas.DataSource = bsLineasPedidoCompra;

            //Introducto los campos del pedido
            if (this.pedidoCompra.Serie.Equals("") || this.pedidoCompra.Codigo.Equals(""))
            {
                txtSerie.Enabled = true;
                txtCodigo.Enabled = true;
            }
            else
            {
                txtSerie.Enabled = false;
                txtCodigo.Enabled = false;
            }
            lblClienteProveedor.Text = "Proveedor:";
            txtSerie.Text = this.pedidoCompra.Serie.ToString();
            txtCodigo.Text = this.pedidoCompra.Codigo.ToString();
            txtCliente.Text = this.pedidoCompra.Proveedor.ToString();
            Proveedor proveedor = Proveedor.GetWhere(Conexiones.conexion, $"Id = {this.pedidoCompra.Proveedor}").FirstOrDefault();
            if (proveedor != null)
            {
                txtNombreCliente.Text = proveedor.NombreFiscal;
                txtDireccionCliente.Text = proveedor.Direccion;
            }
            txtTotal.Text = this.pedidoCompra.Total.ToString();
            memoObservaciones.Text = this.pedidoCompra.Observaciones.ToString();
        }

        public frmDocumento(Entrada entrada, BindingListView<LineasEntrada> lineasEntradas)
        {
            InitializeComponent();
            this.entrada = entrada;
            this.lineasEntradas = lineasEntradas;
            bsLineasEntrada.DataSource = this.lineasEntradas;
            dgvLineas.DataSource = bsLineasEntrada;

            //Introducto los campos de la entrada
            if (this.entrada.Serie.Equals("") || this.entrada.Codigo.Equals(""))
            {
                txtSerie.Enabled = true;
                txtCodigo.Enabled = true;
            }
            else
            {
                txtSerie.Enabled = false;
                txtCodigo.Enabled = false;
            }
            lblClienteProveedor.Text = "Proveedor:";
            txtSerie.Text = this.entrada.Serie.ToString();
            txtCodigo.Text = this.entrada.Codigo.ToString();
            txtCliente.Text = this.entrada.Proveedor.ToString();
            Proveedor proveedor = Proveedor.GetWhere(Conexiones.conexion, $"Id = {this.entrada.Proveedor}").FirstOrDefault();
            if (proveedor != null)
            {
                txtNombreCliente.Text = proveedor.NombreFiscal;
                txtDireccionCliente.Text = proveedor.Direccion;
            }
            txtTotal.Text = this.entrada.Total.ToString();
            memoObservaciones.Text = this.entrada.Observaciones.ToString();
        }

        public frmDocumento(FacturaCompra facturaCompra, BindingListView<LineasFacturaCompra> lineasFacturaCompras)
        {
            InitializeComponent();
            this.facturaCompra = facturaCompra;
            this.lineasFacturaCompras = lineasFacturaCompras;
            bsLineasFacturaCompra.DataSource = this.lineasFacturaCompras;
            dgvLineas.DataSource = bsLineasFacturaCompra;

            //Introducto los campos de la factura
            if (this.facturaCompra.Serie.Equals("") || this.facturaCompra.Codigo.Equals(""))
            {
                txtSerie.Enabled = true;
                txtCodigo.Enabled = true;
            }
            else
            {
                txtSerie.Enabled = false;
                txtCodigo.Enabled = false;
            }
            lblClienteProveedor.Text = "Proveedor:";
            txtSerie.Text = this.facturaCompra.Serie.ToString();
            txtCodigo.Text = this.facturaCompra.Codigo.ToString();
            txtCliente.Text = this.facturaCompra.Proveedor.ToString();
            Proveedor proveedor = Proveedor.GetWhere(Conexiones.conexion, $"Id = {this.facturaCompra.Proveedor}").FirstOrDefault();
            if (proveedor != null)
            {
                txtNombreCliente.Text = proveedor.NombreFiscal;
                txtDireccionCliente.Text = proveedor.Direccion;
            }
            txtTotal.Text = this.facturaCompra.Total.ToString();
            memoObservaciones.Text = this.facturaCompra.Observaciones.ToString();
        }

        public frmDocumento(int codigo)
        {
            InitializeComponent();
            switch (codigo)
            {
                case 0:
                    this.presupuestoVenta = new PresupuestoVenta();
                    this.lineasPresupuestoVenta = new BindingListView<LineasPresupuestoVenta>();
                    bsLineasPresupuestoVenta.DataSource = this.lineasPresupuestoVenta;
                    dgvLineas.DataSource = bsLineasPresupuestoVenta;
                    break;
                case 1:
                    this.pedidoVenta = new PedidoVenta();
                    this.lineasPedidoVenta = new BindingListView<LineasPedidoVenta>();
                    bsLineasPedidoVenta.DataSource = this.lineasPedidoVenta;
                    dgvLineas.DataSource = bsLineasPedidoVenta;
                    break;
                case 2:
                    this.albaran = new Albaran();
                    this.lineasAlbaran = new BindingListView<LineasAlbaran>();
                    bsLineasAlbaran.DataSource = this.lineasAlbaran;
                    dgvLineas.DataSource = bsLineasAlbaran;
                    break;
                case 3:
                    this.facturaVenta = new FacturaVenta();
                    this.lineasFacturaVenta = new BindingListView<LineasFacturaVenta>();
                    bsLineasFacturaVenta.DataSource = this.lineasFacturaVenta;
                    dgvLineas.DataSource = bsLineasFacturaVenta;
                    break;
                case 4:
                    lblClienteProveedor.Text = "Proveedor:";
                    this.presupuestoCompra = new PresupuestoCompra();
                    this.lineasPresupuestoCompras = new BindingListView<LineasPresupuestoCompra>();
                    bsLineasPresupuestoCompra.DataSource = this.lineasPresupuestoCompras;
                    dgvLineas.DataSource = bsLineasPresupuestoCompra;
                    break;
                case 5:
                    lblClienteProveedor.Text = "Proveedor:";
                    this.pedidoCompra = new PedidoCompra();
                    this.lineasPedidoCompras = new BindingListView<LineasPedidoCompra>();
                    bsLineasPedidoCompra.DataSource = this.lineasPedidoCompras;
                    dgvLineas.DataSource = bsLineasPedidoCompra;
                    break;
                case 6:
                    lblClienteProveedor.Text = "Proveedor:";
                    this.entrada = new Entrada();
                    this.lineasEntradas = new BindingListView<LineasEntrada>();
                    bsLineasEntrada.DataSource = this.lineasEntradas;
                    dgvLineas.DataSource = bsLineasEntrada;
                    break;
                case 7:
                    lblClienteProveedor.Text = "Proveedor:";
                    this.facturaCompra = new FacturaCompra();
                    this.lineasFacturaCompras = new BindingListView<LineasFacturaCompra>();
                    bsLineasFacturaCompra.DataSource = this.lineasFacturaCompras;
                    dgvLineas.DataSource = bsLineasFacturaCompra;
                    break;
            }
        }

        private void bbiAgregarArticulo_Click(object sender, EventArgs e)
        {
            if (!txtSerie.Text.Equals("") && !txtCodigo.Text.Equals(""))
            {
                frmSelectorArticulo frmSelector = new frmSelectorArticulo();
                frmSelector.ShowDialog();
                Articulo articulo = frmSelector.ArticuloSeleccionado;
                if (articulo != null)
                {
                    if (lineasPresupuestoVenta != null)
                    {
                        LineasPresupuestoVenta linea = new LineasPresupuestoVenta();
                        linea.Serie = Int32.Parse(txtSerie.Text.ToString());
                        linea.Codigo = txtCodigo.Text.ToString();
                        linea.Posicion = Conexiones.SiguientePosicion("LineasPresupuestoVenta", linea.Serie, linea.Codigo);
                        linea.CodArticulo = articulo.Codigo;
                        linea.Descripcion = articulo.Descripcion;
                        linea.Cantidad = 1;
                        linea.PrecioCoste = articulo.PrecioCoste;
                        LineasPresupuestoVenta.Save(Conexiones.conexion, linea);
                        //lineasPresupuestoVenta.Add(linea);
                        //bsLineasPresupuestoVenta.DataSource = this.lineasPresupuestoVenta;
                        bsLineasPresupuestoVenta.DataSource = LineasPresupuestoVenta.GetWhere(Conexiones.conexion, $"Serie = {linea.Serie} AND Codigo = '{linea.Codigo}'");
                        dgvLineas.DataSource = bsLineasPresupuestoVenta;
                        dgvLineas.Refresh();
                    }

                    if (lineasPedidoVenta != null)
                    {
                        LineasPedidoVenta linea = new LineasPedidoVenta();
                        linea.Serie = Int32.Parse(txtSerie.Text.ToString());
                        linea.Codigo = txtCodigo.Text.ToString();
                        linea.Posicion = Conexiones.SiguientePosicion("LineasPedidoVenta", linea.Serie, linea.Codigo);
                        linea.CodArticulo = articulo.Codigo;
                        linea.Descripcion = articulo.Descripcion;
                        linea.Cantidad = 1;
                        linea.PrecioCoste = articulo.PrecioCoste;
                        LineasPedidoVenta.Save(Conexiones.conexion, linea);
                        //lineasPresupuestoVenta.Add(linea);
                        //bsLineasPresupuestoVenta.DataSource = this.lineasPresupuestoVenta;
                        bsLineasPedidoVenta.DataSource = LineasPedidoVenta.GetWhere(Conexiones.conexion, $"Serie = {linea.Serie} AND Codigo = '{linea.Codigo}'");
                        dgvLineas.DataSource = bsLineasPedidoVenta;
                        dgvLineas.Refresh();
                    }

                    if (lineasAlbaran != null)
                    {
                        LineasAlbaran linea = new LineasAlbaran();
                        linea.Serie = Int32.Parse(txtSerie.Text.ToString());
                        linea.Codigo = txtCodigo.Text.ToString();
                        linea.Posicion = Conexiones.SiguientePosicion("LineasAlbaran", linea.Serie, linea.Codigo);
                        linea.CodArticulo = articulo.Codigo;
                        linea.Descripcion = articulo.Descripcion;
                        linea.Cantidad = 1;
                        linea.PrecioCoste = articulo.PrecioCoste;
                        LineasAlbaran.Save(Conexiones.conexion, linea);
                        //lineasPresupuestoVenta.Add(linea);
                        //bsLineasPresupuestoVenta.DataSource = this.lineasPresupuestoVenta;
                        bsLineasAlbaran.DataSource = LineasAlbaran.GetWhere(Conexiones.conexion, $"Serie = {linea.Serie} AND Codigo = '{linea.Codigo}'");
                        dgvLineas.DataSource = bsLineasAlbaran;
                        dgvLineas.Refresh();
                    }

                    if (lineasFacturaVenta != null)
                    {
                        LineasFacturaVenta linea = new LineasFacturaVenta();
                        linea.Serie = Int32.Parse(txtSerie.Text.ToString());
                        linea.Codigo = txtCodigo.Text.ToString();
                        linea.Posicion = Conexiones.SiguientePosicion("LineasFactura", linea.Serie, linea.Codigo);
                        linea.CodArticulo = articulo.Codigo;
                        linea.Descripcion = articulo.Descripcion;
                        linea.Cantidad = 1;
                        linea.PrecioCoste = articulo.PrecioCoste;
                        LineasFacturaVenta.Save(Conexiones.conexion, linea);
                        //lineasPresupuestoVenta.Add(linea);
                        //bsLineasPresupuestoVenta.DataSource = this.lineasPresupuestoVenta;
                        bsLineasFacturaVenta.DataSource = LineasAlbaran.GetWhere(Conexiones.conexion, $"Serie = {linea.Serie} AND Codigo = '{linea.Codigo}'");
                        dgvLineas.DataSource = bsLineasFacturaVenta;
                        dgvLineas.Refresh();
                    }

                    if (lineasPresupuestoCompras != null)
                    {
                        LineasPresupuestoCompra linea = new LineasPresupuestoCompra();
                        linea.Serie = Int32.Parse(txtSerie.Text.ToString());
                        linea.Codigo = txtCodigo.Text.ToString();
                        linea.Posicion = Conexiones.SiguientePosicion("LineasPresupuestoCompra", linea.Serie, linea.Codigo);
                        linea.CodArticulo = articulo.Codigo;
                        linea.Descripcion = articulo.Descripcion;
                        linea.Cantidad = 1;
                        LineasPresupuestoCompra.Save(Conexiones.conexion, linea);
                        //lineasPresupuestoVenta.Add(linea);
                        //bsLineasPresupuestoVenta.DataSource = this.lineasPresupuestoVenta;
                        bsLineasPresupuestoCompra.DataSource = LineasPresupuestoCompra.GetWhere(Conexiones.conexion, $"Serie = {linea.Serie} AND Codigo = '{linea.Codigo}'");
                        dgvLineas.DataSource = bsLineasPresupuestoCompra;
                        dgvLineas.Refresh();
                    }

                    if (lineasPedidoCompras != null)
                    {
                        LineasPedidoCompra linea = new LineasPedidoCompra();
                        linea.Serie = Int32.Parse(txtSerie.Text.ToString());
                        linea.Codigo = txtCodigo.Text.ToString();
                        linea.Posicion = Conexiones.SiguientePosicion("LineasPedidoCompra", linea.Serie, linea.Codigo);
                        linea.CodArticulo = articulo.Codigo;
                        linea.Descripcion = articulo.Descripcion;
                        linea.Cantidad = 1;
                        LineasPedidoCompra.Save(Conexiones.conexion, linea);
                        //lineasPresupuestoVenta.Add(linea);
                        //bsLineasPresupuestoVenta.DataSource = this.lineasPresupuestoVenta;
                        bsLineasPedidoCompra.DataSource = LineasPedidoCompra.GetWhere(Conexiones.conexion, $"Serie = {linea.Serie} AND Codigo = '{linea.Codigo}'");
                        dgvLineas.DataSource = bsLineasPedidoCompra;
                        dgvLineas.Refresh();
                    }

                    if (lineasEntradas != null)
                    {
                        LineasEntrada linea = new LineasEntrada();
                        linea.Serie = Int32.Parse(txtSerie.Text.ToString());
                        linea.Codigo = txtCodigo.Text.ToString();
                        linea.Posicion = Conexiones.SiguientePosicion("LineasEntrada", linea.Serie, linea.Codigo);
                        linea.CodArticulo = articulo.Codigo;
                        linea.Descripcion = articulo.Descripcion;
                        linea.Cantidad = 1;
                        LineasEntrada.Save(Conexiones.conexion, linea);
                        //lineasPresupuestoVenta.Add(linea);
                        //bsLineasPresupuestoVenta.DataSource = this.lineasPresupuestoVenta;
                        bsLineasEntrada.DataSource = LineasEntrada.GetWhere(Conexiones.conexion, $"Serie = {linea.Serie} AND Codigo = '{linea.Codigo}'");
                        dgvLineas.DataSource = bsLineasEntrada;
                        dgvLineas.Refresh();
                    }

                    if (lineasFacturaCompras != null)
                    {
                        LineasFacturaCompra linea = new LineasFacturaCompra();
                        linea.Serie = Int32.Parse(txtSerie.Text.ToString());
                        linea.Codigo = txtCodigo.Text.ToString();
                        linea.Posicion = Conexiones.SiguientePosicion("LineasFacturaCompra", linea.Serie, linea.Codigo);
                        linea.CodArticulo = articulo.Codigo;
                        linea.Descripcion = articulo.Descripcion;
                        linea.Cantidad = 1;
                        LineasFacturaCompra.Save(Conexiones.conexion, linea);
                        //lineasPresupuestoVenta.Add(linea);
                        //bsLineasPresupuestoVenta.DataSource = this.lineasPresupuestoVenta;
                        bsLineasFacturaCompra.DataSource = LineasFacturaCompra.GetWhere(Conexiones.conexion, $"Serie = {linea.Serie} AND Codigo = '{linea.Codigo}'");
                        dgvLineas.DataSource = bsLineasFacturaCompra;
                        dgvLineas.Refresh();
                    }
                }
            }
            
            Guardar();
        }

        private void bbiBuscarClienteProveedor_Click(object sender, EventArgs e)
        {
            if (presupuestoVenta != null || pedidoVenta != null || albaran != null || facturaVenta != null)
            {
                frmSeleccionarCliente frmSeleccionar = new frmSeleccionarCliente();
                frmSeleccionar.ShowDialog();
                Cliente cliente = frmSeleccionar.ClienteSeleccionado;
                if (cliente != null)
                {
                    if (presupuestoVenta != null)
                    {
                        txtCliente.Text = cliente.Id.ToString();
                        txtNombreCliente.Text = cliente.NombreFiscal.ToString();
                        txtDireccionCliente.Text = cliente.Direccion.ToString();
                    }

                    if (pedidoVenta != null)
                    {
                        txtCliente.Text = cliente.Id.ToString();
                        txtNombreCliente.Text = cliente.NombreFiscal.ToString();
                        txtDireccionCliente.Text = cliente.Direccion.ToString();
                    }

                    if (albaran != null)
                    {
                        txtCliente.Text = cliente.Id.ToString();
                        txtNombreCliente.Text = cliente.NombreFiscal.ToString();
                        txtDireccionCliente.Text = cliente.Direccion.ToString();
                    }

                    if (facturaVenta != null)
                    {
                        txtCliente.Text = cliente.Id.ToString();
                        txtNombreCliente.Text = cliente.NombreFiscal.ToString();
                        txtDireccionCliente.Text = cliente.Direccion.ToString();
                    }
                }
            }
            else
            {
                frmSeleccionarProveedor frmSeleccionarProveedor = new frmSeleccionarProveedor();
                frmSeleccionarProveedor.ShowDialog();
                Proveedor proveedor = frmSeleccionarProveedor.ProveedorSeleccionado;
                if (proveedor != null)
                {
                    if (presupuestoCompra != null)
                    {
                        txtCliente.Text = proveedor.Id.ToString();
                        txtNombreCliente.Text = proveedor.NombreFiscal.ToString();
                        txtDireccionCliente.Text = proveedor.Direccion.ToString();
                    }

                    if (pedidoCompra != null)
                    {
                        txtCliente.Text = proveedor.Id.ToString();
                        txtNombreCliente.Text = proveedor.NombreFiscal.ToString();
                        txtDireccionCliente.Text = proveedor.Direccion.ToString();
                    }

                    if (entrada != null)
                    {
                        txtCliente.Text = proveedor.Id.ToString();
                        txtNombreCliente.Text = proveedor.NombreFiscal.ToString();
                        txtDireccionCliente.Text = proveedor.Direccion.ToString();
                    }

                    if (facturaCompra != null)
                    {
                        txtCliente.Text = proveedor.Id.ToString();
                        txtNombreCliente.Text = proveedor.NombreFiscal.ToString();
                        txtDireccionCliente.Text = proveedor.Direccion.ToString();
                    }
                }
            }
        }

        private void dgvLineas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RecalcularTotal();
            Guardar();
        }

        private void RecalcularTotal()
        {
            dgvLineas.Refresh();
            double total = 0;
            for (int rows = 0; rows < dgvLineas.Rows.Count; rows++)
            {
                var cantidad = dgvLineas.Rows[rows].Cells["Cantidad"].Value.ToString();
                var precioVenta = dgvLineas.Rows[rows].Cells["PrecioVenta"].Value.ToString();
                total += Double.Parse(cantidad) * Double.Parse(precioVenta);
            }
            txtTotal.Text = total.ToString();
        }

        private void frmDocumento_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Guardar();
        }
        private bool Guardar()
        {
            if (presupuestoVenta != null)
            {
                if (!txtSerie.Text.Equals("") && !txtCodigo.Text.Equals(""))
                {
                    if (!txtCliente.Text.Equals(""))
                    {
                        presupuestoVenta.Serie = Int32.Parse(txtSerie.Text.ToString());
                        presupuestoVenta.Codigo = txtCodigo.Text.ToString();
                        presupuestoVenta.Cliente = Int32.Parse(txtCliente.Text.ToString());
                        if (!txtTotal.Text.ToString().Equals(""))
                        {
                            presupuestoVenta.Total = Double.Parse(txtTotal.Text.ToString());
                        }
                        else
                        {
                            presupuestoVenta.Total = 0;
                        }
                        if (!memoObservaciones.Text.ToString().Equals(""))
                        {
                            presupuestoVenta.Observaciones = memoObservaciones.Text.ToString();
                        }

                        try
                        {
                            PresupuestoVenta.Save(Conexiones.conexion, presupuestoVenta);

                            foreach (LineasPresupuestoVenta linea in bsLineasPresupuestoVenta)
                            {
                                LineasPresupuestoVenta.Save(Conexiones.conexion, linea);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe introducir un cliente");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo serie o número están sin rellenar");
                    return false;
                }
            }

            if (pedidoVenta != null)
            {
                if (!txtSerie.Text.Equals("") && !txtCodigo.Text.Equals(""))
                {
                    if (!txtCliente.Text.Equals(""))
                    {
                        pedidoVenta.Serie = Int32.Parse(txtSerie.Text.ToString());
                        pedidoVenta.Codigo = txtCodigo.Text.ToString();
                        pedidoVenta.Cliente = Int32.Parse(txtCliente.Text.ToString());
                        if (!txtTotal.Text.ToString().Equals(""))
                        {
                            pedidoVenta.Total = Double.Parse(txtTotal.Text.ToString());
                        }
                        else
                        {
                            pedidoVenta.Total = 0;
                        }
                        if (!memoObservaciones.Text.ToString().Equals(""))
                        {
                            pedidoVenta.Observaciones = memoObservaciones.Text.ToString();
                        }

                        try
                        {
                            PedidoVenta.Save(Conexiones.conexion, pedidoVenta);

                            foreach (LineasPedidoVenta linea in bsLineasPedidoVenta)
                            {
                                if (linea.Serie == 0 || linea.Codigo.Equals("") || linea.Posicion == 0)
                                {
                                    linea.Serie = pedidoVenta.Serie;
                                    linea.Codigo = pedidoVenta.Codigo;
                                    linea.Posicion = Conexiones.SiguientePosicion("LineasPedidoVenta", linea.Serie, linea.Codigo);
                                }
                                LineasPedidoVenta.Save(Conexiones.conexion, linea);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe introducir un cliente");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo serie o número están sin rellenar");
                    return false;
                }
            }

            if (albaran != null)
            {
                if (!txtSerie.Text.Equals("") && !txtCodigo.Text.Equals(""))
                {
                    if (!txtCliente.Text.Equals(""))
                    {
                        albaran.Serie = Int32.Parse(txtSerie.Text.ToString());
                        albaran.Codigo = txtCodigo.Text.ToString();
                        albaran.Cliente = Int32.Parse(txtCliente.Text.ToString());
                        if (!txtTotal.Text.ToString().Equals(""))
                        {
                            albaran.Total = Double.Parse(txtTotal.Text.ToString());
                        }
                        else
                        {
                            albaran.Total = 0;
                        }
                        if (!memoObservaciones.Text.ToString().Equals(""))
                        {
                            albaran.Observaciones = memoObservaciones.Text.ToString();
                        }

                        try
                        {
                            Albaran.Save(Conexiones.conexion, albaran);

                            foreach (LineasAlbaran linea in bsLineasAlbaran)
                            {
                                if (linea.Serie == 0 || linea.Codigo.Equals("") || linea.Posicion == 0)
                                {
                                    linea.Serie = albaran.Serie;
                                    linea.Codigo = albaran.Codigo;
                                    linea.Posicion = Conexiones.SiguientePosicion("LineasAlbaran", linea.Serie, linea.Codigo);
                                }
                                LineasAlbaran.Save(Conexiones.conexion, linea);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe introducir un cliente");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo serie o número están sin rellenar");
                    return false;
                }
            }

            if (facturaVenta != null)
            {
                if (!txtSerie.Text.Equals("") && !txtCodigo.Text.Equals(""))
                {
                    if (!txtCliente.Text.Equals(""))
                    {
                        facturaVenta.Serie = Int32.Parse(txtSerie.Text.ToString());
                        facturaVenta.Codigo = txtCodigo.Text.ToString();
                        facturaVenta.Cliente = Int32.Parse(txtCliente.Text.ToString());
                        if (!txtTotal.Text.ToString().Equals(""))
                        {
                            facturaVenta.Total = Double.Parse(txtTotal.Text.ToString());
                        }
                        else
                        {
                            facturaVenta.Total = 0;
                        }
                        if (!memoObservaciones.Text.ToString().Equals(""))
                        {
                            facturaVenta.Observaciones = memoObservaciones.Text.ToString();
                        }

                        try
                        {
                            FacturaVenta.Save(Conexiones.conexion, facturaVenta);

                            foreach (LineasFacturaVenta linea in bsLineasFacturaVenta)
                            {
                                if (linea.Serie == 0 || linea.Codigo.Equals("") || linea.Posicion == 0)
                                {
                                    linea.Serie = facturaVenta.Serie;
                                    linea.Codigo = facturaVenta.Codigo;
                                    linea.Posicion = Conexiones.SiguientePosicion("LineasFactura", linea.Serie, linea.Codigo);
                                }
                                LineasFacturaVenta.Save(Conexiones.conexion, linea);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe introducir un cliente");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo serie o número están sin rellenar");
                    return false;
                }
            }
            if (presupuestoCompra != null)
            {
                if (!txtSerie.Text.Equals("") && !txtCodigo.Text.Equals(""))
                {
                    if (!txtCliente.Text.Equals(""))
                    {
                        presupuestoCompra.Serie = Int32.Parse(txtSerie.Text.ToString());
                        presupuestoCompra.Codigo = txtCodigo.Text.ToString();
                        presupuestoCompra.Proveedor = Int32.Parse(txtCliente.Text.ToString());
                        if (!txtTotal.Text.ToString().Equals(""))
                        {
                            presupuestoCompra.Total = Double.Parse(txtTotal.Text.ToString());
                        }
                        else
                        {
                            presupuestoCompra.Total = 0;
                        }
                        if (!memoObservaciones.Text.ToString().Equals(""))
                        {
                            presupuestoCompra.Observaciones = memoObservaciones.Text.ToString();
                        }

                        try
                        {
                            PresupuestoCompra.Save(Conexiones.conexion, presupuestoCompra);

                            foreach (LineasPresupuestoCompra linea in bsLineasPresupuestoCompra)
                            {
                                LineasPresupuestoCompra.Save(Conexiones.conexion, linea);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe introducir un cliente");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo serie o número están sin rellenar");
                    return false;
                }
            }
            if (pedidoCompra != null)
            {
                if (!txtSerie.Text.Equals("") && !txtCodigo.Text.Equals(""))
                {
                    if (!txtCliente.Text.Equals(""))
                    {
                        pedidoCompra.Serie = Int32.Parse(txtSerie.Text.ToString());
                        pedidoCompra.Codigo = txtCodigo.Text.ToString();
                        pedidoCompra.Proveedor = Int32.Parse(txtCliente.Text.ToString());
                        if (!txtTotal.Text.ToString().Equals(""))
                        {
                            pedidoCompra.Total = Double.Parse(txtTotal.Text.ToString());
                        }
                        else
                        {
                            pedidoCompra.Total = 0;
                        }
                        if (!memoObservaciones.Text.ToString().Equals(""))
                        {
                            pedidoCompra.Observaciones = memoObservaciones.Text.ToString();
                        }

                        try
                        {
                            PedidoCompra.Save(Conexiones.conexion, pedidoCompra);

                            foreach (LineasPedidoCompra linea in bsLineasPedidoCompra)
                            {
                                if (linea.Serie == 0 || linea.Codigo.Equals("") || linea.Posicion == 0)
                                {
                                    linea.Serie = pedidoCompra.Serie;
                                    linea.Codigo = pedidoCompra.Codigo;
                                    linea.Posicion = Conexiones.SiguientePosicion("LineasPedidoCompra", linea.Serie, linea.Codigo);
                                }
                                LineasPedidoCompra.Save(Conexiones.conexion, linea);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe introducir un cliente");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo serie o número están sin rellenar");
                    return false;
                }
            }
            if (entrada != null)
            {
                if (!txtSerie.Text.Equals("") && !txtCodigo.Text.Equals(""))
                {
                    if (!txtCliente.Text.Equals(""))
                    {
                        entrada.Serie = Int32.Parse(txtSerie.Text.ToString());
                        entrada.Codigo = txtCodigo.Text.ToString();
                        entrada.Proveedor = Int32.Parse(txtCliente.Text.ToString());
                        if (!txtTotal.Text.ToString().Equals(""))
                        {
                            entrada.Total = Double.Parse(txtTotal.Text.ToString());
                        }
                        else
                        {
                            entrada.Total = 0;
                        }
                        if (!memoObservaciones.Text.ToString().Equals(""))
                        {
                            entrada.Observaciones = memoObservaciones.Text.ToString();
                        }

                        try
                        {
                            Entrada.Save(Conexiones.conexion, entrada);

                            foreach (LineasEntrada linea in bsLineasEntrada)
                            {
                                if (linea.Serie == 0 || linea.Codigo.Equals("") || linea.Posicion == 0)
                                {
                                    linea.Serie = entrada.Serie;
                                    linea.Codigo = entrada.Codigo;
                                    linea.Posicion = Conexiones.SiguientePosicion("LineasEntrada", linea.Serie, linea.Codigo);
                                }
                                LineasEntrada.Save(Conexiones.conexion, linea);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe introducir un cliente");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo serie o número están sin rellenar");
                    return false;
                }
            }
            if (facturaCompra != null)
            {
                if (!txtSerie.Text.Equals("") && !txtCodigo.Text.Equals(""))
                {
                    if (!txtCliente.Text.Equals(""))
                    {
                        facturaCompra.Serie = Int32.Parse(txtSerie.Text.ToString());
                        facturaCompra.Codigo = txtCodigo.Text.ToString();
                        facturaCompra.Proveedor = Int32.Parse(txtCliente.Text.ToString());
                        if (!txtTotal.Text.ToString().Equals(""))
                        {
                            facturaCompra.Total = Double.Parse(txtTotal.Text.ToString());
                        }
                        else
                        {
                            facturaCompra.Total = 0;
                        }
                        if (!memoObservaciones.Text.ToString().Equals(""))
                        {
                            facturaCompra.Observaciones = memoObservaciones.Text.ToString();
                        }

                        try
                        {
                            FacturaCompra.Save(Conexiones.conexion, facturaCompra);

                            foreach (LineasFacturaCompra linea in bsLineasFacturaCompra)
                            {
                                if (linea.Serie == 0 || linea.Codigo.Equals("") || linea.Posicion == 0)
                                {
                                    linea.Serie = facturaCompra.Serie;
                                    linea.Codigo = facturaCompra.Codigo;
                                    linea.Posicion = Conexiones.SiguientePosicion("LineasFacturaCompra", linea.Serie, linea.Codigo);
                                }
                                LineasFacturaCompra.Save(Conexiones.conexion, linea);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe introducir un cliente");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo serie o número están sin rellenar");
                    return false;
                }
            }
            return true;
        }

        private void bbiEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (bsLineasPresupuestoVenta != null)
            {
                int serie = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[0].Value.ToString());
                string codigo = dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[1].Value.ToString();
                int posicion = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[2].Value.ToString());

                LineasPresupuestoVenta lineasPresupuestoVenta = LineasPresupuestoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}").FirstOrDefault();

                if (lineasPresupuestoVenta != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el artículo: {lineasPresupuestoVenta.Descripcion}\n¿Está seguro?", "Eliminar Artículo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LineasPresupuestoVenta.Delete(Conexiones.conexion, lineasPresupuestoVenta);

                        bsLineasPresupuestoVenta.DataSource = LineasPresupuestoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}");
                        dgvLineas.DataSource = bsLineasPresupuestoVenta;
                        dgvLineas.Refresh();
                        RecalcularTotal();
                        MessageBox.Show("Línea eliminada");
                    }
                }
            }
            if (bsLineasPedidoVenta != null)
            {
                int serie = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[0].Value.ToString());
                string codigo = dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[1].Value.ToString();
                int posicion = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[2].Value.ToString());

                LineasPedidoVenta lineasPedidoVenta = LineasPedidoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}").FirstOrDefault();

                if (lineasPedidoVenta != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el artículo: {lineasPedidoVenta.Descripcion}\n¿Está seguro?", "Eliminar Artículo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LineasPedidoVenta.Delete(Conexiones.conexion, lineasPedidoVenta);

                        bsLineasPedidoVenta.DataSource = LineasPedidoVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");
                        dgvLineas.DataSource = bsLineasPedidoVenta;
                        dgvLineas.Refresh();
                        RecalcularTotal();
                        MessageBox.Show("Línea eliminada");
                    }
                }
            }
            if (bsLineasAlbaran != null)
            {
                int serie = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[0].Value.ToString());
                string codigo = dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[1].Value.ToString();
                int posicion = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[2].Value.ToString());

                LineasAlbaran lineasAlbaran = LineasAlbaran.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}").FirstOrDefault();

                if (lineasAlbaran != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el artículo: {lineasAlbaran.Descripcion}\n¿Está seguro?", "Eliminar Artículo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LineasAlbaran.Delete(Conexiones.conexion, lineasAlbaran);

                        bsLineasAlbaran.DataSource = LineasAlbaran.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");
                        dgvLineas.DataSource = bsLineasAlbaran;
                        dgvLineas.Refresh();
                        RecalcularTotal();
                        MessageBox.Show("Línea eliminada");
                    }
                }
            }
            if (bsLineasFacturaVenta != null)
            {
                int serie = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[0].Value.ToString());
                string codigo = dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[1].Value.ToString();
                int posicion = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[2].Value.ToString());

                LineasFacturaVenta lineasFacturaVenta = LineasFacturaVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}").FirstOrDefault();

                if (lineasFacturaVenta != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el artículo: {lineasFacturaVenta.Descripcion}\n¿Está seguro?", "Eliminar Artículo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LineasFacturaVenta.Delete(Conexiones.conexion, lineasFacturaVenta);

                        bsLineasFacturaVenta.DataSource = LineasFacturaVenta.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}'");
                        dgvLineas.DataSource = bsLineasFacturaVenta;
                        dgvLineas.Refresh();
                        RecalcularTotal();
                        MessageBox.Show("Línea eliminada");
                    }
                }
            }
            if (bsLineasPresupuestoCompra != null)
            {
                int serie = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[0].Value.ToString());
                string codigo = dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[1].Value.ToString();
                int posicion = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[2].Value.ToString());

                LineasPresupuestoCompra lineasPresupuestoCompra = LineasPresupuestoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}").FirstOrDefault();

                if (lineasPresupuestoCompra != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el artículo: {lineasPresupuestoCompra.Descripcion}\n¿Está seguro?", "Eliminar Artículo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LineasPresupuestoCompra.Delete(Conexiones.conexion, lineasPresupuestoCompra);

                        bsLineasPresupuestoCompra.DataSource = LineasPresupuestoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}");
                        dgvLineas.DataSource = bsLineasPresupuestoCompra;
                        dgvLineas.Refresh();
                        RecalcularTotal();
                        MessageBox.Show("Línea eliminada");
                    }
                }
            }
            if (bsLineasPedidoCompra != null)
            {
                int serie = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[0].Value.ToString());
                string codigo = dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[1].Value.ToString();
                int posicion = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[2].Value.ToString());

                LineasPedidoCompra lineasPedidoCompra = LineasPedidoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}").FirstOrDefault();

                if (lineasPedidoCompra != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el artículo: {lineasPedidoCompra.Descripcion}\n¿Está seguro?", "Eliminar Artículo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LineasPedidoCompra.Delete(Conexiones.conexion, lineasPedidoCompra);

                        bsLineasPedidoCompra.DataSource = LineasPedidoCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}");
                        dgvLineas.DataSource = bsLineasPedidoCompra;
                        dgvLineas.Refresh();
                        RecalcularTotal();
                        MessageBox.Show("Línea eliminada");
                    }
                }
            }
            if (bsLineasEntrada != null)
            {
                int serie = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[0].Value.ToString());
                string codigo = dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[1].Value.ToString();
                int posicion = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[2].Value.ToString());

                LineasEntrada lineasEntrada = LineasEntrada.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}").FirstOrDefault();

                if (lineasEntrada != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el artículo: {lineasEntrada.Descripcion}\n¿Está seguro?", "Eliminar Artículo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LineasEntrada.Delete(Conexiones.conexion, lineasEntrada);

                        bsLineasEntrada.DataSource = LineasEntrada.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}");
                        dgvLineas.DataSource = bsLineasEntrada;
                        dgvLineas.Refresh();
                        RecalcularTotal();
                        MessageBox.Show("Línea eliminada");
                    }
                }
            }
            if (bsLineasFacturaCompra != null)
            {
                int serie = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[0].Value.ToString());
                string codigo = dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[1].Value.ToString();
                int posicion = Int32.Parse(dgvLineas.Rows[dgvLineas.CurrentRow.Index].Cells[2].Value.ToString());

                LineasFacturaCompra lineasFacturaCompra = LineasFacturaCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}").FirstOrDefault();

                if (lineasFacturaCompra != null)
                {
                    DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el artículo: {lineasFacturaCompra.Descripcion}\n¿Está seguro?", "Eliminar Artículo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LineasFacturaCompra.Delete(Conexiones.conexion, lineasFacturaCompra);

                        bsLineasFacturaCompra.DataSource = LineasFacturaCompra.GetWhere(Conexiones.conexion, $"Serie = {serie} AND Codigo = '{codigo}' AND Posicion = {posicion}");
                        dgvLineas.DataSource = bsLineasFacturaCompra;
                        dgvLineas.Refresh();
                        RecalcularTotal();
                        MessageBox.Show("Línea eliminada");
                    }
                }
            }
        }

        private void frmDocumento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Guardar())
            {
                e.Cancel = true;
            }
        }
    }
}
