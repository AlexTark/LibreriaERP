using LibreriaERP.Clases;
using LibreriaERP.Clases.Usuarios;
using Nowtic.Lib;
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
    public partial class frmLogin : Form
    {
        private Usuario usuAcceso;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void CargarDatosUsuario(Usuario usuAcceso)
        {
            Conexiones.usuarioActual = this.usuAcceso;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //NONE
        }

        private void Ingresar()
        {
            try
            {
                Usuario usuario = Usuario.GetWhere(Conexiones.conexion, $"Login = '{txtLogin.Text.ToString()}' AND Pass = '{txtPass.Text.ToString()}'").FirstOrDefault();

                if (usuario != null)
                {
                    CargarDatosUsuario(usuario);
                    Logger.I($"Se han cargado con éxito los datos del usuario '{usuario.Nombre}'");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("No existe un usuario con esos datos.");
                    txtPass.Text = string.Empty;
                    txtPass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido consultar la base de datos.\nAsegúrsese de que es un archivo válido");
            }
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Ingresar();
            }
        }
    }
}
