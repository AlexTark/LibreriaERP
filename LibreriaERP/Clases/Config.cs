using Nowtic.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaERP.Clases
{
    public class Config
    {
        public const String ConfigurationPath = @".\Config.xml";


        #region BaseDatos
        public string RutaBaseDatos { get; set; }
        #endregion
        public Config()
        {
            if (!File.Exists(ConfigurationPath))
            {
                Save();
            }
        }

        public void Save()
        {
            XmlSerializerHelper.Serializer(ConfigurationPath, this, Encoding.UTF8);
        }
    }
}
