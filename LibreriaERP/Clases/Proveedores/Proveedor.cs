using Nowtic.Lib.Mapper;
using Nowtic.Lib.Mapper.MapAttribute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaERP.Clases.Proveedores
{
    [Table(Name = TABLE_PROVEEDORES)]
    public class Proveedor : DataObjectEntity<Proveedor>
    {
        public const String TABLE_PROVEEDORES = "Proveedores";

        private Int32 _id = 0;
        [Column(Name = "Id", DbType = DbType.Int32, IsPrimaryKey = true)]
        public Int32 Id { get { return _id; } set { SetField(ref _id, value); } }

        private String _nif = string.Empty;
        [Column(Name = "Nif", DbType = DbType.String)]
        public String NIF { get { return _nif; } set { SetField(ref _nif, value); } }

        private String _nombreComercial = string.Empty;
        [Column(Name = "NombreComercial", DbType = DbType.String)]
        public String NombreComercial { get { return _nombreComercial; } set { SetField(ref _nombreComercial, value); } }

        private String _nombreFiscal = string.Empty;
        [Column(Name = "NombreFiscal", DbType = DbType.String)]
        public String NombreFiscal { get { return _nombreFiscal; } set { SetField(ref _nombreFiscal, value); } }

        private String _direccion = string.Empty;
        [Column(Name = "Direccion", DbType = DbType.String)]
        public String Direccion { get { return _direccion; } set { SetField(ref _direccion, value); } }

        private String _telefono = string.Empty;
        [Column(Name = "Telefono", DbType = DbType.String)]
        public String Telefono { get { return _telefono; } set { SetField(ref _telefono, value); } }

        private String _movil = string.Empty;
        [Column(Name = "Movil", DbType = DbType.String)]
        public String Movil { get { return _movil; } set { SetField(ref _movil, value); } }

        private String _email = string.Empty;
        [Column(Name = "Email", DbType = DbType.String)]
        public String Email { get { return _email; } set { SetField(ref _email, value); } }

        private String _numCuenta = string.Empty;
        [Column(Name = "NumCuenta", DbType = DbType.String)]
        public String NumeroCuenta { get { return _numCuenta; } set { SetField(ref _numCuenta, value); } }

        private String _observaciones = string.Empty;
        [Column(Name = "Observaciones", DbType = DbType.String)]
        public String Observaciones { get { return _observaciones; } set { SetField(ref _observaciones, value); } }
    }
}
