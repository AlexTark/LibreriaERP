using LibreriaERP.Clases;
using LibreriaERP.Clases.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaERP.Forms.Usuarios
{
    public partial class frmAddUsuario : Form
    {
        Usuario usuario;
        public frmAddUsuario()
        {
            InitializeComponent();
        }

        public frmAddUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            usuarioBindingSource.DataSource = this.usuario;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar(false);
        }

        private void Guardar(bool salir)
        {
            //Si no existe usuario, es nuevo y lo guardo
            if (usuario == null)
            {
                //Compruebo que los principales datos del usuario se han introducido
                if (txtLogin.Text.Equals("") || txtPass.Text.Equals(""))
                {
                    MessageBox.Show("El campo login o contraseña están vacíos.");
                }
                else
                {
                    //Creo un nuevo usuario con los campos que hayan introducido
                    Usuario usuario = new Usuario();
                    usuario.Id = Conexiones.SiguienteUsuario();
                    usuario.Login = txtLogin.Text.ToString();
                    usuario.Pass = txtPass.Text.ToString();
                    usuario.Nombre = txtNombre.Text.ToString();
                    usuario.Apellidos = txtApellidos.Text.ToString();
                    usuario.Telefono = txtTelefono.Text.ToString();
                    usuario.Email = txtEmail.Text.ToString();

                    //Guardo el usuario
                    try
                    {
                        Usuario.Save(Conexiones.conexion, usuario);
                        MessageBox.Show("Usuario guardado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                Usuario.Save(Conexiones.conexion, usuario);
                MessageBox.Show("Usuario actualizado correctamente");
            }

            if (salir)
            {
                this.Close();
            }
        }

        private void btnGuardarYSalir_Click(object sender, EventArgs e)
        {
            Guardar(true);
        }
    }
}
