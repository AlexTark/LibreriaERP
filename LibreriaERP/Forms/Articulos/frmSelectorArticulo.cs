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
    public partial class frmSelectorArticulo : Form
    {
        Articulo articuloSeleccionado;
        public frmSelectorArticulo()
        {
            InitializeComponent();
            CargarDatos();
        }

        public Articulo ArticuloSeleccionado { get => articuloSeleccionado; set => articuloSeleccionado = value; }

        private void CargarDatos()
        {
            bsArticulo.DataSource = Articulo.GetAll(Conexiones.conexion);
            dgvArticulos.DataSource = bsArticulo;
        }

        private void dgvArticulos_DoubleClick(object sender, EventArgs e)
        {
            string codigo = dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[0].Value.ToString();
            Articulo articulo = Articulo.GetWhere(Conexiones.conexion, $"Codigo = '{codigo}'").FirstOrDefault();
            if (articulo != null)
            {
                ArticuloSeleccionado = articulo;
                this.Close();
            }
        }
    }
}
