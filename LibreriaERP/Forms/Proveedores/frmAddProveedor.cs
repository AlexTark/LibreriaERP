using LibreriaERP.Clases;
using LibreriaERP.Clases.Clientes;
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
    public partial class frmAddProveedor : Form
    {
        Proveedor proveedor;
        public frmAddProveedor()
        {
            InitializeComponent();
        }

        public frmAddProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
            proveedorBindingSource.DataSource = this.proveedor;
        }

        private void bbiGuardar_Click(object sender, EventArgs e)
        {
            Guardar(false);
        }

        private void Guardar(bool salir)
        {
            if (txtId.Text.Equals(""))
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Id = Conexiones.SiguienteProveedor();
                proveedor.NIF = txtNif.Text.ToString();
                proveedor.NombreComercial = txtNombreComercial.Text.ToString();
                proveedor.NombreFiscal = txtNombreFiscal.Text.ToString();
                proveedor.Direccion = txtDireccion.Text.ToString();
                proveedor.Telefono = txtTelefono.Text.ToString();
                proveedor.Movil = txtMovil.Text.ToString();
                proveedor.Email = txtEmail.Text.ToString();
                proveedor.NumeroCuenta = txtNumCuenta.Text.ToString();
                proveedor.Observaciones = txtObservaciones.Text.ToString();

                Proveedor.Save(Conexiones.conexion, proveedor);
                MessageBox.Show("Proveedor guardado");
            }
            else
            {
                Proveedor.Save(Conexiones.conexion, proveedor);
                MessageBox.Show("Proveedor actualizado");
            }

            if (salir)
            {
                this.Close();
            }
        }

        private void bbiGuardarYSalir_Click(object sender, EventArgs e)
        {
            Guardar(true);
        }
    }
}
