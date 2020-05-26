using LibreriaERP.Clases;
using LibreriaERP.Clases.Articulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaERP.Forms.Articulos
{
    public partial class frmVerArticulos : Form
    {
        public frmVerArticulos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            articuloBindingSource.DataSource = Articulo.GetAll(Conexiones.conexion);
            dgvArticulos.DataSource = articuloBindingSource;
        }

        private void bbiAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmArticulo frmArticulo = new frmArticulo();
            frmArticulo.ShowDialog();
            CargarDatos();
        }

        private void dgvArticulos_DoubleClick(object sender, EventArgs e)
        {
            string codigo = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[0].Value.ToString();
            Articulo articulo = Articulo.GetWhere(Conexiones.conexion, $"Codigo = '{codigo}'").FirstOrDefault();
            if (articulo != null)
            {
                frmArticulo frmArticulo = new frmArticulo(articulo);
                frmArticulo.ShowDialog();
                CargarDatos();
            }
        }

        private void bbiEliminarArticulo_Click(object sender, EventArgs e)
        {
            string codigo = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[0].Value.ToString();
            Articulo articulo = Articulo.GetWhere(Conexiones.conexion, $"Codigo = '{codigo}'").FirstOrDefault();
            if (articulo != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el artículo: {articulo.Descripcion}\n¿Está seguro?", "Eliminar Artículo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Articulo.Delete(Conexiones.conexion, articulo);
                    MessageBox.Show("Artículo eliminado");
                    CargarDatos();
                }
            }
        }

        private void bbiSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
