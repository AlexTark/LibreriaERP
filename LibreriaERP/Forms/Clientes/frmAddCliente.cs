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
    public partial class frmAddCliente : Form
    {
        Cliente cliente;
        public frmAddCliente()
        {
            InitializeComponent();
        }

        public frmAddCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            clienteBindingSource.DataSource = this.cliente;
        }

        private void bbiGuardar_Click(object sender, EventArgs e)
        {
            Guardar(false);
        }

        private void Guardar(bool salir)
        {
            if (txtId.Text.Equals(""))
            {
                Cliente cliente = new Cliente();
                cliente.Id = Conexiones.SiguienteCliente();
                cliente.NIF = txtNif.Text.ToString();
                cliente.NombreComercial = txtNombreComercial.Text.ToString();
                cliente.NombreFiscal = txtNombreFiscal.Text.ToString();
                cliente.Direccion = txtDireccion.Text.ToString();
                cliente.Telefono = txtTelefono.Text.ToString();
                cliente.Movil = txtMovil.Text.ToString();
                cliente.Email = txtEmail.Text.ToString();
                cliente.NumeroCuenta = txtNumCuenta.Text.ToString();
                cliente.Observaciones = txtObservaciones.Text.ToString();

                Cliente.Save(Conexiones.conexion, cliente);
                MessageBox.Show("Cliente guardado");
            }
            else
            {
                Cliente.Save(Conexiones.conexion, cliente);
                MessageBox.Show("Cliente actualizado");
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
