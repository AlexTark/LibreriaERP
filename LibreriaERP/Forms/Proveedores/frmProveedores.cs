using LibreriaERP.Clases;
using LibreriaERP.Clases.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaERP.Forms.Proveedores
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            proveedorBindingSource.DataSource = Proveedor.GetAll(Conexiones.conexion);
            dgvProveedores.DataSource = proveedorBindingSource;
        }

        private void bbiAgregarProveedor_Click(object sender, EventArgs e)
        {
            frmAddProveedor frmAddProveedor = new frmAddProveedor();
            frmAddProveedor.ShowDialog();
            CargarDatos();
        }

        private void bbiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProveedores_DoubleClick(object sender, EventArgs e)
        {
            string id = dgvProveedores.Rows[dgvProveedores.CurrentRow.Index].Cells[0].Value.ToString();
            Proveedor proveedor = Proveedor.GetWhere(Conexiones.conexion, $"Id = {Int32.Parse(id)}").FirstOrDefault();
            if (proveedor != null)
            {
                frmAddProveedor frmAddProveedor = new frmAddProveedor(proveedor);
                frmAddProveedor.ShowDialog();
                CargarDatos();
            }
        }

        private void bbiEliminarProveedor_Click(object sender, EventArgs e)
        {
            string id = dgvProveedores.Rows[dgvProveedores.CurrentRow.Index].Cells[0].Value.ToString();
            Proveedor proveedor = Proveedor.GetWhere(Conexiones.conexion, $"Id = {Int32.Parse(id)}").FirstOrDefault();
            if (proveedor != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el proveedor: {proveedor.NombreComercial}\n¿Está seguro?", "Eliminar Proveedor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Proveedor.Delete(Conexiones.conexion, proveedor);
                    MessageBox.Show("Proveedor eliminado");
                    CargarDatos();
                }
            }
        }
    }
}
