using Nowtic.Lib.Mapper;
using Nowtic.Lib.Mapper.MapAttribute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaERP.Clases.PedidosCompra
{
    [Table(Name = TABLE_PEDIDOCOMPRA)]
    public class PedidoCompra : DataObjectEntity<PedidoCompra>
    {
        public const String TABLE_PEDIDOCOMPRA = "PedidoCompra";

        private Int32 _serie = 0;
        [Column(Name = "Serie", DbType = DbType.Int32, IsPrimaryKey = true)]
        public Int32 Serie { get { return _serie; } set { SetField(ref _serie, value); } }

        private String _codigo = string.Empty;
        [Column(Name = "Codigo", DbType = DbType.String, IsPrimaryKey = true)]
        public String Codigo { get { return _codigo; } set { SetField(ref _codigo, value); } }

        private Int32 _proveedor = 0;
        [Column(Name = "Proveedor", DbType = DbType.Int32)]
        public Int32 Proveedor { get { return _proveedor; } set { SetField(ref _proveedor, value); } }

        private Double _total = 0;
        [Column(Name = "Total", DbType = DbType.Double)]
        public Double Total { get { return _total; } set { SetField(ref _total, value); } }

        private String _observaciones = string.Empty;
        [Column(Name = "Observaciones", DbType = DbType.String)]
        public String Observaciones { get { return _observaciones; } set { SetField(ref _observaciones, value); } }

        private String _documentoEvolucion = string.Empty;
        [Column(Name = "DocumentoEvolucion", DbType = DbType.String)]
        public String DocumentoEvolucion { get { return _documentoEvolucion; } set { SetField(ref _documentoEvolucion, value); } }
    }
}
