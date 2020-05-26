using LibreriaERP.Clases.Usuarios;
using Nowtic.Lib;
using Nowtic.Lib.Connection;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaERP.Clases
{
    class Conexiones
    {
        public static DbConnection conexion;
        public static ProveedorDB proveedor = new ProveedorDB(EnumProveedoresDB.ACE);
        public static Usuario usuarioActual;

        public static Config config;
        public static bool conecta(string ruta)
        {
            bool conectado = true;
            try
            {
                proveedor.Proveedor = EnumProveedoresDB.ACE;
                proveedor.Host = ruta;
                proveedor.User = "Admin";
                proveedor.Pass = "";

                conexion = proveedor.Conectar();
                if (conexion != null)
                {
                    return conectado;
                }
                else
                {
                    conectado = false;
                    return conectado;
                }
            }
            catch (Exception ex)
            {
                conectado = false;
                Logger.E(ex.ToString());
            }
            return conectado;
        }

        public static int SiguienteCliente()
        {
            String sql = "SELECT Max(Id) From Clientes";
            DbCommand cmd = conexion.CreateCommand();
            cmd.CommandText = sql;
            int idCliente = 0;
            DbDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                try
                {
                    idCliente = lector.GetInt32(0);
                }
                catch (InvalidCastException ex)
                {

                }
            }
            return idCliente + 1;
        }

        public static int SiguientePosicion(string nombreTabla, int serie, string codigo)
        {
            String sql = $"SELECT Max(Posicion) From {nombreTabla} WHERE Serie = {serie} AND Codigo = '{codigo}'";
            DbCommand cmd = conexion.CreateCommand();
            cmd.CommandText = sql;
            int posicion = 0;
            DbDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                try
                {
                    posicion = lector.GetInt32(0);
                }
                catch (InvalidCastException ex)
                {

                }
            }
            return posicion + 1;
        }

        public static int SiguienteProveedor()
        {
            String sql = "SELECT Max(Id) From Proveedores";
            DbCommand cmd = conexion.CreateCommand();
            cmd.CommandText = sql;
            int idProveedor = 0;
            DbDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                try
                {
                    idProveedor = lector.GetInt32(0);
                }
                catch (InvalidCastException ex)
                {

                }
            }
            return idProveedor + 1;
        }

        public static int SiguienteUsuario()
        {
            String sql = "SELECT Max(Id) From UsuariosBase";
            DbCommand cmd = conexion.CreateCommand();
            cmd.CommandText = sql;
            int codigoUsuario = 0;
            DbDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                try
                {
                    codigoUsuario = lector.GetInt32(0);
                }
                catch (InvalidCastException ex)
                {

                }
            }
            return codigoUsuario + 1;
        }

        public static void desconectaBD()
        {
            if (conexion == null)
                return;
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
                conexion.Dispose();
            }
        }
    }
}
