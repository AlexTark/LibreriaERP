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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            clienteBindingSource.DataSource = Cliente.GetAll(Conexiones.conexion);
            dgvClientes.DataSource = clienteBindingSource;
        }

        private void bbiAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAddCliente frmAddCliente = new frmAddCliente();
            frmAddCliente.ShowDialog();
            CargarDatos();
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            string id = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString();
            Cliente cliente = Cliente.GetWhere(Conexiones.conexion, $"Id = {Int32.Parse(id)}").FirstOrDefault();
            if (cliente != null)
            {
                frmAddCliente frmAddCliente = new frmAddCliente(cliente);
                frmAddCliente.ShowDialog();
                CargarDatos();
            }
        }

        private void bbiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bbiEliminarCliente_Click(object sender, EventArgs e)
        {
            string id = dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString();
            Cliente cliente = Cliente.GetWhere(Conexiones.conexion, $"Id = {Int32.Parse(id)}").FirstOrDefault();
            if (cliente != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el cliente: {cliente.NombreComercial}\n¿Está seguro?", "Eliminar Cliente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Cliente.Delete(Conexiones.conexion, cliente);
                    MessageBox.Show("Cliente eliminado");
                    CargarDatos();
                }
            }
        }
    }
}
