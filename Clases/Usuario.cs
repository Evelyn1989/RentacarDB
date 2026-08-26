using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentacarDB.Modelos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Cedula { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
        public int IdPerfil { get; set; }

        public Usuario() { }

        public Usuario(int idUsuario, string cedula, string nombreUsuario, string contrasena,
                        string correo, bool estado, int idPerfil)
        {
            IdUsuario = idUsuario;
            Cedula = cedula;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Correo = correo;
            Estado = estado;
            IdPerfil = idPerfil;
        }
    }
}
