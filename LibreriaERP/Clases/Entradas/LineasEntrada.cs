using Nowtic.Lib.Mapper;
using Nowtic.Lib.Mapper.MapAttribute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaERP.Clases.Entradas
{
    [Table(Name = TABLE_LINEASENTRADA)]
    public class LineasEntrada : DataObjectEntity<LineasEntrada>
    {
        public const String TABLE_LINEASENTRADA = "LineasEntrada";

        private Int32 _serie = 0;
        [Column(Name = "Serie", DbType = DbType.Int32, IsPrimaryKey = true)]
        public Int32 Serie { get { return _serie; } set { SetField(ref _serie, value); } }

        private String _codigo = string.Empty;
        [Column(Name = "Codigo", DbType = DbType.String, IsPrimaryKey = true)]
        public String Codigo { get { return _codigo; } set { SetField(ref _codigo, value); } }

        private Int32 _posicion = 0;
        [Column(Name = "Posicion", DbType = DbType.Int32, IsPrimaryKey = true)]
        public Int32 Posicion { get { return _posicion; } set { SetField(ref _posicion, value); } }

        private String _codArticulo = string.Empty;
        [Column(Name = "CodArticulo", DbType = DbType.String)]
        public String CodArticulo { get { return _codArticulo; } set { SetField(ref _codArticulo, value); } }

        private String _descripcion = string.Empty;
        [Column(Name = "Descripcion", DbType = DbType.String)]
        public String Descripcion { get { return _descripcion; } set { SetField(ref _descripcion, value); } }

        private Int32 _cantidad = 0;
        [Column(Name = "Cantidad", DbType = DbType.Int32)]
        public Int32 Cantidad { get { return _cantidad; } set { SetField(ref _cantidad, value); } }

        private Double _precioVenta = 0;
        [Column(Name = "PrecioVenta", DbType = DbType.Double)]
        public Double PrecioVenta { get { return _precioVenta; } set { SetField(ref _precioVenta, value); } }
    }
}
