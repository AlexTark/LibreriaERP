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
    public partial class frmUsuarios : RibbonForm
    {
        public frmUsuarios()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            bsUsuario.DataSource = Usuario.GetAll(Conexiones.conexion);
            dgvUsuarios.DataSource = bsUsuario;
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            frmAddUsuario frmAddUsuario = new frmAddUsuario();
            frmAddUsuario.ShowDialog();
            CargarDatos();
        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            string id = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
            Usuario usuario = Usuario.GetWhere(Conexiones.conexion, $"Id = {Int32.Parse(id)}").FirstOrDefault();
            if (usuario != null)
            {
                frmAddUsuario frmAddUsuario = new frmAddUsuario(usuario);
                frmAddUsuario.ShowDialog();
                CargarDatos();
            }
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            string id = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
            Usuario usuario = Usuario.GetWhere(Conexiones.conexion, $"Id = {Int32.Parse(id)}").FirstOrDefault();
            if (usuario != null)
            {
                DialogResult dialogResult = MessageBox.Show($"Se va a eliminar el usuario: {usuario.Login}\n¿Está seguro?", "Eliminar usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Usuario.Delete(Conexiones.conexion, usuario);
                    MessageBox.Show("Usuario eliminado");
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
