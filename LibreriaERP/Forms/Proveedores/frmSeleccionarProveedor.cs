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
    public partial class frmSeleccionarProveedor : Form
    {
        Proveedor proveedorSeleccionado;
        public frmSeleccionarProveedor()
        {
            InitializeComponent();
            CargarDatos();
        }

        public Proveedor ProveedorSeleccionado { get => proveedorSeleccionado; set => proveedorSeleccionado = value; }

        private void CargarDatos()
        {
            bsProveedores.DataSource = Proveedor.GetAll(Conexiones.conexion);
            dgvProveedores.DataSource = bsProveedores;
        }

        private void dgvProveedores_DoubleClick(object sender, EventArgs e)
        {
            string codigo = dgvProveedores.Rows[dgvProveedores.CurrentRow.Index].Cells[0].Value.ToString();
            Proveedor proveedor = Proveedor.GetWhere(Conexiones.conexion, $"Id = {Int32.Parse(codigo)}").FirstOrDefault();
            if (proveedor != null)
            {
                ProveedorSeleccionado = proveedor;
                this.Close();
            }
        }
    }
}
