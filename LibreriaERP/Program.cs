using LibreriaERP.Clases;
using LibreriaERP.Forms;
using Nowtic.Lib;
using Nowtic.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaERP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Conexiones.config = new Config();

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "CONFIG.XML"))
            {
                XmlSerializerHelper.Serializer(AppDomain.CurrentDomain.BaseDirectory + "CONFIG.XML", Clases.Conexiones.config);
            }
            else
            {
                Clases.Conexiones.config = (Clases.Config)XmlSerializerHelper.Desserializer(
                    AppDomain.CurrentDomain.BaseDirectory + "CONFIG.XML", Clases.Conexiones.config.GetType());
            }

            if (Conexiones.config.RutaBaseDatos != null)
            {
                try
                {
                    if (Conexiones.config.RutaBaseDatos != "")
                    {
                        Conexiones.conecta(Conexiones.config.RutaBaseDatos);
                        frmLogin login = new frmLogin();
                        if (login.ShowDialog() != DialogResult.OK)
                        {
                            Logger.I("Acceso denegado");
                            Application.Exit();
                            Environment.Exit(10);
                        }
                    }
                    else
                    {
                        frmConfiguracion fc = new frmConfiguracion();
                        fc.ShowDialog();

                        Conexiones.conecta(Conexiones.config.RutaBaseDatos);
                        frmLogin login = new frmLogin();
                        if (login.ShowDialog() != DialogResult.OK)
                        {
                            Logger.I("Acceso denegado");
                            Application.Exit();
                            Environment.Exit(10);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Logger.E(ex.ToString());
                    frmConfiguracion fc = new frmConfiguracion();
                    fc.ShowDialog();

                    Conexiones.conecta(Conexiones.config.RutaBaseDatos);
                    frmLogin login = new frmLogin();
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        Logger.I("Acceso denegado");
                        Application.Exit();
                        Environment.Exit(10);
                    }
                }
            }
            else
            {
                try
                {
                    frmConfiguracion fc = new frmConfiguracion();
                    fc.ShowDialog();

                    if (Conexiones.conecta(Conexiones.config.RutaBaseDatos))
                    {
                        frmLogin login = new frmLogin();
                        if (login.ShowDialog() != DialogResult.OK)
                        {
                            Logger.I("Acceso denegado");
                            Application.Exit();
                            Environment.Exit(10);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido abrir la base de datos");
                        
                    }
                    
                }
                catch (Exception ex)
                {
                    Logger.E(ex.ToString());
                    frmConfiguracion fc = new frmConfiguracion();
                    fc.ShowDialog();

                    Conexiones.conecta(Conexiones.config.RutaBaseDatos);
                    frmLogin login = new frmLogin();
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        Logger.I("Acceso denegado");
                        Application.Exit();
                        Environment.Exit(10);
                    }
                }
            }
            Application.Run(new Form1());
        }
    }
}
