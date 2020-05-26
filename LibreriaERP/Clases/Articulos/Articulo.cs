using Nowtic.Lib.Mapper;
using Nowtic.Lib.Mapper.MapAttribute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaERP.Clases.Articulos
{
    [Table(Name = TABLE_ARTICULOS)]
    public class Articulo : DataObjectEntity<Articulo>
    {
        public const String TABLE_ARTICULOS = "Articulos";

        private String _codigo = String.Empty;
        [Column(Name = "Codigo", DbType = DbType.String, IsPrimaryKey = true)]
        public String Codigo { get { return _codigo; } set { SetField(ref _codigo, value); } }

        private String _descripcion = string.Empty;
        [Column(Name = "Descripcion", DbType = DbType.String)]
        public String Descripcion { get { return _descripcion; } set { SetField(ref _descripcion, value); } }

        private Double _precioCoste = 0;
        [Column(Name = "PrecioCoste", DbType = DbType.String)]
        public Double PrecioCoste { get { return _precioCoste; } set { SetField(ref _precioCoste, value); } }

        private Int32 _stock = 0;
        [Column(Name = "Stock", DbType = DbType.String)]
        public Int32 Stock { get { return _stock; } set { SetField(ref _stock, value); } }

        private String _imagen = string.Empty;
        [Column(Name = "Imagen", DbType = DbType.String)]
        public String Imagen { get { return _imagen; } set { SetField(ref _imagen, value); } }

        private String _campoAux1 = string.Empty;
        [Column(Name = "CampoAux1", DbType = DbType.String)]
        public String CampoAux1 { get { return _campoAux1; } set { SetField(ref _campoAux1, value); } }

        private String _campoAux2 = string.Empty;
        [Column(Name = "CampoAux2", DbType = DbType.String)]
        public String CampoAux2 { get { return _campoAux2; } set { SetField(ref _campoAux2, value); } }

        private String _campoAux3 = string.Empty;
        [Column(Name = "CampoAux3", DbType = DbType.String)]
        public String CampoAux3 { get { return _campoAux3; } set { SetField(ref _campoAux3, value); } }
    }
}
