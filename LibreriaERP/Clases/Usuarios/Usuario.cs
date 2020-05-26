using Nowtic.Lib.Mapper;
using Nowtic.Lib.Mapper.MapAttribute;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaERP.Clases.Usuarios
{
    [Table(Name = TABLE_USUARIOS)]
    public class Usuario : DataObjectEntity<Usuario>
    {
        public const String TABLE_USUARIOS = "UsuariosBase";

        private Int32 _id = 0;
        [Column(Name = "Id", DbType = DbType.Int32, IsPrimaryKey = true)]
        public Int32 Id { get { return _id; } set { SetField(ref _id, value); } }

        private String _login = string.Empty;
        [Column(Name = "Login", DbType = DbType.String)]
        public String Login { get { return _login; } set { SetField(ref _login, value); } }

        private String _pass = string.Empty;
        [Column(Name = "Pass", DbType = DbType.String)]
        public String Pass { get { return _pass; } set { SetField(ref _pass, value); } }

        private String _nombre = string.Empty;
        [Column(Name = "Nombre", DbType = DbType.String)]
        public String Nombre { get { return _nombre; } set { SetField(ref _nombre, value); } }

        private String _apellidos = string.Empty;
        [Column(Name = "Apellidos", DbType = DbType.String)]
        public String Apellidos { get { return _apellidos; } set { SetField(ref _apellidos, value); } }

        private String _telefono = string.Empty;
        [Column(Name = "Telefono", DbType = DbType.String)]
        public String Telefono { get { return _telefono; } set { SetField(ref _telefono, value); } }

        private String _email = string.Empty;
        [Column(Name = "Email", DbType = DbType.String)]
        public String Email { get { return _email; } set { SetField(ref _email, value); } }
    }
}
