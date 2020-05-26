using LibreriaERP.Clases;
using LibreriaERP.Clases.Articulos;
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

namespace LibreriaERP.Forms.Articulos
{
    public partial class frmArticulo : Form
    {
        Articulo articulo;
        public frmArticulo()
        {
            InitializeComponent();
            bbiSiguiente.Enabled = false;
            bbiAtras.Enabled = false;
        }

        public frmArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            CargarDatos();
        }

        private void CargarDatos()
        {
            articuloBindingSource.DataSource = articulo;
        }

        private void btnElegirRuta_Click(object sender, EventArgs e)
        {
            ElegirRuta();
        }
        private void ElegirRuta()
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    txtImagen.Text = filePath;
                }
            }

            ColocarImagen();
        }

        private void ColocarImagen()
        {
            if (!txtImagen.Text.Equals(""))
            {
                Image image = Image.FromFile($"{txtImagen.Text.ToString()}");
                picImagen.Image = image;
            }
        }

        private void bbiGuardar_Click(object sender, EventArgs e)
        {
            if (articulo == null)
            {
                articulo = new Articulo();
                articulo.Codigo = txtCodigo.Text.ToString();
                articulo.Descripcion = txtDescripcion.Text.ToString();
                articulo.PrecioCoste = Double.Parse(txtPrecioCoste.Text.ToString());
                articulo.Stock = Int32.Parse(txtStock.Text.ToString());
                articulo.Imagen = txtImagen.Text.ToString();
                articulo.CampoAux1 = txtCA1.Text.ToString();
                articulo.CampoAux2 = txtCA2.Text.ToString();
                articulo.CampoAux3 = txtCA3.Text.ToString();

                try
                {
                    Articulo.Save(Conexiones.conexion, articulo);
                    MessageBox.Show("Artículo guardado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Articulo.Save(Conexiones.conexion, articulo);
                    MessageBox.Show("Artículo guardado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            ColocarImagen();
        }

        private void bbiSiguiente_Click(object sender, EventArgs e)
        {
            Siguiente();
        }

        private void Siguiente()
        {
            BindingListView<Articulo> listaArticulos = Articulo.GetAll(Conexiones.conexion);
            foreach (Articulo art in listaArticulos)
            {
                if (art.Codigo.Equals(articulo.Codigo))
                {
                    int indice = listaArticulos.IndexOf(art);

                    if (indice != listaArticulos.Count - 1)
                    {
                        articulo = listaArticulos.ElementAt(indice + 1);
                        CargarDatos();
                        ColocarImagen();
                    }
                    else
                    {
                        MessageBox.Show("No hay más registros");
                    }
                    break;
                }
            }
        }

        private void bbiAtras_Click(object sender, EventArgs e)
        {
            Atras();
        }

        private void Atras()
        {
            BindingListView<Articulo> listaArticulos = Articulo.GetAll(Conexiones.conexion);
            foreach (Articulo art in listaArticulos)
            {
                if (art.Codigo.Equals(articulo.Codigo))
                {
                    int indice = listaArticulos.IndexOf(art);

                    if (indice != 0)
                    {
                        articulo = listaArticulos.ElementAt(indice - 1);
                        CargarDatos();
                        ColocarImagen();
                    }
                    else
                    {
                        MessageBox.Show("No hay más registros");
                    }
                    break;
                }
            }
        }
    }
}
