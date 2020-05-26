using LibreriaERP.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaERP.Forms
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void btnElegirBaseDatos_Click(object sender, EventArgs e)
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
                    txtRutaDatos.Text = filePath;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            this.Validate();
            Conexiones.config.RutaBaseDatos = txtRutaDatos.Text.ToString();

            Conexiones.config.Save();
            MessageBox.Show("Configuración guardada satisfactoriamente");
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            txtRutaDatos.Text = Conexiones.config.RutaBaseDatos;
        }
    }
}
