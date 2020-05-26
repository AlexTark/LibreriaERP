using LibreriaERP.Clases;
using LibreriaERP.Clases.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaERP.Forms.Clientes
{
    public partial class frmSeleccionarCliente : Form
    {
        Cliente clienteSeleccionado;
        public frmSeleccionarCliente()
        {
            InitializeComponent();
            CargarDatos();
        }

        public Cliente ClienteSeleccionado { get => clienteSeleccionado; set => clienteSeleccionado = value; }

        private void CargarDatos()
        {
            bsClientes.DataSource = Cliente.GetAll(Conexiones.conexion);
            dgvClientes.DataSource = bsClientes;
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            string codigo = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString();
            Cliente cliente = Cliente.GetWhere(Conexiones.conexion, $"Id = {Int32.Parse(codigo)}").FirstOrDefault();
            if (cliente != null)
            {
                ClienteSeleccionado = cliente;
                this.Close();
            }
        }
    }
}
